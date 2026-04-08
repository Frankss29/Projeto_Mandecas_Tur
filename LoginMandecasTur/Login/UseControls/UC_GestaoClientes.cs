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

            dvgClientes.ReadOnly = false;

            // Estilização Avançada do Grid
            dvgClientes.EnableHeadersVisualStyles = false; // Permite mudar a cor do cabeçalho
            dvgClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(232, 232, 232);
            dvgClientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dvgClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleciona a linha toda
            dvgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Altura das linhas para dar "respiro" ao design
            dvgClientes.RowTemplate.Height = 35;

            // 2. Adicionando dados "fakes" para teste de layout
            dvgClientes.Rows.Add("CL084", "João Silva", "123.456.789-00", "(11) 98564-8871", "joaosilva12@gmail.com");
            dvgClientes.Rows.Add("CL077", "Maria Souza", "987.654.321-00", "(11) 92715-8941", "mariasouza15@gmail.com");
            dvgClientes.Rows.Add("CL035", "Carlos Lima", "456.123.789-01", "(11) 98080-9437", "limascarlos@gmail.com");

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
            // 1. Ignora se clicar no cabeçalho ou fora de uma linha válida
            if (e.RowIndex < 0) return;

            // Identifica qual coluna foi clicada pelo Nome
            string nomeColuna = dvgClientes.Columns[e.ColumnIndex].Name;

            // --- LÓGICA DO EDITAR ---
            if (nomeColuna == "btnEditar")
            {
                Form homeForm = this.ParentForm;

                if (homeForm != null)
                {
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
                        MessageBox.Show("Não encontrei o painel de destino (panelContainer) no formulário principal.");
                    }
                }
            }
            // --- LÓGICA DO EXCLUIR (Agora fora do bloco do Editar) ---
            else if (nomeColuna == "btnExcluir")
            {
                var confirmacao = MessageBox.Show("Tem certeza que deseja excluir?", "Atenção",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.Yes)
                {
                    // O código para remover a linha da grid ou do banco entra aqui
                    // Exemplo para remover apenas da grid visualmente:
                    // dvgClientes.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void UC_GestaoClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarGClientes_Click(object sender, EventArgs e)
        {

        }
    }
}