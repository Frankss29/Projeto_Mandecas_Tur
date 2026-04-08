namespace Login
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pnlMenu = new Panel();
            btnFuncionario = new Button();
            btnRelatorio = new Button();
            btnFinanceiro = new Button();
            btnGestaoViagens = new Button();
            btnGestaoClientes = new Button();
            panelContainer = new Panel();
            pnlNavBar = new Panel();
            pnlFecharMinimizarTela = new Panel();
            lbRecolher = new Label();
            lbMinimizar = new Label();
            lbFechar = new Label();
            imgNomeLogoHome = new PictureBox();
            imgLogoHome = new PictureBox();
            pnlUserName = new Panel();
            lbUserName = new Label();
            imgIconUserHome = new PictureBox();
            lbUsuario = new Label();
            pnlMenu.SuspendLayout();
            pnlNavBar.SuspendLayout();
            pnlFecharMinimizarTela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgNomeLogoHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogoHome).BeginInit();
            pnlUserName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgIconUserHome).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.White;
            pnlMenu.Controls.Add(btnFuncionario);
            pnlMenu.Controls.Add(btnRelatorio);
            pnlMenu.Controls.Add(btnFinanceiro);
            pnlMenu.Controls.Add(btnGestaoViagens);
            pnlMenu.Controls.Add(btnGestaoClientes);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 81);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(800, 53);
            pnlMenu.TabIndex = 3;
            // 
            // btnFuncionario
            // 
            btnFuncionario.FlatAppearance.BorderSize = 0;
            btnFuncionario.FlatStyle = FlatStyle.Flat;
            btnFuncionario.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnFuncionario.Location = new Point(603, 0);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Size = new Size(147, 51);
            btnFuncionario.TabIndex = 6;
            btnFuncionario.Text = "Funcionários";
            btnFuncionario.UseVisualStyleBackColor = true;
            btnFuncionario.Click += btnFuncionario_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnRelatorio.Location = new Point(454, 0);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(147, 51);
            btnRelatorio.TabIndex = 5;
            btnRelatorio.Text = "Relatórios";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnFinanceiro
            // 
            btnFinanceiro.FlatAppearance.BorderSize = 0;
            btnFinanceiro.FlatStyle = FlatStyle.Flat;
            btnFinanceiro.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnFinanceiro.Location = new Point(305, 0);
            btnFinanceiro.Name = "btnFinanceiro";
            btnFinanceiro.Size = new Size(147, 51);
            btnFinanceiro.TabIndex = 4;
            btnFinanceiro.Text = "Financeiro";
            btnFinanceiro.UseVisualStyleBackColor = true;
            btnFinanceiro.Click += btnFinanceiro_Click;
            // 
            // btnGestaoViagens
            // 
            btnGestaoViagens.FlatAppearance.BorderSize = 0;
            btnGestaoViagens.FlatStyle = FlatStyle.Flat;
            btnGestaoViagens.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnGestaoViagens.Location = new Point(156, 0);
            btnGestaoViagens.Name = "btnGestaoViagens";
            btnGestaoViagens.Size = new Size(147, 51);
            btnGestaoViagens.TabIndex = 3;
            btnGestaoViagens.Text = "Gestão de Viagens";
            btnGestaoViagens.UseVisualStyleBackColor = true;
            btnGestaoViagens.Click += btnGestaoViagens_Click;
            // 
            // btnGestaoClientes
            // 
            btnGestaoClientes.FlatAppearance.BorderSize = 0;
            btnGestaoClientes.FlatStyle = FlatStyle.Flat;
            btnGestaoClientes.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestaoClientes.Location = new Point(5, 0);
            btnGestaoClientes.Name = "btnGestaoClientes";
            btnGestaoClientes.Size = new Size(147, 51);
            btnGestaoClientes.TabIndex = 2;
            btnGestaoClientes.Text = "Gestão de Clientes";
            btnGestaoClientes.UseVisualStyleBackColor = true;
            btnGestaoClientes.Click += btnGestaoClientes_Click;
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 134);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(800, 427);
            panelContainer.TabIndex = 4;
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.FromArgb(68, 252, 124);
            pnlNavBar.Controls.Add(pnlFecharMinimizarTela);
            pnlNavBar.Controls.Add(imgNomeLogoHome);
            pnlNavBar.Controls.Add(imgLogoHome);
            pnlNavBar.Controls.Add(pnlUserName);
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(800, 81);
            pnlNavBar.TabIndex = 2;
            pnlNavBar.MouseDown += pnlNavBar_MouseDown;
            // 
            // pnlFecharMinimizarTela
            // 
            pnlFecharMinimizarTela.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlFecharMinimizarTela.Controls.Add(lbRecolher);
            pnlFecharMinimizarTela.Controls.Add(lbMinimizar);
            pnlFecharMinimizarTela.Controls.Add(lbFechar);
            pnlFecharMinimizarTela.Location = new Point(715, 0);
            pnlFecharMinimizarTela.Name = "pnlFecharMinimizarTela";
            pnlFecharMinimizarTela.Size = new Size(85, 29);
            pnlFecharMinimizarTela.TabIndex = 4;
            // 
            // lbRecolher
            // 
            lbRecolher.AutoSize = true;
            lbRecolher.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbRecolher.Location = new Point(9, 3);
            lbRecolher.Name = "lbRecolher";
            lbRecolher.Size = new Size(16, 21);
            lbRecolher.TabIndex = 6;
            lbRecolher.Text = "-";
            lbRecolher.Click += lbRecolher_Click;
            // 
            // lbMinimizar
            // 
            lbMinimizar.AutoSize = true;
            lbMinimizar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMinimizar.Location = new Point(33, 3);
            lbMinimizar.Name = "lbMinimizar";
            lbMinimizar.Size = new Size(22, 20);
            lbMinimizar.TabIndex = 5;
            lbMinimizar.Text = "❐";
            lbMinimizar.Click += lbMinimizar_Click;
            // 
            // lbFechar
            // 
            lbFechar.AutoSize = true;
            lbFechar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFechar.ForeColor = Color.DimGray;
            lbFechar.Location = new Point(62, 3);
            lbFechar.Name = "lbFechar";
            lbFechar.Size = new Size(18, 20);
            lbFechar.TabIndex = 4;
            lbFechar.Text = "X";
            lbFechar.Click += lbFechar_Click_1;
            // 
            // imgNomeLogoHome
            // 
            imgNomeLogoHome.Image = (Image)resources.GetObject("imgNomeLogoHome.Image");
            imgNomeLogoHome.Location = new Point(98, 32);
            imgNomeLogoHome.Name = "imgNomeLogoHome";
            imgNomeLogoHome.Size = new Size(180, 29);
            imgNomeLogoHome.SizeMode = PictureBoxSizeMode.Zoom;
            imgNomeLogoHome.TabIndex = 2;
            imgNomeLogoHome.TabStop = false;
            // 
            // imgLogoHome
            // 
            imgLogoHome.Image = (Image)resources.GetObject("imgLogoHome.Image");
            imgLogoHome.Location = new Point(12, 7);
            imgLogoHome.Name = "imgLogoHome";
            imgLogoHome.Size = new Size(76, 73);
            imgLogoHome.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogoHome.TabIndex = 1;
            imgLogoHome.TabStop = false;
            // 
            // pnlUserName
            // 
            pnlUserName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlUserName.BackColor = Color.White;
            pnlUserName.Controls.Add(lbUserName);
            pnlUserName.Controls.Add(imgIconUserHome);
            pnlUserName.Controls.Add(lbUsuario);
            pnlUserName.Location = new Point(659, 35);
            pnlUserName.Name = "pnlUserName";
            pnlUserName.Size = new Size(127, 40);
            pnlUserName.TabIndex = 0;
            pnlUserName.Paint += pnlUserName_Paint;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(19, 20);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(38, 15);
            lbUserName.TabIndex = 3;
            lbUserName.Text = "label2";
            // 
            // imgIconUserHome
            // 
            imgIconUserHome.Image = (Image)resources.GetObject("imgIconUserHome.Image");
            imgIconUserHome.Location = new Point(86, 6);
            imgIconUserHome.Name = "imgIconUserHome";
            imgIconUserHome.Size = new Size(27, 27);
            imgIconUserHome.SizeMode = PictureBoxSizeMode.Zoom;
            imgIconUserHome.TabIndex = 3;
            imgIconUserHome.TabStop = false;
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsuario.Location = new Point(12, 4);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(54, 17);
            lbUsuario.TabIndex = 2;
            lbUsuario.Text = "Usuário";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 561);
            Controls.Add(panelContainer);
            Controls.Add(pnlMenu);
            Controls.Add(pnlNavBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            pnlMenu.ResumeLayout(false);
            pnlNavBar.ResumeLayout(false);
            pnlFecharMinimizarTela.ResumeLayout(false);
            pnlFecharMinimizarTela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgNomeLogoHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogoHome).EndInit();
            pnlUserName.ResumeLayout(false);
            pnlUserName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgIconUserHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Button btnGestaoViagens;
        private Button btnGestaoClientes;
        private Panel pnlNavBar;
        private PictureBox imgNomeLogoHome;
        private PictureBox imgLogoHome;
        private Panel pnlUserName;
        private Label lbUserName;
        private PictureBox imgIconUserHome;
        private Label lbUsuario;
        private Panel panelContainer;
        private Button btnRelatorio;
        private Button btnFinanceiro;
        private Panel pnlFecharMinimizarTela;
        private Label lbMinimizar;
        private Label lbFechar;
        private Label lbRecolher;
        private Button btnFuncionario;
    }
}