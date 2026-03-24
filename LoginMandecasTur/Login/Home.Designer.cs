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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pnlUserName = new Panel();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pnlMenu.SuspendLayout();
            pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlUserName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            btnRelatorio.Location = new Point(476, 0);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(147, 53);
            btnRelatorio.TabIndex = 5;
            btnRelatorio.Text = "Relatórios";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // btnFinanceiro
            // 
            btnFinanceiro.Location = new Point(327, 0);
            btnFinanceiro.Name = "btnFinanceiro";
            btnFinanceiro.Size = new Size(147, 53);
            btnFinanceiro.TabIndex = 4;
            btnFinanceiro.Text = "Financeiro";
            btnFinanceiro.UseVisualStyleBackColor = true;
            btnFinanceiro.Click += btnFinanceiro_Click;
            // 
            // btnGestaoViagens
            // 
            btnGestaoViagens.Location = new Point(178, 0);
            btnGestaoViagens.Name = "btnGestaoViagens";
            btnGestaoViagens.Size = new Size(147, 53);
            btnGestaoViagens.TabIndex = 3;
            btnGestaoViagens.Text = "Gestão de Viagens";
            btnGestaoViagens.UseVisualStyleBackColor = true;
            btnGestaoViagens.Click += btnGestaoViagens_Click;
            // 
            // btnGestaoClientes
            // 
            btnGestaoClientes.Location = new Point(30, 0);
            btnGestaoClientes.Name = "btnGestaoClientes";
            btnGestaoClientes.Size = new Size(147, 53);
            btnGestaoClientes.TabIndex = 2;
            btnGestaoClientes.Text = "Gestão de Clientes";
            btnGestaoClientes.UseVisualStyleBackColor = true;
            btnGestaoClientes.Click += btnGestaoClientes_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(0, 132);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(800, 348);
            panelContainer.TabIndex = 4;
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.FromArgb(68, 252, 124);
            pnlNavBar.Controls.Add(pictureBox2);
            pnlNavBar.Controls.Add(pictureBox1);
            pnlNavBar.Controls.Add(pnlUserName);
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(800, 73);
            pnlNavBar.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(77, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pnlUserName
            // 
            pnlUserName.BackColor = Color.White;
            pnlUserName.Controls.Add(label2);
            pnlUserName.Controls.Add(pictureBox3);
            pnlUserName.Controls.Add(label1);
            pnlUserName.Location = new Point(657, 11);
            pnlUserName.Name = "pnlUserName";
            pnlUserName.Size = new Size(136, 51);
            pnlUserName.TabIndex = 0;
            pnlUserName.Paint += pnlUserName_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 28);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(92, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 8);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuário";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(panelContainer);
            Controls.Add(pnlMenu);
            Controls.Add(pnlNavBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
            pnlMenu.ResumeLayout(false);
            pnlNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlUserName.ResumeLayout(false);
            pnlUserName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Button btnGestaoViagens;
        private Button btnGestaoClientes;
        private Panel pnlNavBar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel pnlUserName;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label1;
        private Panel panelContainer;
        private Button btnRelatorio;
        private Button btnFinanceiro;
    }
}