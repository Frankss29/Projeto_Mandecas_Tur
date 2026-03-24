
using System.Runtime.InteropServices; // Necessário para a movimentação

namespace Login
{
    public partial class TelaLogin : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public TelaLogin()
        {
            InitializeComponent();
        }

        private void TelaLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
        // Método para manter o card sempre no meio
        private void CentralizarPainel()
        {
            pnlLogin.Location = new Point(
                (this.ClientSize.Width - pnlLogin.Width) / 2,
                (this.ClientSize.Height - pnlLogin.Height) / 2
            );
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            // Crie uma variável com a cor EXATA do fundo do seu painel
            // Importante: Não use transparência (o primeiro número do Argb) aqui, 
            // pois o TextBox não aceita. Use apenas o R, G, B.
            Color corFundoPainel = Color.FromArgb(10, 25, 10);

            // Aplica nos TextBoxes
            txtUsuarioLogin.BackColor = corFundoPainel;
            txtSenhaLogin.BackColor = corFundoPainel;




            CentralizarPainel();
        }

        private void TelaLogin_Resize(object sender, EventArgs e)
        {
            CentralizarPainel();
        }


        private void lbFecharLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbFecharLogin_MouseEnter(object sender, EventArgs e)
        {
            lbFecharLogin.BackColor = Color.SpringGreen;
        }

        private void lbFecharLogin_MouseLeave(object sender, EventArgs e)
        {
            lbFecharLogin.BackColor = Color.FromArgb(14, 46, 19);
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {
            // 1. Criar o GraphicsPath com cantos arredondados (Radius: 25).
            // 2. Preencher com Color.FromArgb(190, 10, 30, 10).
            // 3. Desenhar a borda fina com Color.FromArgb(50, 255, 255, 255).
            // 4. Setar a Region do painel para o path criado.

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Definição do Retângulo e Arredondamento 
            Rectangle rect = new Rectangle(0, 0, pnlLogin.Width - 1, pnlLogin.Height - 1);
            int radius = 26;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();


            // 1. Preenchimento (Verde Escuro Semi-transparente) 
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(200, 10, 30, 10)))
            {
                g.FillPath(brush, path);
            }

            // 2. Borda do Painel (Linha fina branca/clara) 
            using (Pen pen = new Pen(Color.FromArgb(50, 255, 255, 255), 1))
            {
                g.DrawPath(pen, path);
            }

            // Aplica o arredondamento à região do controle para cortar as quinas 
            pnlLogin.Region = new Region(path);
        }


        //Placeholder do TextBoxs
        // --- USUÁRIO ---
        private void txtUsuarioLogin_Enter(object sender, EventArgs e)
        {
            if (txtUsuarioLogin.Text == "Usuário")
            {
                txtUsuarioLogin.Text = "";
                txtUsuarioLogin.ForeColor = Color.White;
            }
            pnlLinhaUsuarioLogin.BackColor = Color.Lime; // Acende a linha

        }

        private void txtUsuarioLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuarioLogin.Text))
            {
                txtUsuarioLogin.Text = "Usuário";
                txtUsuarioLogin.ForeColor = Color.Silver;
            }
            pnlLinhaUsuarioLogin.BackColor = Color.SpringGreen;
        }

        // --- SENHA ---

        private void txtSenhaLogin_Enter(object sender, EventArgs e)
        {
            if (txtSenhaLogin.Text == "Senha")
            {
                txtSenhaLogin.Text = "";
                txtSenhaLogin.PasswordChar = '●'; //Esconder caracteres
                txtSenhaLogin.ForeColor = Color.White;
            }
            pnlLinhaSenhaLogin.BackColor = Color.Lime;//acende a linha
        }

        private void txtSenhaLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSenhaLogin.Text))
            {
                txtSenhaLogin.Text = "Senha";
                txtSenhaLogin.PasswordChar = '\0';
                txtSenhaLogin.ForeColor = Color.Silver;
            }
            pnlLinhaSenhaLogin.BackColor = Color.SpringGreen;
        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            Home TelaHome = new Home();
            TelaHome.Show();
            this.Hide();
        }
    }
}
