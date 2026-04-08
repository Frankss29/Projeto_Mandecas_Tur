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

            // 2. Adicionando dados "fakes" para teste de layout
            dvgViagens.Rows.Add("000", "Amanda Silva", "888.456.719-00", "amanda12@gmail.com", "154289", "Administrador");
            dvgViagens.Rows.Add("001", "William Santos", "987.333.321-44", "santos.william@gmail.com", "859556", "Administrador");
            dvgViagens.Rows.Add("002", "Ana Souza", "456.123.769-13", "anaSouza@gmail.com", "87585s89", "Padrão");

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
    }
}
