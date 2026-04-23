namespace Login.UseControls
{
    partial class UC_EditarAcesso
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTitulo = new Panel();
            pnlCadastro = new Panel();
            lbNome = new Label();
            textBox1 = new TextBox();
            lbCPF = new Label();
            lbEmail = new Label();
            lbPerfilAcesso = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lbDadosAcesso = new Label();
            lbCodigo = new Label();
            botaoMandecas1 = new BotaoMandecas();
            botaoPadraoMandecas1 = new BotaoPadraoMandecas();
            pnlEditarCadastro = new Panel();
            comboBox1 = new ComboBox();
            pnlCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(232, 232, 232);
            pnlTitulo.Font = new Font("Segoe UI", 9F);
            pnlTitulo.Location = new Point(17, 78);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(811, 2);
            pnlTitulo.TabIndex = 0;
            // 
            // pnlCadastro
            // 
            pnlCadastro.BackColor = Color.White;
            pnlCadastro.Controls.Add(comboBox1);
            pnlCadastro.Controls.Add(pnlEditarCadastro);
            pnlCadastro.Controls.Add(botaoMandecas1);
            pnlCadastro.Controls.Add(botaoPadraoMandecas1);
            pnlCadastro.Controls.Add(textBox3);
            pnlCadastro.Controls.Add(textBox2);
            pnlCadastro.Controls.Add(lbPerfilAcesso);
            pnlCadastro.Controls.Add(lbEmail);
            pnlCadastro.Controls.Add(lbCPF);
            pnlCadastro.Controls.Add(textBox1);
            pnlCadastro.Controls.Add(lbNome);
            pnlCadastro.Font = new Font("Segoe UI", 9F);
            pnlCadastro.Location = new Point(82, 122);
            pnlCadastro.Name = "pnlCadastro";
            pnlCadastro.Size = new Size(746, 278);
            pnlCadastro.TabIndex = 1;

            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(43, 36);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(43, 15);
            lbNome.TabIndex = 2;
            lbNome.Text = "Nome:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(228, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(467, 23);
            textBox1.TabIndex = 3;
            // 
            // lbCPF
            // 
            lbCPF.AutoSize = true;
            lbCPF.Location = new Point(43, 79);
            lbCPF.Name = "lbCPF";
            lbCPF.Size = new Size(31, 15);
            lbCPF.TabIndex = 4;
            lbCPF.Text = "CPF:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(43, 117);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(39, 15);
            lbEmail.TabIndex = 5;
            lbEmail.Text = "Email:";
            // 
            // lbPerfilAcesso
            // 
            lbPerfilAcesso.AutoSize = true;
            lbPerfilAcesso.Location = new Point(43, 163);
            lbPerfilAcesso.Name = "lbPerfilAcesso";
            lbPerfilAcesso.Size = new Size(93, 15);
            lbPerfilAcesso.TabIndex = 6;
            lbPerfilAcesso.Text = "Perfil de Acesso:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(228, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(467, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(228, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(467, 23);
            textBox3.TabIndex = 8;
            // 
            // lbDadosAcesso
            // 
            lbDadosAcesso.AutoSize = true;
            lbDadosAcesso.Font = new Font("Segoe UI", 19F);
            lbDadosAcesso.Location = new Point(10, 39);
            lbDadosAcesso.Name = "lbDadosAcesso";
            lbDadosAcesso.Size = new Size(282, 36);
            lbDadosAcesso.TabIndex = 10;
            lbDadosAcesso.Text = "Editar Dados de Acesso";
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Location = new Point(17, 83);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(70, 15);
            lbCodigo.TabIndex = 11;
            lbCodigo.Text = "Codigo: 002";
            // 
            // botaoMandecas1
            // 
            botaoMandecas1.BackColor = Color.FromArgb(68, 252, 124);
            botaoMandecas1.FlatAppearance.BorderSize = 0;
            botaoMandecas1.FlatStyle = FlatStyle.Flat;
            botaoMandecas1.Font = new Font("Segoe UI Semibold", 11F);
            botaoMandecas1.ForeColor = Color.Black;
            botaoMandecas1.Location = new Point(434, 228);
            botaoMandecas1.Name = "botaoMandecas1";
            botaoMandecas1.Size = new Size(144, 36);
            botaoMandecas1.TabIndex = 12;
            botaoMandecas1.Text = "Salvar Alterações";
            botaoMandecas1.UseVisualStyleBackColor = false;
            // 
            // botaoPadraoMandecas1
            // 
            botaoPadraoMandecas1.BackColor = Color.FromArgb(194, 194, 194);
            botaoPadraoMandecas1.FlatAppearance.BorderSize = 0;
            botaoPadraoMandecas1.FlatStyle = FlatStyle.Flat;
            botaoPadraoMandecas1.Font = new Font("Segoe UI Semibold", 11F);
            botaoPadraoMandecas1.ForeColor = Color.Black;
            botaoPadraoMandecas1.Location = new Point(266, 228);
            botaoPadraoMandecas1.Name = "botaoPadraoMandecas1";
            botaoPadraoMandecas1.Size = new Size(94, 36);
            botaoPadraoMandecas1.TabIndex = 13;
            botaoPadraoMandecas1.Text = "Cancelar";
            botaoPadraoMandecas1.UseVisualStyleBackColor = false;
            // 
            // pnlEditarCadastro
            // 
            pnlEditarCadastro.BackColor = Color.FromArgb(232, 232, 232);
            pnlEditarCadastro.Font = new Font("Segoe UI", 9F);
            pnlEditarCadastro.Location = new Point(0, 208);
            pnlEditarCadastro.Name = "pnlEditarCadastro";
            pnlEditarCadastro.Size = new Size(746, 2);
            pnlEditarCadastro.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(228, 155);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(467, 23);
            comboBox1.TabIndex = 12;
            // 
            // UC_EditarAcesso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbCodigo);
            Controls.Add(lbDadosAcesso);
            Controls.Add(pnlCadastro);
            Controls.Add(pnlTitulo);
            Name = "UC_EditarAcesso";
            Size = new Size(922, 458);
            Load += UC_EditarAcesso_Load;
            pnlCadastro.ResumeLayout(false);
            pnlCadastro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitulo;
        private Panel pnlCadastro;
        private Label lbNome;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label lbPerfilAcesso;
        private Label lbEmail;
        private Label lbCPF;
        private Label lbDadosAcesso;
        private Label lbCodigo;
        private BotaoMandecas botaoMandecas1;
        private BotaoPadraoMandecas botaoPadraoMandecas1;
        private Panel pnlEditarCadastro;
        private ComboBox comboBox1;
    }
}
