using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login.UseControls
{
    public partial class UC_GestaoViagens : UserControl
    {
        public UC_GestaoViagens()
        {
            InitializeComponent();

            dvgViagens.ReadOnly = false;

            // Estilização Avançada do Grid
            dvgViagens.EnableHeadersVisualStyles = false; // Permite mudar a cor do cabeçalho
            dvgViagens.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
            dvgViagens.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dvgViagens.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha toda
            dvgViagens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Altura das linhas para dar "respiro" ao design
            dvgViagens.RowTemplate.Height = 35;

            /* // 2. Adicionando dados "fakes" para teste de layout
             dvgViagens.Rows.Add("000", "Amanda Silva", "888.456.719-00", "amanda12@gmail.com", "154289", "Administrador");
             dvgViagens.Rows.Add("001", "William Santos", "987.333.321-44", "santos.william@gmail.com", "859556", "Administrador");
             dvgViagens.Rows.Add("002", "Ana Souza", "456.123.769-13", "anaSouza@gmail.com", "87585s89", "Padrão");*/

        }
        public void AtualizarGrid()

        {

            Conexao conexao = new Conexao();

            MySqlConnection con = conexao.Conectar();

            try

            {

                con.Open();

                string sqlMostrar = "SELECT id_viagem, destino, data_viagem, qtdd_vagas, tipo_transporte FROM viagem ";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlMostrar, con);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dvgViagens.DataSource = dt;

                // --- ORDENAÇÃO MANUAL DAS COLUNAS (O segredo está aqui) ---

                // O DisplayIndex define a posição da esquerda para a direita (0 é a primeira)

                if (dvgViagens.Columns.Contains("id_viagem"))

                {

                    dvgViagens.Columns["id_viagem"].HeaderText = "Código";

                    dvgViagens.Columns["id_viagem"].DisplayIndex = 0;

                }

                // 1. Nome Completo

                if (dvgViagens.Columns.Contains("destino"))

                {

                    dvgViagens.Columns["destino"].HeaderText = "Destino";

                    dvgViagens.Columns["destino"].DisplayIndex = 1;

                }

                // 2. CPF

                if (dvgViagens.Columns.Contains("data_viagem"))

                {

                    dvgViagens.Columns["data_viagem"].HeaderText = "Data";

                    dvgViagens.Columns["data_viagem"].DisplayIndex = 2;

                }

                // 3. Data de Nascimento

                if (dvgViagens.Columns.Contains("qtdd_vagas"))

                {

                    dvgViagens.Columns["qtdd_vagas"].HeaderText = "Vagas";

                    dvgViagens.Columns["qtdd_vagas"].DisplayIndex = 3;

                }

                // 4. Telefone

                if (dvgViagens.Columns.Contains("tipo_transporte"))

                {

                    dvgViagens.Columns["tipo_transporte"].HeaderText = "Transporte";

                    dvgViagens.Columns["tipo_transporte"].DisplayIndex = 4;

                }



                // 6 e 7. Ações (Botões sempre por último e colados um no outro)

                if (dvgViagens.Columns.Contains("btnEditar"))

                    dvgViagens.Columns["btnEditar"].DisplayIndex = 6;

                if (dvgViagens.Columns.Contains("btnExcluir"))

                    dvgViagens.Columns["btnExcluir"].DisplayIndex = 7;

                lblLimparFiltro.Visible = false; // Esconde a label

            }

            catch (Exception ex)

            {

                MessageBox.Show("Erro ao carregar dados: " + ex.Message);

            }

        }


        private void dvgViagens_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                // 1. Localiza os índices das colunas
                int col1 = dvgViagens.Columns["btnEditar"].Index;
                int col2 = dvgViagens.Columns["btnIncluir"].Index;
                int col3 = dvgViagens.Columns["btnExcluir"].Index;

                // 2. Obtém a área (retângulo) ocupada pelos cabeçalhos dessas colunas
                Rectangle r1 = dvgViagens.GetCellDisplayRectangle(col1, -1, true);
                Rectangle r2 = dvgViagens.GetCellDisplayRectangle(col2, -1, true);


                // 3. Cria um retângulo único que junta as duas áreas
                Rectangle areaAcoes = new Rectangle(r1.X, r1.Y, r1.Width + r2.Width, r1.Height);

                // 4. Pinta o fundo do cabeçalho (usando a cor que você já definiu para a grid)
                using (SolidBrush sb = new SolidBrush(dvgViagens.ColumnHeadersDefaultCellStyle.BackColor))
                {
                    e.Graphics.FillRectangle(sb, areaAcoes);
                }

                // 5. Desenha o texto "Ações" centralizado nessa nova área
                TextRenderer.DrawText(e.Graphics, "Ações", dvgViagens.ColumnHeadersDefaultCellStyle.Font,
                    areaAcoes, dvgViagens.ColumnHeadersDefaultCellStyle.ForeColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
            }
            catch { /* Evita erros caso as colunas ainda não existam no momento da pintura */ }

        }

        private void dvgViagens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Ignora se clicar no cabeçalho
            if (e.RowIndex < 0) return;

            Form homeForm = this.ParentForm;

            // --- LÓGICA DO EDITAR ---
            if (dvgViagens.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                if (homeForm != null)
                {
                    Control[] controls = homeForm.Controls.Find("panelContainer", true);
                    if (controls.Length > 0 && controls[0] is Panel pnlPrincipal)
                    {
                        pnlPrincipal.Controls.Clear();
                        UC_EditarViagem EditarViagem = new UC_EditarViagem();
                        EditarViagem.Dock = DockStyle.Fill;
                        pnlPrincipal.Controls.Add(EditarViagem);
                    }
                }
            }
            // --- LÓGICA DO INCLUIR (Note que agora ele é independente) ---
            else if (dvgViagens.Columns[e.ColumnIndex].Name == "btnIncluir")
            {
                if (homeForm != null)
                {
                    Control[] controls = homeForm.Controls.Find("panelContainer", true);
                    if (controls.Length > 0 && controls[0] is Panel pnlPrincipal)
                    {
                        pnlPrincipal.Controls.Clear();
                        UC_IncluirPassageiros IncluirPassageiros = new UC_IncluirPassageiros();
                        IncluirPassageiros.Dock = DockStyle.Fill;
                        pnlPrincipal.Controls.Add(IncluirPassageiros);
                    }
                }
            }
            // --- LÓGICA DO EXCLUIR ---
            else if (dvgViagens.Columns[e.ColumnIndex].Name == "btnExcluir")
            {
                var confirmacao = MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacao == DialogResult.Yes)
                {
                    // Código para deletar aqui
                }
            }
        }


        private void RealizarBusca()

        {

            string textoBusca = txtBuscaGViagens.Text.Trim();

            Conexao conexao = new Conexao();

            MySqlConnection conn = conexao.Conectar();

            try

            {

                // Criamos dois parâmetros diferentes (@nome e @documento)

                string sql = "SELECT id_viagem, destino, data_viagem, qtdd_vagas, tipo_transporte FROM viagem " +

                             "WHERE destino LIKE @valor OR id_viagem LIKE @valor";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                // Parametro 1: Busca pelo nome (com o texto original)

                cmd.Parameters.AddWithValue("@valor", "%" + textoBusca + "%");

                // Parametro 2: Busca pelo documento (com o texto limpo pela função LimparCPF)



                MySqlDataAdapter adt = new MySqlDataAdapter(cmd);

                DataTable dtt = new DataTable();

                adt.Fill(dtt);

                dvgViagens.DataSource = dtt;

                if (!string.IsNullOrWhiteSpace(txtBuscaGViagens.Text))

                {

                    lblLimparFiltro.Visible = true;

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Erro no sistema: " + ex.Message);

            }

            finally

            {

                conn.Close();

            }

        }
        private void UC_GestaoClientes_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            DTPDataCViagem.Value = DateTime.Now;
        }



        private void btnBuscarGViagens_Click(object sender, EventArgs e)
        {
            RealizarBusca();
        }

        private void txtBuscaGViagens_KeyDown(object sender, KeyEventArgs e)
        {
            //Esse código é para o ENTER funcionar como o clique
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Remove o som do "beep"

                // O 'sender' é o campo que o usuário está usando no momento
                if (sender == txtBuscaGViagens)
                {
                    // Se o campo for o de busca, ele chama a função de buscar
                    RealizarBusca();
                }
                else
                {
                    // Se for qualquer outro campo (Nome, CPF, etc.), ele chama o Salvar
                    btnSalvarCViagem.PerformClick();
                }
            }
        }

        private void btnCancelarCViagem_Click(object sender, EventArgs e)
        {
            txtDestinoViagens.Clear(); txtTransporteCViagens.Clear(); txtQTDVagaCViagens.Clear();
            txtCustoTransporteCViagem.Clear(); txtCustoHospedagemCViagem.Clear(); txtValorUnitarioCViagem.Clear();

        }
        private void lblLimparFiltro_Click(object sender, EventArgs e)
        {
            txtBuscaGViagens.Clear();   // Limpa o campo de busca
            AtualizarGrid();   // Chama sua função que dá o SELECT sem WHERE
            lblLimparFiltro.Visible = false; // Esconde a label novamente
        }

        private void lblLimparFiltro_MouseEnter(object sender, EventArgs e)
        {
            lblLimparFiltro.Font = new Font(lblLimparFiltro.Font, FontStyle.Underline); // Adiciona sublinhado
        }

        private void lblLimparFiltro_MouseLeave(object sender, EventArgs e)
        {
            lblLimparFiltro.Font = new Font(lblLimparFiltro.Font, FontStyle.Regular);   // Remove sublinhado
        }

        private void btnSalvarCViagem_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();

            MySqlConnection conn = conexao.Conectar();

            try

            {

                conn.Open();

                string sqlInserir = "INSERT INTO Viagem (destino, data_viagem, qtdd_vagas, tipo_transporte) VALUES (@destino, @data_viagem, @qtdd_vagas, @tipo_transporte)";

                MySqlCommand cmd = new MySqlCommand(sqlInserir, conn);

                cmd.Parameters.AddWithValue("@destino", txtDestinoViagens.Text);

                cmd.Parameters.AddWithValue("@data_viagem", DTPDataCViagem.Value);

                cmd.Parameters.AddWithValue("@qtdd_vagas", txtQTDVagaCViagens.Text);

                cmd.Parameters.AddWithValue("@tipo_transporte", txtTransporteCViagens.Text);


                cmd.ExecuteNonQuery();

                MessageBox.Show("Viagem cadastrada com sucesso!");

                txtDestinoViagens.Clear();

                txtTransporteCViagens.Clear();

                txtQTDVagaCViagens.Clear();

                string sqlMostrar = "SELECT * FROM Viagem";

                //vai adaptar as informações do banco e dados para o DGV.

                MySqlDataAdapter adp = new MySqlDataAdapter(sqlMostrar, conn);

                DataTable dt = new DataTable();

                adp.Fill(dt);

                dvgViagens.DataSource = dt;

                AtualizarGrid();

            }

            catch (Exception ex)

            {

                MessageBox.Show("Erro no sistema.");

            }

            finally

            {

                conn.Close();

            }

        }

        private void UC_GestaoViagens_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
    }
}


