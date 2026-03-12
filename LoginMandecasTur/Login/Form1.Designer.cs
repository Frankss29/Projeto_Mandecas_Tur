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
            txtLoginLogin = new TextBox();
            txtSenhaLogin = new TextBox();
            btnLoginLogin = new Button();
            lbLoginLogin = new Label();
            lbSenhaLogin = new Label();
            logoLogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logoLogin).BeginInit();
            SuspendLayout();
            // 
            // txtLoginLogin
            // 
            txtLoginLogin.Location = new Point(121, 243);
            txtLoginLogin.Name = "txtLoginLogin";
            txtLoginLogin.Size = new Size(151, 23);
            txtLoginLogin.TabIndex = 0;
            txtLoginLogin.TextChanged += textBox1_TextChanged;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.Location = new Point(121, 306);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.Size = new Size(151, 23);
            txtSenhaLogin.TabIndex = 1;
            // 
            // btnLoginLogin
            // 
            btnLoginLogin.BackColor = Color.FromArgb(14, 46, 19);
            btnLoginLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginLogin.ForeColor = SystemColors.ControlLightLight;
            btnLoginLogin.Location = new Point(146, 354);
            btnLoginLogin.Name = "btnLoginLogin";
            btnLoginLogin.Size = new Size(98, 36);
            btnLoginLogin.TabIndex = 2;
            btnLoginLogin.Text = "Login";
            btnLoginLogin.UseVisualStyleBackColor = false;
            btnLoginLogin.MouseEnter += btnLoginLogin_MouseEnter;
            btnLoginLogin.MouseLeave += btnLoginLogin_MouseLeave;
            // 
            // lbLoginLogin
            // 
            lbLoginLogin.AutoSize = true;
            lbLoginLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLoginLogin.ForeColor = SystemColors.ControlLightLight;
            lbLoginLogin.Location = new Point(121, 220);
            lbLoginLogin.Name = "lbLoginLogin";
            lbLoginLogin.Size = new Size(47, 17);
            lbLoginLogin.TabIndex = 3;
            lbLoginLogin.Text = "Login:";
            // 
            // lbSenhaLogin
            // 
            lbSenhaLogin.AutoSize = true;
            lbSenhaLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSenhaLogin.ForeColor = SystemColors.ControlLightLight;
            lbSenhaLogin.Location = new Point(121, 283);
            lbSenhaLogin.Name = "lbSenhaLogin";
            lbSenhaLogin.Size = new Size(49, 17);
            lbSenhaLogin.TabIndex = 4;
            lbSenhaLogin.Text = "Senha:";
            // 
            // logoLogin
            // 
            logoLogin.Image = (Image)resources.GetObject("logoLogin.Image");
            logoLogin.Location = new Point(130, 52);
            logoLogin.Name = "logoLogin";
            logoLogin.Size = new Size(140, 142);
            logoLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            logoLogin.TabIndex = 5;
            logoLogin.TabStop = false;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 46, 19);
            ClientSize = new Size(392, 459);
            Controls.Add(logoLogin);
            Controls.Add(lbSenhaLogin);
            Controls.Add(lbLoginLogin);
            Controls.Add(btnLoginLogin);
            Controls.Add(txtSenhaLogin);
            Controls.Add(txtLoginLogin);
            Name = "TelaLogin";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logoLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLoginLogin;
        private TextBox txtSenhaLogin;
        private Button btnLoginLogin;
        private Label lbLoginLogin;
        private Label lbSenhaLogin;
        private PictureBox logoLogin;
    }
}
