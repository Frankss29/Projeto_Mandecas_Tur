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
    public partial class UC_EditarCliente : UserControl
    {
        int id_usuario;

        public UC_EditarCliente(int idCliente)
        {
            InitializeComponent();
            id_usuario = idCliente;


        }
        public void carregar()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();
            try
            {
                string sqlMostrar = @"
                SELECT nome, cpf, data_nascimento, telefone, email
                FROM Cliente
                WHERE id_cliente = @id_cliente";

                MySqlCommand cmd = new MySqlCommand(sqlMostrar, con);
                cmd.Parameters.AddWithValue("@id_cliente", id_usuario);

                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtNomeCompleto.Text = reader["nome"].ToString();
                    txtCPFEditarCliente.Text = reader["cpf"].ToString();
                    dtpDataNascimento.Value = Convert.ToDateTime(reader["data_nascimento"]);
                    txtTelefoneEditarCliente.Text = reader["telefone"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSalvarEditarCliente_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string sqlAtualizar = " UPDATE cliente SET nome = @nome,email = @email,cpf = @cpf,data_nascimento = @data_nascimento," +
                    "telefone = @telefone WHERE id_cliente = @id_cliente";
                MySqlCommand cmd = new MySqlCommand(sqlAtualizar, con);
                cmd.Parameters.AddWithValue("@nome", txtNomeCompleto.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCPFEditarCliente.Text);
                cmd.Parameters.AddWithValue("@data_nascimento", dtpDataNascimento.Value);
                cmd.Parameters.AddWithValue("@telefone", txtTelefoneEditarCliente.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@id_cliente", id_usuario);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro Atualizado com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void UC_EditarCliente_Load(object sender, EventArgs e)
        {
            carregar();
            lbIDCliente.Text = id_usuario.ToString();
        }

        private void btnCancelarEditarCliente_Click(object sender, EventArgs e)
        {
            // Pega o formulário principal
            Form homeForm = this.ParentForm;

            if (homeForm != null)
            {
                // Encontra o panelContainer
                Control[] controls = homeForm.Controls.Find("panelContainer", true);

                if (controls.Length > 0 && controls[0] is Panel pnlPrincipal)
                {
                    pnlPrincipal.Controls.Clear();

                    // Volta para o UC_GestaoClientes
                    UC_GestaoClientes gestaoClientes = new UC_GestaoClientes();
                    gestaoClientes.Dock = DockStyle.Fill;
                    pnlPrincipal.Controls.Add(gestaoClientes);
                }
            }

        }
    }
}
