using Login.UseControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
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

        // --- VARIÁVEIS PARA ARMAZENAR AS TELAS E EVITAR VAZAMENTO DE MEMÓRIA ---
        private UC_GestaoClientes telaClientes;
        private UC_GestaoViagens telaViagens;
        private UC_Financeiro telaFinanceiro;
        private UC_RegistrarEntrada telaReservas;
        private UC_Funcionario telaFuncionario;
        // ------------------------------------------------------------------------

        public Home()
        {
            InitializeComponent();
            MoverLinhaNav(btnGestaoClientes);

            // Inicia a primeira tela e guarda na variável
            telaClientes = new UC_GestaoClientes();
            addUserControl(telaClientes);
        }

        public static bool IsDarkMode = false;

        public void AplicarTemaHome()
        {
            if (IsDarkMode)
            {
                this.BackgroundImage = Properties.Resources.img_fundo_escuro;
                this.BackgroundImageLayout = ImageLayout.Stretch;

                pnlNavBar.BackColor = Color.FromArgb(10, 25, 20);

                imgLogoHome.Image = Properties.Resources.logo_vazado_branco;

                darkModeToolStripMenuItem.ForeColor = Color.Gainsboro;

                pnlMenu.BackColor = Color.FromArgb(15, 40, 30);

                foreach (Control c in pnlMenu.Controls)
                {
                    if (c is Button btn)
                    {
                        btn.FlatStyle = FlatStyle.Flat;

                        if (IsDarkMode)
                        {
                            btn.ForeColor = Color.Gainsboro;
                            btn.BackColor = Color.Transparent;
                            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 80, 60);
                            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 40, 30);
                            btn.FlatAppearance.BorderSize = 0;
                        }
                        else
                        {
                            btn.ForeColor = Color.Black;
                            btn.BackColor = Color.White;
                            btn.FlatAppearance.MouseOverBackColor = Color.LightGray;
                            btn.FlatAppearance.BorderSize = 1;
                        }
                    }
                }

                foreach (Control c in this.Controls)
                {
                    c.Font = new Font("Segoe UI", 9, FontStyle.Regular);

                    if (IsDarkMode)
                    {
                        if (c is TextBox || c is DateTimePicker)
                        {
                            c.BackColor = Color.FromArgb(45, 45, 45);
                            c.ForeColor = Color.White;
                        }
                        if (c is Label) c.ForeColor = Color.Gainsboro;
                    }
                    else
                    {
                        if (c is TextBox || c is DateTimePicker)
                        {
                            c.BackColor = Color.White;
                            c.ForeColor = Color.Black;
                        }
                    }
                }

                darkModeToolStripMenuItem.Text = "Light Mode";
            }
            else
            {
                this.BackgroundImage = null;
                this.BackColor = SystemColors.Control;
                pnlNavBar.BackColor = Color.FromArgb(0, 255, 127);
                imgLogoHome.Image = Properties.Resources.logo_vazado_branco;

                darkModeToolStripMenuItem.ForeColor = Color.Black;

                pnlMenu.BackColor = Color.White;

                btnGestaoClientes.ForeColor = Color.Black;
                btnGestaoViagens.ForeColor = Color.Black;
                btnReservas.ForeColor = Color.Black;
                btnFinanceiro.ForeColor = Color.Black;
                btnFuncionario.ForeColor = Color.Black;

                darkModeToolStripMenuItem.Text = "Dark Green";
            }
        }
        private void Home_Load(object sender, EventArgs e)
        {
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
            ArredondarPainel((Panel)sender, 20);
        }
        private void CentralizarConteudo(Control conteudo)
        {
            int x = (panelContainer.Width - conteudo.Width) / 2;
            int y = (panelContainer.Height - conteudo.Height) / 2;

            conteudo.Location = new Point(Math.Max(0, x), Math.Max(0, y));
        }
        #endregion

        #region Botões de Controle - Navegação - Menu

        public void BloquearMenu()
        {
            btnGestaoClientes.Enabled = false;
            btnGestaoViagens.Enabled = false;
            btnFinanceiro.Enabled = false;
            btnReservas.Enabled = false;
            btnFuncionario.Enabled = false;
        }

        public void DesbloquearMenu()
        {
            btnGestaoClientes.Enabled = true;
            btnGestaoViagens.Enabled = true;
            btnFinanceiro.Enabled = true;
            btnReservas.Enabled = true;
            btnFuncionario.Enabled = true;
        }

        private void MoverLinhaNav(Control btn)
        {
            pnlNav.Width = btn.Width;
            pnlNav.Left = btn.Left;
            pnlNav.Visible = true;
        }

        private void addUserControl(UserControl userControl)
        {
            // Apenas limpa a exibição visual (sem destruir a memória da tela anterior)
            panelContainer.Controls.Clear();

            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(userControl);
        }

        private void btnGestaoClientes_Click(object sender, EventArgs e)
        {
            MoverLinhaNav((Control)sender);

            // Verifica se a tela já foi criada. Se não, cria. Se sim, apenas exibe.
            if (telaClientes == null)
            {
                telaClientes = new UC_GestaoClientes();
            }
            addUserControl(telaClientes);
        }

        private void btnGestaoViagens_Click(object sender, EventArgs e)
        {
            MoverLinhaNav((Control)sender);

            if (telaViagens == null)
            {
                telaViagens = new UC_GestaoViagens();
            }
            addUserControl(telaViagens);
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            MoverLinhaNav((Control)sender);

            if (telaFinanceiro == null)
            {
                telaFinanceiro = new UC_Financeiro();
            }
            else
            {
                // Atualiza os dados para garantir que a grid e os cards reflitam alterações recentes
                telaFinanceiro.AtualizarGrid();
                telaFinanceiro.AtualizarCards();
            }
            addUserControl(telaFinanceiro);
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            MoverLinhaNav((Control)sender);

            if (telaReservas == null)
            {
                telaReservas = new UC_RegistrarEntrada();
            }
            addUserControl(telaReservas);
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            MoverLinhaNav((Control)sender);

            if (telaFuncionario == null)
            {
                telaFuncionario = new UC_Funcionario();
            }
            addUserControl(telaFuncionario);
        }

        #endregion

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgConfigurar_Click(object sender, EventArgs e)
        {
            MostrarMenuPerfil(sender, e);
        }

        #region Novo Menu de Perfil Flutuante (Engrenagem)
        private void MostrarMenuPerfil(object sender, EventArgs e)
        {
            ContextMenuStrip menuPerfil = new ContextMenuStrip();

            Color corFundoMenu = IsDarkMode ? Color.FromArgb(30, 30, 30) : Color.White;
            Color corTextoMenu = IsDarkMode ? Color.Gainsboro : Color.Black;

            menuPerfil.BackColor = corFundoMenu;
            menuPerfil.ShowImageMargin = true;

            menuPerfil.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            menuPerfil.Cursor = Cursors.Hand;
            menuPerfil.ImageScalingSize = new Size(20, 20);

            menuPerfil.Renderer = new ToolStripProfessionalRenderer(new TemaMenuPlano(corFundoMenu));

            ToolStripMenuItem menuTema = new ToolStripMenuItem();
            menuTema.ForeColor = corTextoMenu;

            string caminhoNovoSol = @"C:\relatorios\Generated Image May 12, 2026 - 8_16PM.jpg";
            string caminhoNovaLua = @"C:\relatorios\Generated Image May 12, 2026 - 8_28PM.jpg";

            if (IsDarkMode)
            {
                menuTema.Text = "Light Mode";
                if (File.Exists(caminhoNovoSol)) menuTema.Image = Image.FromFile(caminhoNovoSol);
            }
            else
            {
                menuTema.Text = "Dark Green";
                if (File.Exists(caminhoNovaLua)) menuTema.Image = Image.FromFile(caminhoNovaLua);
            }

            menuTema.Click += (s, args) =>
            {
                IsDarkMode = !IsDarkMode;
                AplicarTemaHome();
                AtualizarTelasInternas();
            };

            ToolStripSeparator linha = new ToolStripSeparator();

            ToolStripMenuItem menuSair = new ToolStripMenuItem("Sair do App");

            string caminhoIconeSair = @"C:\relatorios\Captura de tela 2026-05-12 195223.png";
            if (File.Exists(caminhoIconeSair)) menuSair.Image = Image.FromFile(caminhoIconeSair);

            menuSair.ForeColor = Color.Red;
            menuSair.Click += (s, args) =>
            {
                DialogResult confirmacao = MessageBox.Show(
                    "Deseja realmente fechar o sistema?",
                    "Sair",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (confirmacao == DialogResult.Yes)
                {
                    Application.Exit();
                }
            };

            menuPerfil.Items.Add(menuTema);
            menuPerfil.Items.Add(linha);
            menuPerfil.Items.Add(menuSair);

            Control controleClicado = (Control)sender;
            menuPerfil.Show(controleClicado, new Point(controleClicado.Width, controleClicado.Height), ToolStripDropDownDirection.BelowLeft);
        }

        private void AtualizarTelasInternas()
        {
            if (panelContainer.Controls.Count > 0)
            {
                var ucAberta = panelContainer.Controls[0];

                if (ucAberta is UC_GestaoClientes ucCli) ucCli.AtualizarTema(IsDarkMode);
                else if (ucAberta is UC_EditarCliente ucEdit) ucEdit.AtualizarTema(IsDarkMode);
            }
        }
        #endregion

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void imgIconUserHome_Click(object sender, EventArgs e)
        {
            MostrarMenuUsuario(sender, e);
        }

        #region Novo Menu de Logout / Trocar Conta (Usuário)
        private void MostrarMenuUsuario(object sender, EventArgs e)
        {
            ContextMenuStrip menuUsuario = new ContextMenuStrip();

            Color corFundoMenu = IsDarkMode ? Color.FromArgb(30, 30, 30) : Color.White;
            Color corTextoMenu = IsDarkMode ? Color.Gainsboro : Color.Black;

            menuUsuario.BackColor = corFundoMenu;
            menuUsuario.ShowImageMargin = true;

            menuUsuario.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            menuUsuario.Cursor = Cursors.Hand;
            menuUsuario.ImageScalingSize = new Size(20, 20);

            menuUsuario.Renderer = new ToolStripProfessionalRenderer(new TemaMenuPlano(corFundoMenu));

            // =========================================================
            // OPÇÃO 1: TROCAR USUÁRIO
            // =========================================================
            ToolStripMenuItem menuTrocarUsuario = new ToolStripMenuItem("Trocar de usuário");
            menuTrocarUsuario.ForeColor = corTextoMenu;

            string caminhoIconeTrocar = @"C:\relatorios\Captura de tela 2026-05-12 195243.png";
            if (File.Exists(caminhoIconeTrocar)) menuTrocarUsuario.Image = Image.FromFile(caminhoIconeTrocar);

            menuTrocarUsuario.Click += (s, args) =>
            {
                DialogResult confirmacao = MessageBox.Show(
                    "Deseja voltar para a tela de login?",
                    "Trocar de Usuário",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (confirmacao == DialogResult.Yes)
                {
                    Application.Restart();
                }
            };

            ToolStripSeparator linhaDivisoria = new ToolStripSeparator();

            // =========================================================
            // OPÇÃO 2: SAIR DO APP
            // =========================================================
            ToolStripMenuItem menuSair = new ToolStripMenuItem("Sair do App");
            menuSair.ForeColor = Color.Red;

            string caminhoIconeSair = @"C:\relatorios\Captura de tela 2026-05-12 195223.png";
            if (File.Exists(caminhoIconeSair)) menuSair.Image = Image.FromFile(caminhoIconeSair);

            menuSair.Click += (s, args) =>
            {
                DialogResult confirmacao = MessageBox.Show(
                    "Deseja realmente fechar o sistema?",
                    "Sair",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (confirmacao == DialogResult.Yes)
                {
                    Application.Exit();
                }
            };

            menuUsuario.Items.Add(menuTrocarUsuario);
            menuUsuario.Items.Add(linhaDivisoria);
            menuUsuario.Items.Add(menuSair);

            Control controleClicado = (Control)sender;
            menuUsuario.Show(controleClicado, new Point(controleClicado.Width, controleClicado.Height), ToolStripDropDownDirection.BelowLeft);
        }
        #endregion
    }

    public class TemaMenuPlano : ProfessionalColorTable
    {
        private Color _corDeFundo;

        public TemaMenuPlano(Color corDeFundo)
        {
            _corDeFundo = corDeFundo;
        }

        public override Color ImageMarginGradientBegin => _corDeFundo;
        public override Color ImageMarginGradientMiddle => _corDeFundo;
        public override Color ImageMarginGradientEnd => _corDeFundo;
        public override Color ToolStripDropDownBackground => _corDeFundo;
        public override Color MenuBorder => Color.LightGray;
    }
}