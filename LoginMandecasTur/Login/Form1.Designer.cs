namespace Login
{
    partial class TelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            lbFecharLogin = new Label();
            pnlLogin = new Panel();
            lbRodape = new Label();
            imgOnibusLogin = new PictureBox();
            imgNavioLogin = new PictureBox();
            imgAviaoLogin = new PictureBox();
            pnlSeparador = new Panel();
            btnEntrarLogin = new BotaoMandecas();
            imgLockLogin = new PictureBox();
            imgUserLogin = new PictureBox();
            pnlLinhaSenhaLogin = new Panel();
            pnlLinhaUsuarioLogin = new Panel();
            txtSenhaLogin = new TextBox();
            txtUsuarioLogin = new TextBox();
            lbSloganLogin = new Label();
            imgLogoLogin = new PictureBox();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgOnibusLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgNavioLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgAviaoLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLockLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgUserLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogoLogin).BeginInit();
            SuspendLayout();
            // 
            // lbFecharLogin
            // 
            lbFecharLogin.AutoSize = true;
            lbFecharLogin.BackColor = Color.Transparent;
            lbFecharLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFecharLogin.ForeColor = Color.White;
            lbFecharLogin.Location = new Point(809, 19);
            lbFecharLogin.Name = "lbFecharLogin";
            lbFecharLogin.Size = new Size(20, 21);
            lbFecharLogin.TabIndex = 0;
            lbFecharLogin.Text = "X";
            lbFecharLogin.Click += lbFecharLogin_Click;
            lbFecharLogin.MouseEnter += lbFecharLogin_MouseEnter;
            lbFecharLogin.MouseLeave += lbFecharLogin_MouseLeave;
            // 
            // pnlLogin
            // 
            pnlLogin.Anchor = AnchorStyles.None;
            pnlLogin.Controls.Add(lbRodape);
            pnlLogin.Controls.Add(imgOnibusLogin);
            pnlLogin.Controls.Add(imgNavioLogin);
            pnlLogin.Controls.Add(imgAviaoLogin);
            pnlLogin.Controls.Add(pnlSeparador);
            pnlLogin.Controls.Add(btnEntrarLogin);
            pnlLogin.Controls.Add(imgLockLogin);
            pnlLogin.Controls.Add(imgUserLogin);
            pnlLogin.Controls.Add(pnlLinhaSenhaLogin);
            pnlLogin.Controls.Add(pnlLinhaUsuarioLogin);
            pnlLogin.Controls.Add(txtSenhaLogin);
            pnlLogin.Controls.Add(txtUsuarioLogin);
            pnlLogin.Controls.Add(lbSloganLogin);
            pnlLogin.Controls.Add(imgLogoLogin);
            pnlLogin.Location = new Point(261, 55);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(300, 450);
            pnlLogin.TabIndex = 1;
            pnlLogin.Paint += pnlLogin_Paint;
            // 
            // lbRodape
            // 
            lbRodape.AutoSize = true;
            lbRodape.BackColor = Color.Transparent;
            lbRodape.ForeColor = Color.Gainsboro;
            lbRodape.Location = new Point(45, 414);
            lbRodape.Name = "lbRodape";
            lbRodape.Size = new Size(211, 15);
            lbRodape.TabIndex = 13;
            lbRodape.Text = "Viagens Terrestres • Aéreas • Marítimas";
            // 
            // imgOnibusLogin
            // 
            imgOnibusLogin.BackColor = Color.Transparent;
            imgOnibusLogin.Image = (Image)resources.GetObject("imgOnibusLogin.Image");
            imgOnibusLogin.Location = new Point(182, 364);
            imgOnibusLogin.Name = "imgOnibusLogin";
            imgOnibusLogin.Size = new Size(40, 40);
            imgOnibusLogin.SizeMode = PictureBoxSizeMode.Zoom;
            imgOnibusLogin.TabIndex = 12;
            imgOnibusLogin.TabStop = false;
            // 
            // imgNavioLogin
            // 
            imgNavioLogin.BackColor = Color.Transparent;
            imgNavioLogin.Image = (Image)resources.GetObject("imgNavioLogin.Image");
            imgNavioLogin.Location = new Point(131, 364);
            imgNavioLogin.Name = "imgNavioLogin";
            imgNavioLogin.Size = new Size(40, 40);
            imgNavioLogin.SizeMode = PictureBoxSizeMode.Zoom;
            imgNavioLogin.TabIndex = 11;
            imgNavioLogin.TabStop = false;
            // 
            // imgAviaoLogin
            // 
            imgAviaoLogin.BackColor = Color.Transparent;
            imgAviaoLogin.Image = (Image)resources.GetObject("imgAviaoLogin.Image");
            imgAviaoLogin.Location = new Point(80, 364);
            imgAviaoLogin.Name = "imgAviaoLogin";
            imgAviaoLogin.Size = new Size(40, 40);
            imgAviaoLogin.SizeMode = PictureBoxSizeMode.Zoom;
            imgAviaoLogin.TabIndex = 10;
            imgAviaoLogin.TabStop = false;
            // 
            // pnlSeparador
            // 
            pnlSeparador.BackColor = Color.SpringGreen;
            pnlSeparador.Location = new Point(51, 353);
            pnlSeparador.Name = "pnlSeparador";
            pnlSeparador.Size = new Size(200, 2);
            pnlSeparador.TabIndex = 9;
            // 
            // btnEntrarLogin
            // 
            btnEntrarLogin.Anchor = AnchorStyles.None;
            btnEntrarLogin.BackColor = Color.FromArgb(0, 102, 51);
            btnEntrarLogin.FlatAppearance.BorderSize = 0;
            btnEntrarLogin.FlatStyle = FlatStyle.Flat;
            btnEntrarLogin.Font = new Font("Segoe UI Semibold", 11F);
            btnEntrarLogin.ForeColor = Color.White;
            btnEntrarLogin.Location = new Point(51, 264);
            btnEntrarLogin.Name = "btnEntrarLogin";
            btnEntrarLogin.Size = new Size(200, 40);
            btnEntrarLogin.TabIndex = 8;
            btnEntrarLogin.Text = "Entrar";
            btnEntrarLogin.UseVisualStyleBackColor = false;
            btnEntrarLogin.Click += btnEntrarLogin_Click;
            // 
            // imgLockLogin
            // 
            imgLockLogin.BackColor = Color.Transparent;
            imgLockLogin.Image = (Image)resources.GetObject("imgLockLogin.Image");
            imgLockLogin.Location = new Point(58, 217);
            imgLockLogin.Name = "imgLockLogin";
            imgLockLogin.Size = new Size(21, 19);
            imgLockLogin.SizeMode = PictureBoxSizeMode.Zoom;
            imgLockLogin.TabIndex = 7;
            imgLockLogin.TabStop = false;
            // 
            // imgUserLogin
            // 
            imgUserLogin.BackColor = Color.Transparent;
            imgUserLogin.Image = Properties.Resources.user;
            imgUserLogin.Location = new Point(58, 174);
            imgUserLogin.Name = "imgUserLogin";
            imgUserLogin.Size = new Size(21, 19);
            imgUserLogin.SizeMode = PictureBoxSizeMode.Zoom;
            imgUserLogin.TabIndex = 6;
            imgUserLogin.TabStop = false;
            // 
            // pnlLinhaSenhaLogin
            // 
            pnlLinhaSenhaLogin.BackColor = Color.SpringGreen;
            pnlLinhaSenhaLogin.Location = new Point(50, 240);
            pnlLinhaSenhaLogin.Name = "pnlLinhaSenhaLogin";
            pnlLinhaSenhaLogin.Size = new Size(200, 2);
            pnlLinhaSenhaLogin.TabIndex = 5;
            // 
            // pnlLinhaUsuarioLogin
            // 
            pnlLinhaUsuarioLogin.BackColor = Color.SpringGreen;
            pnlLinhaUsuarioLogin.Location = new Point(51, 196);
            pnlLinhaUsuarioLogin.Name = "pnlLinhaUsuarioLogin";
            pnlLinhaUsuarioLogin.Size = new Size(200, 2);
            pnlLinhaUsuarioLogin.TabIndex = 4;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.BackColor = Color.FromArgb(10, 25, 10);
            txtSenhaLogin.BorderStyle = BorderStyle.None;
            txtSenhaLogin.ForeColor = Color.White;
            txtSenhaLogin.Location = new Point(84, 219);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.Size = new Size(157, 16);
            txtSenhaLogin.TabIndex = 3;
            txtSenhaLogin.Enter += txtSenhaLogin_Enter;
            txtSenhaLogin.Leave += txtSenhaLogin_Leave;
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.BackColor = Color.FromArgb(10, 25, 10);
            txtUsuarioLogin.BorderStyle = BorderStyle.None;
            txtUsuarioLogin.ForeColor = Color.White;
            txtUsuarioLogin.Location = new Point(84, 177);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(157, 16);
            txtUsuarioLogin.TabIndex = 2;
            txtUsuarioLogin.Enter += txtUsuarioLogin_Enter;
            txtUsuarioLogin.Leave += txtUsuarioLogin_Leave;
            // 
            // lbSloganLogin
            // 
            lbSloganLogin.AutoSize = true;
            lbSloganLogin.BackColor = Color.Transparent;
            lbSloganLogin.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSloganLogin.ForeColor = Color.Gainsboro;
            lbSloganLogin.Location = new Point(65, 138);
            lbSloganLogin.Name = "lbSloganLogin";
            lbSloganLogin.Size = new Size(176, 17);
            lbSloganLogin.TabIndex = 1;
            lbSloganLogin.Text = "Conectando Pessoas e Lugares";
            lbSloganLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imgLogoLogin
            // 
            imgLogoLogin.BackColor = Color.Transparent;
            imgLogoLogin.Image = (Image)resources.GetObject("imgLogoLogin.Image");
            imgLogoLogin.Location = new Point(104, 22);
            imgLogoLogin.Name = "imgLogoLogin";
            imgLogoLogin.Size = new Size(94, 93);
            imgLogoLogin.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogoLogin.TabIndex = 0;
            imgLogoLogin.TabStop = false;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(850, 550);
            Controls.Add(pnlLogin);
            Controls.Add(lbFecharLogin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += TelaLogin_Load;
            MouseDown += TelaLogin_MouseDown;
            Resize += TelaLogin_Resize;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgOnibusLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgNavioLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgAviaoLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLockLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgUserLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogoLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbFecharLogin;
        private Panel pnlLogin;
        private PictureBox imgLogoLogin;
        private TextBox txtSenhaLogin;
        private TextBox txtUsuarioLogin;
        private Label lbSloganLogin;
        private Panel pnlLinhaUsuarioLogin;
        private Panel pnlLinhaSenhaLogin;
        private PictureBox imgLockLogin;
        private PictureBox imgUserLogin;
        private BotaoMandecas btnEntrarLogin;
        private PictureBox imgOnibusLogin;
        private PictureBox imgNavioLogin;
        private PictureBox imgAviaoLogin;
        private Panel pnlSeparador;
        private Label lbRodape;
    }
}
