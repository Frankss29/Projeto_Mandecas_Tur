using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login.UseControls
{
    public partial class UC_Funcionario : UserControl
    {
        public UC_Funcionario()
        {
            InitializeComponent();

            dvgFuncionarios.ReadOnly = false;

            // Estilização Avançada do Grid
            dvgFuncionarios.EnableHeadersVisualStyles = false; // Permite mudar a cor do cabeçalho
            dvgFuncionarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
            dvgFuncionarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dvgFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha toda
            dvgFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Altura das linhas para dar "respiro" ao design
            dvgFuncionarios.RowTemplate.Height = 35;

            // 2. Adicionando dados "fakes" para teste de layout
            /*dvgFuncionarios.Rows.Add("000", "Amanda Silva", "888.456.719-00", "amanda12@gmail.com", "154289", "Administrador");
            dvgFuncionarios.Rows.Add("001", "William Santos", "987.333.321-44", "santos.william@gmail.com", "859556", "Administrador");
            dvgFuncionarios.Rows.Add("002", "Ana Souza", "456.123.769-13", "anaSouza@gmail.com", "87585s89", "Padrão");*/


        }


        private void dvgFuncionarios_Paint(object sender, PaintEventArgs e)
        {

            try
            {
                // 1. Localiza os índices das colunas
                int col1 = dvgFuncionarios.Columns["btnEditar"].Index;
                int col2 = dvgFuncionarios.Columns["btnExcluir"].Index;

                // 2. Obtém a área (retângulo) ocupada pelos cabeçalhos dessas colunas
                Rectangle r1 = dvgFuncionarios.GetCellDisplayRectangle(col1, -1, true);
                Rectangle r2 = dvgFuncionarios.GetCellDisplayRectangle(col2, -1, true);

                // 3. Cria um retângulo único que junta as duas áreas
                Rectangle areaAcoes = new Rectangle(r1.X, r1.Y, r1.Width + r2.Width, r1.Height);

                // 4. Pinta o fundo do cabeçalho (usando a cor que você já definiu para a grid)
                using (SolidBrush sb = new SolidBrush(dvgFuncionarios.ColumnHeadersDefaultCellStyle.BackColor))
                {
                    e.Graphics.FillRectangle(sb, areaAcoes);
                }

                // 5. Desenha o texto "Ações" centralizado nessa nova área
                TextRenderer.DrawText(e.Graphics, "Ações", dvgFuncionarios.ColumnHeadersDefaultCellStyle.Font,
                    areaAcoes, dvgFuncionarios.ColumnHeadersDefaultCellStyle.ForeColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
            }
            catch { /* Evita erros caso as colunas ainda não existam no momento da pintura */ }
        }

        private void dvgFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Ignora se clicar no cabeçalho
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0 &&
                   dvgFuncionarios.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                // Busca o formulário Home (onde a UC está inserida)
                Form homeForm = this.ParentForm;

                if (homeForm != null)
                {
                    // PROCURA o panelContainer dentro da Home, mesmo que ele esteja "escondido"
                    Control[] controls = homeForm.Controls.Find("panelContainer", true);

                    if (controls.Length > 0 && controls[0] is Panel pnlPrincipal)
                    {
                        pnlPrincipal.Controls.Clear();
                        UC_EditarAcesso EditarAcesso = new UC_EditarAcesso();
                        EditarAcesso.Dock = DockStyle.Fill;
                        pnlPrincipal.Controls.Add(EditarAcesso);
                    }
                    else
                    {
                        // Se cair aqui, é porque o nome do Painel na Home não é "panelContainer"
                        MessageBox.Show("Não encontrei o painel de destino no formulário principal.");
                    }
                }

                // --- LÓGICA DO EXCLUIR ---
                else if (dvgFuncionarios.Columns[e.ColumnIndex].Name == "btnExcluir")
                {
                    var confirmacao = MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmacao == DialogResult.Yes)
                    {
                        // Código para deletar aqui
                    }
                }

            }
        }

        private void UC_Funcionario_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection conn = conexao.Conectar();

            CBPerfilAcesso.Items.Clear();
            CBPerfilAcesso.Items.Add("Administrador");
            CBPerfilAcesso.Items.Add("Padrão");
            CBPerfilAcesso.SelectedIndex = 1; // Deixa "Padrão" selecionado por padrão

            string sqlMostrar = "SELECT * FROM funcionario";

            //vai adaptar as informações do banco e dados para o DGV.
            MySqlDataAdapter adp = new MySqlDataAdapter(sqlMostrar, conn);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            dvgFuncionarios.DataSource = dt;
        }


        private void btnSalvarCAcesso_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection conn = conexao.Conectar();

            try
            {
                conn.Open();

                string sqlInserir = "INSERT INTO funcionario (nome, email, senha, documento, perfil_acesso) VALUES (@nome, @email, @senha, @cpf, @perfil_acesso)";

                MySqlCommand cmd = new MySqlCommand(sqlInserir, conn);

                cmd.Parameters.AddWithValue("@nome", txtNomeCAcesso.Text);
                cmd.Parameters.AddWithValue("@email", txtEmailCAcesso.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenhaCAcesso.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCPFCAcesso.Text);
                cmd.Parameters.AddWithValue("@perfil_acesso", CBPerfilAcesso.SelectedItem.ToString());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário cadastrado com sucesso!");
                txtNomeCAcesso.Clear();
                txtEmailCAcesso.Clear();
                txtSenhaCAcesso.Clear();
                txtCPFCAcesso.Clear();
                txtNomeCAcesso.Focus();

                string sqlMostrar = "SELECT * FROM funcionario";

                //vai adaptar as informações do banco e dados para o DGV.
                MySqlDataAdapter adp = new MySqlDataAdapter(sqlMostrar, conn);

                DataTable dt = new DataTable();
                adp.Fill(dt);

                dvgFuncionarios.DataSource = dt;

              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection conn = conexao.Conectar();

            try
            {
                conn.Open();
                string texto = txtBuscaFuncionario.Text.Trim();
                string sql;

                // 1. Tenta converter para número para saber se é ID ou CPF
                bool ehNumero = long.TryParse(texto, out _);

                if (ehNumero && texto.Length <= 4)
                {
                    // Se for número e tiver até 4 dígitos, tratamos como ID:
                    sql = "SELECT id_funcionario, nome, email FROM funcionario WHERE id_funcionario LIKE @id_funcionario";
                    MySqlCommand cmd4 = new MySqlCommand(sql, conn);
                    cmd4.Parameters.AddWithValue("@id_funcionario", "%" + texto + "%");

                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd4);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dvgFuncionarios.DataSource = dt;

                    txtBuscaFuncionario.Clear();
                    txtBuscaFuncionario.Focus();


                }
                else if (ehNumero && texto.Length >= 11)
                {
                    // Se for número e tiver 11 ou mais dígitos, tratamos como CPF:
                    sql = "SELECT id_funcionario, nome, email FROM funcionario WHERE documento LIKE @cpf";
                    MySqlCommand cmd2 = new MySqlCommand(sql, conn);
                    cmd2.Parameters.AddWithValue("@cpf", "%" + texto + "%");

                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dvgFuncionarios.DataSource = dt;

                    txtBuscaFuncionario.Clear();
                    txtBuscaFuncionario.Focus();

                }
                else
                {

                    sql = "SELECT id_funcionario, nome, email FROM funcionario WHERE nome LIKE @nome";
                    MySqlCommand cmd3 = new MySqlCommand(sql, conn);
                    cmd3.Parameters.AddWithValue("@nome", "%" + texto + "%");

                    MySqlDataAdapter adp  = new MySqlDataAdapter(cmd3);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dvgFuncionarios.DataSource = dt;

                    txtBuscaFuncionario.Clear();
                    txtBuscaFuncionario.Focus();

                }
              
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close(); 
            }

        }

        private void txtBuscaFuncionario_TextChanged(object sender, EventArgs e)
        {
            // 1. Remove tudo que não for número para processar a máscara
            string textoLimpo = System.Text.RegularExpressions.Regex.Replace(txtBuscaFuncionario.Text, @"[^0-9]", "");
            string resultado = "";

            if (textoLimpo.Length > 3 && textoLimpo.Length <= 11)
            {
                if (textoLimpo.Length <= 3) resultado = textoLimpo;
                else if (textoLimpo.Length <= 6) resultado = textoLimpo.Insert(3, ".");
                else if (textoLimpo.Length <= 9) resultado = textoLimpo.Insert(3, ".").Insert(7, ".");
                else resultado = textoLimpo.Insert(3, ".").Insert(7, ".").Insert(11, "-");

                // 3. Atualiza o texto sem causar um loop infinito de eventos
                txtBuscaFuncionario.Text = resultado;

                // 4. Joga o cursor para o final do texto (se não ele volta pro começo!)
                txtBuscaFuncionario.SelectionStart = txtBuscaFuncionario.Text.Length;
            }
        }
    
    }
}
