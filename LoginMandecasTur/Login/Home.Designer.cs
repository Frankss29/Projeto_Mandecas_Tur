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
            btnRelatorio = new Button();
            btnFinanceiro = new Button();
            btnGestaoViagens = new Button();
            btnGestaoClientes = new Button();
            panelContainer = new Panel();
            pnlNavBar = new Panel();
            imgNomeLogoHome = new PictureBox();
            imgLogoHome = new PictureBox();
            pnlUserName = new Panel();
            lbUserName = new Label();
            imgIconUserHome = new PictureBox();
            lbUsuario = new Label();
            pnlMenu.SuspendLayout();
            pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgNomeLogoHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogoHome).BeginInit();
            pnlUserName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgIconUserHome).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.White;
            pnlMenu.Controls.Add(btnRelatorio);
            pnlMenu.Controls.Add(btnFinanceiro);
            pnlMenu.Controls.Add(btnGestaoViagens);
            pnlMenu.Controls.Add(btnGestaoClientes);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 73);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(800, 53);
            pnlMenu.TabIndex = 3;
            // 
            // btnRelatorio
            // 
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnRelatorio.Location = new Point(461, 0);
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
            btnFinanceiro.Location = new Point(312, 0);
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
            btnGestaoViagens.Location = new Point(163, 0);
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
            btnGestaoClientes.Location = new Point(12, 0);
            btnGestaoClientes.Name = "btnGestaoClientes";
            btnGestaoClientes.Size = new Size(147, 51);
            btnGestaoClientes.TabIndex = 2;
            btnGestaoClientes.Text = "Gestão de Clientes";
            btnGestaoClientes.UseVisualStyleBackColor = true;
            btnGestaoClientes.Click += btnGestaoClientes_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 126);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(800, 361);
            panelContainer.TabIndex = 4;
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.FromArgb(68, 252, 124);
            pnlNavBar.Controls.Add(imgNomeLogoHome);
            pnlNavBar.Controls.Add(imgLogoHome);
            pnlNavBar.Controls.Add(pnlUserName);
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(800, 73);
            pnlNavBar.TabIndex = 2;
            // 
            // imgNomeLogoHome
            // 
            imgNomeLogoHome.Image = (Image)resources.GetObject("imgNomeLogoHome.Image");
            imgNomeLogoHome.Location = new Point(77, 22);
            imgNomeLogoHome.Name = "imgNomeLogoHome";
            imgNomeLogoHome.Size = new Size(180, 29);
            imgNomeLogoHome.SizeMode = PictureBoxSizeMode.Zoom;
            imgNomeLogoHome.TabIndex = 2;
            imgNomeLogoHome.TabStop = false;
            // 
            // imgLogoHome
            // 
            imgLogoHome.Image = (Image)resources.GetObject("imgLogoHome.Image");
            imgLogoHome.Location = new Point(12, 6);
            imgLogoHome.Name = "imgLogoHome";
            imgLogoHome.Size = new Size(59, 59);
            imgLogoHome.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogoHome.TabIndex = 1;
            imgLogoHome.TabStop = false;
            // 
            // pnlUserName
            // 
            pnlUserName.BackColor = Color.White;
            pnlUserName.Controls.Add(lbUserName);
            pnlUserName.Controls.Add(imgIconUserHome);
            pnlUserName.Controls.Add(lbUsuario);
            pnlUserName.Location = new Point(657, 11);
            pnlUserName.Name = "pnlUserName";
            pnlUserName.Size = new Size(136, 51);
            pnlUserName.TabIndex = 0;
            pnlUserName.Paint += pnlUserName_Paint;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(29, 28);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(38, 15);
            lbUserName.TabIndex = 3;
            lbUserName.Text = "label2";
            // 
            // imgIconUserHome
            // 
            imgIconUserHome.Image = (Image)resources.GetObject("imgIconUserHome.Image");
            imgIconUserHome.Location = new Point(92, 13);
            imgIconUserHome.Name = "imgIconUserHome";
            imgIconUserHome.Size = new Size(27, 27);
            imgIconUserHome.SizeMode = PictureBoxSizeMode.Zoom;
            imgIconUserHome.TabIndex = 3;
            imgIconUserHome.TabStop = false;
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsuario.Location = new Point(13, 8);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(62, 20);
            lbUsuario.TabIndex = 2;
            lbUsuario.Text = "Usuário";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 487);
            Controls.Add(panelContainer);
            Controls.Add(pnlMenu);
            Controls.Add(pnlNavBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            pnlMenu.ResumeLayout(false);
            pnlNavBar.ResumeLayout(false);
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
    }
}