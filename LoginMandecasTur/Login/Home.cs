using Login.UseControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login
{
    public partial class Home : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Home()
        {
            InitializeComponent();
            UC_GestaoClientes uc = new UC_GestaoClientes();
            addUserControl(uc);

        }
        private void Home_Load(object sender, EventArgs e)
        {
            // Isso faz com que o "Maximizar" respeite o espaço da barra de tarefas
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //nao ta funcionado
            this.WindowState = FormWindowState.Maximized;
        }

        private void Home_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); ///NAO TA FUNCIONANDO
        }

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
                // Garante que vai respeitar a área de trabalho antes de maximizar
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void lbRecolher_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


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

        private void addUserControl(UserControl userControl)
        {
            // 1. Limpa o que estava no painel antes
            panelContainer.Controls.Clear();

            // 2. Configura o UC para NÃO esticar (senão a centralização morre)
            userControl.Dock = DockStyle.Fill;

            // 3. Calcula a posição central
            // Se o UC for maior que o painel, o Location fica em 0,0 e o AutoScroll resolve
            int x = Math.Max(0, (panelContainer.Width - userControl.Width) / 2);
            int y = Math.Max(0, (panelContainer.Height - userControl.Height) / 2);

            userControl.Location = new Point(x, y);

            // 4. Adiciona ao painel
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

       
    }
}
