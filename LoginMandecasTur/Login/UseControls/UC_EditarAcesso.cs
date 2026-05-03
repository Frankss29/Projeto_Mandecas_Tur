using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.UseControls
{
    public partial class UC_EditarAcesso : UserControl
    {
        int id_usuario;
        public UC_EditarAcesso(int idfuncionarios)
        {
            InitializeComponent();
            id_usuario = idfuncionarios;
        }

        public void carregar()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();
            try
            {
                string sql = @"
                SELECT nome,documento,email,perfil_acesso
                FROM funcionario
                WHERE id_funcionario = @id_funcionario";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id_funcionario", id_usuario);

                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtnomeacesso.Text = reader["nome"].ToString();
                    txtcpfacesso.Text = reader["documento"].ToString();
                    txtemailacesso.Text = reader["email"].ToString();
                    cbmperfil.Text = reader["perfil_acesso"].ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void UC_EditarAcesso_Load(object sender, EventArgs e)
        {
            carregar();
            lbCodigo.Text = id_usuario.ToString();


        }

        private void pnlCadastro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalvarEditarAcesso_Click(object sender, EventArgs e)
        
        {
            if (string.IsNullOrWhiteSpace(txtnomeacesso.Text) ||
        string.IsNullOrWhiteSpace(txtcpfacesso.Text) ||
        string.IsNullOrWhiteSpace(txtemailacesso.Text) ||
                cbmperfil.SelectedItem == null)

            {
                MessageBox.Show("Os campos não podem ficar vazios durante a edição!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Bloqueia a execução do UPDATE
            }

            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string atualizar = "UPDATE funcionario Set nome = @nome,email = @email,documento = @documento,perfil_acesso=@perfil_acesso " +
                    "WHERE id_funcionario = @id_funcionario";
                MySqlCommand cmd = new MySqlCommand(atualizar, con);
                cmd.Parameters.AddWithValue("@nome", txtnomeacesso.Text);
                cmd.Parameters.AddWithValue("@documento", txtcpfacesso.Text);
                cmd.Parameters.AddWithValue("@email", txtemailacesso.Text);
                cmd.Parameters.AddWithValue("@perfil_acesso", cbmperfil.Text);
                cmd.Parameters.AddWithValue("@id_funcionario", lbCodigo.Text); // ESSENCIAL

                cmd.ExecuteNonQuery();


                MessageBox.Show("Perfil Atualizado com Sucesso");
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
                        UC_Funcionario atFuncionario = new UC_Funcionario();
                        atFuncionario.Dock = DockStyle.Fill;
                        pnlPrincipal.Controls.Add(atFuncionario);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("As alterações não foram salvas. Tem certeza que deseja sair?", "Confirmar Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 2. TUDO o que troca a tela deve ficar dentro deste IF
            if (resultado == DialogResult.Yes)
            {
                Form homeForm = this.ParentForm;

                if (homeForm is Home home)
                {
                    home.DesbloquearMenu();
                    // Busca o painel onde as telas são carregadas
                    Control[] controls = homeForm.Controls.Find("panelContainer", true);

                    if (controls.Length > 0 && controls[0] is Panel pnlPrincipal)
                    {
                        pnlPrincipal.Controls.Clear();

                        // Cria a tela de funcionários para voltar
                        UC_Funcionario atFuncionario = new UC_Funcionario();
                        atFuncionario.Dock = DockStyle.Fill;
                        pnlPrincipal.Controls.Add(atFuncionario);
                    }
                }
            }
            // Se o usuário clicar em 'Não', o código simplesmente não entra no IF 
            // e nada acontece, mantendo ele na tela de edição.
        }
    }
    
}

