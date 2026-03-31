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
    public partial class UC_GestaoClientes : UserControl
    {
        public UC_GestaoClientes()
        {
            InitializeComponent();

            // Estilização Avançada do Grid
            dgvClientes.EnableHeadersVisualStyles = false; // Permite mudar a cor do cabeçalho
            dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
            dgvClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha toda
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Altura das linhas para dar "respiro" ao design
            dgvClientes.RowTemplate.Height = 35;


            // 2. Adicionando dados "fakes" para teste de layout
            dgvClientes.Rows.Add("CL084", "João Silva", "123.456.789-00", "(11) 98564-8871", "joaosilva12@gmail.com");
            dgvClientes.Rows.Add("CL077", "Maria Souza", "987.654.321-00", "(11) 92715-8941", "mariasouza15@gmail.com");
            dgvClientes.Rows.Add("CL035", "Carlos Lima", "456.123.789-01", "(11) 98080-9437", "limascarlos@gmail.com");

        }

        private void btnBuscarGClientes_Click(object sender, EventArgs e)
        {

        }

        private void pnlCadastroCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Ignora se clicar no cabeçalho
            if (e.RowIndex < 0) return;

            // 2. Verifica se clicou na coluna de Editar (agora com o nome correto!)
            if (dgvClientes.Columns[e.ColumnIndex].Name == "btnEditar")
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
                        UC_EditarCliente EditarCliente = new UC_EditarCliente();
                        EditarCliente.Dock = DockStyle.Fill;
                        pnlPrincipal.Controls.Add(EditarCliente);
                    }
                    else
                    {
                        // Se cair aqui, é porque o nome do Painel na Home não é "panelContainer"
                        MessageBox.Show("Não encontrei o painel de destino no formulário principal.");
                    }
                }
            }

            // 3. Verifica se clicou na coluna de Excluir
            if (dgvClientes.Columns[e.ColumnIndex].Name == "btnExcluir")
            {
                var confirmacao = MessageBox.Show("Tem certeza que deseja excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacao == DialogResult.Yes)
                {
                    // Código para deletar aqui
                }
            }
        }
    }
}