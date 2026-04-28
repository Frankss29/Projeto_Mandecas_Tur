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
    public partial class UC_EditarViagem : UserControl
    {
        int id_EditarViagem;
        public UC_EditarViagem(int idviagem)
        {
            InitializeComponent();
            id_EditarViagem = idviagem;
        }
        public void Carregar()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();
            try
            {
                string sql = @"
                SELECT id_viagem, destino, data_viagem, qtdd_vagas, tipo_transporte, custo_transporte, custo_hospedagem, valor_unitario 
                FROM viagem
                WHERE id_viagem = @id_viagem";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id_viagem", id_EditarViagem);

                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtDestino.Text = reader["destino"].ToString();
                    dtpDataViagemEditarViagem.Value = Convert.ToDateTime(reader["data_viagem"].ToString());
                    txtQtdDeViagem.Text = reader["qtdd_vagas"].ToString();
                    txtTransporte.Text = reader["tipo_transporte"].ToString();
                    txtValorUnitario.Text = reader["valor_unitario"].ToString();
                    txtCustoDoTransporte.Text = reader["custo_transporte"].ToString();
                    txtCustoDaHospedagem.Text = reader["custo_hospedagem"].ToString();




                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSalvarEditarViagem_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();
            try
            {
                con.Open();
                string atualizar = "UPDATE viagem SET destino = @destino, data_viagem = @data_viagem, qtdd_vagas = @qtdd_vagas, tipo_transporte = @tipo_transporte, custo_transporte = @custo_transporte, custo_hospedagem = @custo_hospedagem, valor_unitario = @valor_unitario WHERE id_viagem = @id_viagem";
                MySqlCommand cmd = new MySqlCommand(atualizar, con);
                cmd.Parameters.AddWithValue("@destino", txtDestino.Text);
                cmd.Parameters.AddWithValue("@data_viagem", dtpDataViagemEditarViagem.Value);
                cmd.Parameters.AddWithValue("@qtdd_vagas", txtQtdDeViagem.Text);
                cmd.Parameters.AddWithValue("@tipo_transporte", txtTransporte.Text);
                cmd.Parameters.AddWithValue("@custo_transporte", txtCustoDoTransporte.Text);
                cmd.Parameters.AddWithValue("@custo_hospedagem", txtCustoDaHospedagem.Text);
                cmd.Parameters.AddWithValue("@valor_unitario", txtValorUnitario.Text);
                cmd.Parameters.AddWithValue("@id_viagem", id_EditarViagem);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Viagem atualizada com sucesso!");

                Form homeForm = this.ParentForm;

                if (homeForm != null)
                {
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UC_EditarViagem_Load(object sender, EventArgs e)
        {
            Carregar();
            dtpDataViagemEditarViagem.Value = DateTime.Now;
            lbIDViagem.Text = id_EditarViagem.ToString();
        }

        private void btnCancelarEditarViagem_Click(object sender, EventArgs e)
        {
            Form homeForm = this.ParentForm;

            if (homeForm != null)
            {
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
    }
}
