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


    public partial class UC_GestaoClientes : UserControl
    {
        public UC_GestaoClientes()
        {
            InitializeComponent();

            dvgClientes.ReadOnly = false;

            // Estilização Avançada do Grid
            dvgClientes.EnableHeadersVisualStyles = false; // Permite mudar a cor do cabeçalho
            dvgClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
            dvgClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dvgClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha toda
            dvgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Altura das linhas para dar "respiro" ao design
            dvgClientes.RowTemplate.Height = 35;

        }

        public void AtualizarGrid()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string sqlMostrar = "SELECT id_cliente, nome, cpf, data_nascimento, telefone, email FROM Cliente";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlMostrar, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dvgClientes.DataSource = dt;

                // --- ORDENAÇÃO MANUAL DAS COLUNAS (O segredo está aqui) ---
                // O DisplayIndex define a posição da esquerda para a direita (0 é a primeira)

                if (dvgClientes.Columns.Contains("id_cliente"))
                {
                    dvgClientes.Columns["id_cliente"].HeaderText = "Código";
                    dvgClientes.Columns["id_cliente"].DisplayIndex = 0;

                }

                // 1. Nome Completo
                if (dvgClientes.Columns.Contains("nome"))
                {
                    dvgClientes.Columns["nome"].HeaderText = "Nome Completo";
                    dvgClientes.Columns["nome"].DisplayIndex = 1;
                }

                // 2. CPF
                if (dvgClientes.Columns.Contains("cpf"))
                {
                    dvgClientes.Columns["cpf"].HeaderText = "CPF";
                    dvgClientes.Columns["cpf"].DisplayIndex = 2;
                }

                // 3. Data de Nascimento
                if (dvgClientes.Columns.Contains("data_nascimento"))
                {
                    dvgClientes.Columns["data_nascimento"].HeaderText = "Data de Nascimento";
                    dvgClientes.Columns["data_nascimento"].DisplayIndex = 3;
                }

                // 4. Telefone
                if (dvgClientes.Columns.Contains("telefone"))
                {
                    dvgClientes.Columns["telefone"].HeaderText = "Telefone";
                    dvgClientes.Columns["telefone"].DisplayIndex = 4;
                }

                // 5. E-mail
                if (dvgClientes.Columns.Contains("email"))
                {
                    dvgClientes.Columns["email"].HeaderText = "E-mail";
                    dvgClientes.Columns["email"].DisplayIndex = 5;
                }

                // 6 e 7. Ações (Botões sempre por último e colados um no outro)
                if (dvgClientes.Columns.Contains("btnEditar"))
                    dvgClientes.Columns["btnEditar"].DisplayIndex = 6;

                if (dvgClientes.Columns.Contains("btnExcluir"))
                    dvgClientes.Columns["btnExcluir"].DisplayIndex = 7;

                lblLimparFiltro.Visible = false; // Esconde a label
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }
        private void LimparCampos()
        {
            txtNomeGClientes.Clear();
            txtCPFGClientes.Clear();
            txtTelefoneGClientes.Clear();
            txtEmailGClientes.Clear();
            dtpDataNascGclientes.Value = DateTime.Now;
            txtNomeGClientes.Focus();
        }
        private void UC_GestaoClientes_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            dtpDataNascGclientes.Value = DateTime.Now;
        }

        private void dvgClientes_Paint(object sender, PaintEventArgs e)
        {

            try
            {
                // 1. Localiza os índices das colunas
                int col1 = dvgClientes.Columns["btnEditar"].Index;
                int col2 = dvgClientes.Columns["btnExcluir"].Index;

                // 2. Obtém a área (retângulo) ocupada pelos cabeçalhos dessas colunas
                Rectangle r1 = dvgClientes.GetCellDisplayRectangle(col1, -1, true);
                Rectangle r2 = dvgClientes.GetCellDisplayRectangle(col2, -1, true);

                // 3. Cria um retângulo único que junta as duas áreas
                Rectangle areaAcoes = new Rectangle(r1.X, r1.Y, r1.Width + r2.Width, r1.Height);

                // 4. Pinta o fundo do cabeçalho (usando a cor que você já definiu para a grid)
                using (SolidBrush sb = new SolidBrush(dvgClientes.ColumnHeadersDefaultCellStyle.BackColor))
                {
                    e.Graphics.FillRectangle(sb, areaAcoes);
                }

                // 5. Desenha o texto "Ações" centralizado nessa nova área
                TextRenderer.DrawText(e.Graphics, "Ações", dvgClientes.ColumnHeadersDefaultCellStyle.Font,
                    areaAcoes, dvgClientes.ColumnHeadersDefaultCellStyle.ForeColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
            }
            catch { /* Evita erros caso as colunas ainda não existam no momento da pintura */ }
        }

        private void dvgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // ✅ 1. Ignora clique no cabeçalho
            if (e.RowIndex < 0) return;

            // ✅ 2. Descobre qual coluna foi clicada
            string nomeColuna = dvgClientes.Columns[e.ColumnIndex].Name;

            // --- EDITAR ---
            if (nomeColuna == "btnEditar")
            {
                int idCliente = Convert.ToInt32(
                    dvgClientes.Rows[e.RowIndex].Cells["id_cliente"].Value
                );

                Form homeForm = this.ParentForm;

                if (homeForm != null)
                {
                    Control[] controls = homeForm.Controls.Find("panelContainer", true);

                    if (controls.Length > 0 && controls[0] is Panel pnlPrincipal)
                    {
                        pnlPrincipal.Controls.Clear();

                        UC_EditarCliente editarCliente = new UC_EditarCliente(idCliente);
                        editarCliente.Dock = DockStyle.Fill;
                        pnlPrincipal.Controls.Add(editarCliente);
                    }
                }
            }
            // --- EXCLUIR ---
            else if (nomeColuna == "btnExcluir")
            {
                var confirmacao = MessageBox.Show(
                    "Tem certeza que deseja excluir?",
                    "Atenção",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacao == DialogResult.Yes)
                {
                    int idSelecionado = Convert.ToInt32(
                        dvgClientes.Rows[e.RowIndex].Cells["id_cliente"].Value
                    );

                    Conexao conexao = new Conexao();
                    using (MySqlConnection con = conexao.Conectar())
                    {
                        try
                        {
                            con.Open();
                            string sqlDelete = "DELETE FROM Cliente WHERE id_cliente = @id_cliente";
                            MySqlCommand cmd = new MySqlCommand(sqlDelete, con);
                            cmd.Parameters.AddWithValue("@id_cliente", idSelecionado);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Cliente excluído com sucesso!");
                            AtualizarGrid();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
         }



        private void btnBuscarGClientes_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            string textoBusca = txtBuscaGCliente.Text.Trim();
            string sql;
            try
            {
                // SQL que busca em ambas as colunas ao mesmo tempo
                sql = "SELECT id_cliente, nome,cpf,data_nascimento,telefone, email FROM Cliente WHERE " +
                     " nome LIKE @valor OR cpf LIKE @valor";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                // O uso do % antes e depois permite encontrar resultados que contenham o termo
                // Ex: Se digitar "123", encontra o CPF "000.123.000-00"
                cmd.Parameters.AddWithValue("@valor", "%" + textoBusca + "%");

                MySqlDataAdapter adt = new MySqlDataAdapter(cmd);
                DataTable dtt = new DataTable();
                adt.Fill(dtt);

                dvgClientes.DataSource = dtt;

                // Se o campo de busca não estiver vazio, mostra a label
                if (!string.IsNullOrWhiteSpace(txtBuscaGCliente.Text))
                {
                    lblLimparFiltro.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar: " + ex.Message);
            }
        }

        private void btnSalvarGClientes_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string sqlInserir = "INSERT INTO Cliente(nome, cpf, data_nascimento, telefone, email)" +
                    "VALUES(@nome, @cpf, @data_nascimento, @telefone, @email)";
                MySqlCommand cmd = new MySqlCommand(sqlInserir, con);
                cmd.Parameters.AddWithValue("@nome", txtNomeGClientes.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCPFGClientes.Text);
                cmd.Parameters.AddWithValue("@data_nascimento", dtpDataNascGclientes.Value);
                cmd.Parameters.AddWithValue("@telefone", txtTelefoneGClientes.Text);
                cmd.Parameters.AddWithValue("@email", txtEmailGClientes.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuário Cadastrado com Sucesso!!");

                AtualizarGrid();
                LimparCampos();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void lblLimparFiltro_Click(object sender, EventArgs e)
        {
            txtBuscaGCliente.Clear();   // Limpa o campo de busca
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

        private void txtBuscaGCliente_TextChanged(object sender, EventArgs e)
        {
            // Se o usuário apagou tudo no campo, volta a mostrar todos os clientes automaticamente
            if (string.IsNullOrWhiteSpace(txtBuscaGCliente.Text))
            {
                AtualizarGrid();
            }
        }

        private void pnlCadastroCliente_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}