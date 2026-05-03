using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.UseControls
{
    public partial class UC_IncluirPassageiros : UserControl
    {
        int id_IncluirPassageiro;
        public UC_IncluirPassageiros(int idIncluirPassageiro)
        {
            InitializeComponent();
            id_IncluirPassageiro = idIncluirPassageiro;

            dgvListaDePassageiros.ReadOnly = false;

            // Estilização Avançada do Grid
            dgvListaDePassageiros.EnableHeadersVisualStyles = false; // Permite mudar a cor do cabeçalho
            dgvListaDePassageiros.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
            dgvListaDePassageiros.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvListaDePassageiros.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha toda
            dgvListaDePassageiros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Altura das linhas para dar "respiro" ao design
            dgvListaDePassageiros.RowTemplate.Height = 35;


            //CRIA A COLUNA AÇÕES UMA ÚNICA VEZ
            if (!dgvListaDePassageiros.Columns.Contains("btnExcluir"))
            {
                DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
                btnExcluir.Name = "btnExcluir";
                btnExcluir.Text = "🗑️";
                btnExcluir.UseColumnTextForButtonValue = true;
                btnExcluir.FlatStyle = FlatStyle.Flat;
                btnExcluir.Width = 60;

                dgvListaDePassageiros.Columns.Add(btnExcluir);
            }


        }

        private void OrganizarColunasPassageiros()
        {
            if (dgvListaDePassageiros.Columns.Contains("Codigo"))
            {
                dgvListaDePassageiros.Columns["Codigo"].HeaderText = "Código";
                dgvListaDePassageiros.Columns["Codigo"].DisplayIndex = 0;
            }

            if (dgvListaDePassageiros.Columns.Contains("Nome"))
            {
                dgvListaDePassageiros.Columns["Nome"].HeaderText = "Nome";
                dgvListaDePassageiros.Columns["Nome"].DisplayIndex = 1;
            }

            if (dgvListaDePassageiros.Columns.Contains("CPF"))
            {
                dgvListaDePassageiros.Columns["CPF"].HeaderText = "CPF";
                dgvListaDePassageiros.Columns["CPF"].DisplayIndex = 2;
            }

            if (dgvListaDePassageiros.Columns.Contains("Contato"))
            {
                dgvListaDePassageiros.Columns["Contato"].HeaderText = "Contato";
                dgvListaDePassageiros.Columns["Contato"].DisplayIndex = 3;
            }

            if (dgvListaDePassageiros.Columns.Contains("btnExcluir"))
            {
                dgvListaDePassageiros.Columns["btnExcluir"].HeaderText = "Ações";
                dgvListaDePassageiros.Columns["btnExcluir"].DisplayIndex =
                    dgvListaDePassageiros.Columns.Count - 1; // ✅ SEMPRE ÚLTIMO
            }
        }

        private void UC_IncluirPassageiros_Load(object sender, EventArgs e)
        {
            lbIDViagemIncluirPassageiros.Text = id_IncluirPassageiro.ToString();
            CarregarClientes();
            AtualizarGridPassageiros();
        }

        private void AtualizarGridPassageiros()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();

                string sql = @"
                SELECT 
                c.id_cliente AS Codigo,
                c.nome       AS Nome,
                c.cpf        AS CPF,
                c.telefone   AS Contato
                FROM reserva r
                INNER JOIN cliente c ON c.id_cliente = r.id_cliente
                 WHERE r.id_viagem = @id_viagem";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id_viagem", id_IncluirPassageiro);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvListaDePassageiros.DataSource = dt;

                // ✅ ORGANIZA COLUNAS (igual UC_Funcionario)
                OrganizarColunasPassageiros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar passageiros: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void CarregarClientes()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string sql = "SELECT id_cliente, nome FROM cliente ORDER BY nome";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbCliente.DataSource = dt;
                cbCliente.DisplayMember = "nome";     // o usuário vê
                cbCliente.ValueMember = "id_cliente"; // o sistema salva

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }

        }


        private void LimparCampos()
        {
            cbCliente.SelectedIndex = -1;
            txtFormaDePagamentoIncluirPassageiros.Clear();
            txtValorDaEntradaIncluirPassageiros.Clear();
            txtNumeroDeParcelasIncluirPassageiros.Clear();
        }


        private void btnSalvarIncluirPassageiros_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();


            if (cbCliente.SelectedValue == null)
            {
                MessageBox.Show("Selecione um cliente válido.");
                return;
            }

            try
            {
                con.Open();
                string sqlIncluir = "INSERT INTO Reserva(id_cliente, id_viagem,forma_pagamento, valor_entrada, qtdd_parcelas,status_pagamento)" +
                    "VALUES(@id_cliente, @id_viagem,@forma_pagamento, @valor_entrada, @qtdd_parcelas,@status_pagamento)";
                MySqlCommand cmd = new MySqlCommand(sqlIncluir, con);
                cmd.Parameters.AddWithValue("@id_cliente", cbCliente.SelectedValue);
                cmd.Parameters.AddWithValue("@id_viagem", id_IncluirPassageiro);
                cmd.Parameters.AddWithValue("@forma_pagamento", txtFormaDePagamentoIncluirPassageiros.Text);
                cmd.Parameters.AddWithValue("@valor_entrada", txtValorDaEntradaIncluirPassageiros.Text);
                cmd.Parameters.AddWithValue("@qtdd_parcelas", txtNumeroDeParcelasIncluirPassageiros.Text);
                cmd.Parameters.AddWithValue("@status_pagamento", "Pendente");

                cmd.ExecuteNonQuery();

                MessageBox.Show("Passageiro incluído com sucesso!");

                // Atualiza a lista abaixo
                AtualizarGridPassageiros();
                // Limpa os campos (opcional)
                LimparCampos();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar reserva: " + ex.Message);
            }
        }

        private void btnVoltarIncluirPassageiros_Click(object sender, EventArgs e)
        {
            Form homeForm = this.ParentForm;

            if (homeForm is Home home)
            {

                home.DesbloquearMenu();
                // Encontra o panelContainer
                Control[] controls = homeForm.Controls.Find("panelContainer", true);

                if (controls.Length > 0 && controls[0] is Panel pnlPrincipal)
                {
                    pnlPrincipal.Controls.Clear();

                    // Volta para o UC_GestaoClientes
                    UC_GestaoViagens EditarViagem = new UC_GestaoViagens();
                    EditarViagem.Dock = DockStyle.Fill;
                    pnlPrincipal.Controls.Add(EditarViagem);
                }


            }
        }
        private void dgvListaDePassageiros_Paint_1(object sender, PaintEventArgs e)
        {
            try
            {
                // 1. Localiza os índices das colunas

                int col1 = dgvListaDePassageiros.Columns["btnExcluir"].Index;

                // 2. Obtém a área (retângulo) ocupada pelos cabeçalhos dessas colunas
                Rectangle r1 = dgvListaDePassageiros.GetCellDisplayRectangle(col1, -1, true);


                // 3. Cria um retângulo único que junta as duas áreas
                Rectangle areaAcoes = new Rectangle(r1.X, r1.Y, r1.Width, r1.Height);

                // 4. Pinta o fundo do cabeçalho (usando a cor que você já definiu para a grid)
                using (SolidBrush sb = new SolidBrush(dgvListaDePassageiros.ColumnHeadersDefaultCellStyle.BackColor))
                {
                    e.Graphics.FillRectangle(sb, areaAcoes);
                }

                // 5. Desenha o texto "Ações" centralizado nessa nova área
                TextRenderer.DrawText(e.Graphics, "Ações", dgvListaDePassageiros.ColumnHeadersDefaultCellStyle.Font,
                    areaAcoes, dgvListaDePassageiros.ColumnHeadersDefaultCellStyle.ForeColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
            }
            catch { /* Evita erros caso as colunas ainda não existam no momento da pintura */ }
        }

        private void dgvListaDePassageiros_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string nomeColuna = dgvListaDePassageiros.Columns[e.ColumnIndex].Name;

            if (nomeColuna == "btnExcluir")
            {
                var confirmacao = MessageBox.Show(
                    "Tem certeza que deseja excluir?",
                    "Atenção",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacao != DialogResult.Yes)
                    return;

                // ✅ COLUNA CORRETA
                int idSelecionado = Convert.ToInt32(
                    dgvListaDePassageiros.Rows[e.RowIndex].Cells["Codigo"].Value
                );

                Conexao conexao = new Conexao();
                using (MySqlConnection con = conexao.Conectar())
                {
                    try
                    {
                        con.Open();

                        string sqlDelete = @"
                    DELETE FROM reserva
                    WHERE id_cliente = @id_cliente
                      AND id_viagem  = @id_viagem";

                        MySqlCommand cmd = new MySqlCommand(sqlDelete, con);
                        cmd.Parameters.AddWithValue("@id_cliente", idSelecionado);
                        cmd.Parameters.AddWithValue("@id_viagem", id_IncluirPassageiro);

                        // ✅ EXECUTA DE FATO
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Passageiro excluído com sucesso!");
                        AtualizarGridPassageiros();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }
 
    }
}
