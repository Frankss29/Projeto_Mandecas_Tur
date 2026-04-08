using Login.UseControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login
{
    #region Movimentação de Tela
    public partial class Home : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlNavBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        public Home()
        {
            InitializeComponent();
            UC_GestaoClientes uc = new UC_GestaoClientes();
            addUserControl(uc);

        }
        private void Home_Load(object sender, EventArgs e)
        {
            // Primeiro define o limite
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            // Depois define o estado
            this.WindowState = FormWindowState.Maximized;
        }

        #region Botões Ciclo de Vida - Tela
        private void lbFechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbMinimizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                // Re-atualiza a área de trabalho caso você tenha movido de monitor
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void lbRecolher_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion


        #region Design do Painel /Layout
        private void ArredondarPainel(Panel panel, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(panel.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(panel.Width - raio, panel.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, panel.Height - raio, raio, raio, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void pnlUserName_Paint(object sender, PaintEventArgs e)
        {
            ArredondarPainel((Panel)sender, 20); // Ajuste o raio conforme desejado
        }
        private void CentralizarConteudo(Control conteudo)
        {
            int x = (panelContainer.Width - conteudo.Width) / 2;
            int y = (panelContainer.Height - conteudo.Height) / 2;

            // Math.Max(0, ...) garante que se a tela for pequena, o conteúdo não "fuja" para fora do topo
            conteudo.Location = new Point(Math.Max(0, x), Math.Max(0, y));
        }
        #endregion


        #region Botões de Controle - Navegação - Menu
        private void addUserControl(UserControl userControl)
        {
            panelContainer.Controls.Clear();

            if (panelContainer.Controls.Count > 0)
            {
                // Limpa e libera memória do controle anterior
                Control oldControl = panelContainer.Controls[0];
                panelContainer.Controls.Remove(oldControl);
                oldControl.Dispose();
            }

            // Altere de None para Fill para o User Control ocupar todo o painel cinza
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(userControl);

        }


        private void btnGestaoClientes_Click(object sender, EventArgs e)
        {
            UC_GestaoClientes Home = new UC_GestaoClientes();
            addUserControl(Home);
        }

        private void btnGestaoViagens_Click(object sender, EventArgs e)
        {
            UC_GestaoViagens Viagem = new UC_GestaoViagens();
            addUserControl(Viagem);
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            UC_Financeiro Financeiro = new UC_Financeiro();
            addUserControl(Financeiro);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            UC_Relatorio Relatorio = new UC_Relatorio();
            addUserControl(Relatorio);
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            UC_Funcionario Funcionario = new UC_Funcionario();
            addUserControl(Funcionario);
        }

        #endregion
    }
}
