namespace Login.UseControls
{
    partial class UC_GestaoClientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtBuscaGCliente = new TextBox();
            btnBuscarGClientes = new BotaoPadraoMandecas();
            dgvClientes = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colCPF = new DataGridViewTextBoxColumn();
            colContato = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            pnlCadastroCliente = new Panel();
            botaoPadraoMandecas1 = new BotaoPadraoMandecas();
            btnCancelarGClientes = new BotaoPadraoMandecas();
            lbGratuidade = new Label();
            panel1 = new Panel();
            txtTelefone = new TextBox();
            lbTelefone = new Label();
            txtEmail = new TextBox();
            txtDtNascimento = new TextBox();
            lbEmail = new Label();
            lbDtNascimento = new Label();
            txtCPFGClientes = new TextBox();
            txtNomeGClientes = new TextBox();
            lbCPFGClientes = new Label();
            lbNomeGClientes = new Label();
            pnlTitulo = new Panel();
            lbCadastrarCliente = new Label();
            pnlSeparador = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            pnlCadastroCliente.SuspendLayout();
            pnlTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscaGCliente
            // 
            txtBuscaGCliente.Location = new Point(46, 36);
            txtBuscaGCliente.Name = "txtBuscaGCliente";
            txtBuscaGCliente.Size = new Size(415, 23);
            txtBuscaGCliente.TabIndex = 0;
            // 
            // btnBuscarGClientes
            // 
            btnBuscarGClientes.BackColor = Color.FromArgb(68, 252, 124);
            btnBuscarGClientes.FlatAppearance.BorderSize = 0;
            btnBuscarGClientes.FlatStyle = FlatStyle.Flat;
            btnBuscarGClientes.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarGClientes.ForeColor = Color.Black;
            btnBuscarGClientes.Location = new Point(471, 34);
            btnBuscarGClientes.Name = "btnBuscarGClientes";
            btnBuscarGClientes.Size = new Size(75, 27);
            btnBuscarGClientes.TabIndex = 1;
            btnBuscarGClientes.Text = "Buscar";
            btnBuscarGClientes.UseVisualStyleBackColor = false;
            // 
            // dgvClientes
            // 
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(232, 232, 232);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(68, 252, 124);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colNome, colCPF, colContato, colEmail });
            dgvClientes.Enabled = false;
            dgvClientes.Location = new Point(47, 83);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.Size = new Size(724, 145);
            dgvClientes.TabIndex = 2;
            // 
            // colCodigo
            // 
            colCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCodigo.HeaderText = "Código";
            colCodigo.Name = "colCodigo";
            // 
            // colNome
            // 
            colNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            // 
            // colCPF
            // 
            colCPF.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCPF.HeaderText = "CPF";
            colCPF.Name = "colCPF";
            // 
            // colContato
            // 
            colContato.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colContato.HeaderText = "Contato";
            colContato.Name = "colContato";
            // 
            // colEmail
            // 
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            // 
            // pnlCadastroCliente
            // 
            pnlCadastroCliente.BackColor = Color.White;
            pnlCadastroCliente.BorderStyle = BorderStyle.FixedSingle;
            pnlCadastroCliente.Controls.Add(botaoPadraoMandecas1);
            pnlCadastroCliente.Controls.Add(btnCancelarGClientes);
            pnlCadastroCliente.Controls.Add(lbGratuidade);
            pnlCadastroCliente.Controls.Add(panel1);
            pnlCadastroCliente.Controls.Add(txtTelefone);
            pnlCadastroCliente.Controls.Add(lbTelefone);
            pnlCadastroCliente.Controls.Add(txtEmail);
            pnlCadastroCliente.Controls.Add(txtDtNascimento);
            pnlCadastroCliente.Controls.Add(lbEmail);
            pnlCadastroCliente.Controls.Add(lbDtNascimento);
            pnlCadastroCliente.Controls.Add(txtCPFGClientes);
            pnlCadastroCliente.Controls.Add(txtNomeGClientes);
            pnlCadastroCliente.Controls.Add(lbCPFGClientes);
            pnlCadastroCliente.Controls.Add(lbNomeGClientes);
            pnlCadastroCliente.Controls.Add(pnlTitulo);
            pnlCadastroCliente.Location = new Point(47, 245);
            pnlCadastroCliente.Name = "pnlCadastroCliente";
            pnlCadastroCliente.Size = new Size(724, 199);
            pnlCadastroCliente.TabIndex = 3;
            // 
            // botaoPadraoMandecas1
            // 
            botaoPadraoMandecas1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            botaoPadraoMandecas1.BackColor = Color.FromArgb(68, 252, 124);
            botaoPadraoMandecas1.FlatAppearance.BorderSize = 0;
            botaoPadraoMandecas1.FlatStyle = FlatStyle.Flat;
            botaoPadraoMandecas1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botaoPadraoMandecas1.ForeColor = Color.Black;
            botaoPadraoMandecas1.Location = new Point(381, 158);
            botaoPadraoMandecas1.Name = "botaoPadraoMandecas1";
            botaoPadraoMandecas1.Size = new Size(82, 26);
            botaoPadraoMandecas1.TabIndex = 14;
            botaoPadraoMandecas1.Text = "Salvar";
            botaoPadraoMandecas1.UseVisualStyleBackColor = false;
            // 
            // btnCancelarGClientes
            // 
            btnCancelarGClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelarGClientes.BackColor = Color.FromArgb(194, 194, 194);
            btnCancelarGClientes.FlatAppearance.BorderSize = 0;
            btnCancelarGClientes.FlatStyle = FlatStyle.Flat;
            btnCancelarGClientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarGClientes.ForeColor = Color.Black;
            btnCancelarGClientes.Location = new Point(288, 158);
            btnCancelarGClientes.Name = "btnCancelarGClientes";
            btnCancelarGClientes.Size = new Size(82, 26);
            btnCancelarGClientes.TabIndex = 13;
            btnCancelarGClientes.Text = "Cancelar";
            btnCancelarGClientes.UseVisualStyleBackColor = false;
            // 
            // lbGratuidade
            // 
            lbGratuidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbGratuidade.AutoSize = true;
            lbGratuidade.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbGratuidade.Location = new Point(25, 153);
            lbGratuidade.Name = "lbGratuidade";
            lbGratuidade.Size = new Size(181, 13);
            lbGratuidade.TabIndex = 12;
            lbGratuidade.Text = "*Gratuidade para menores de 5 anos";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(232, 232, 232);
            panel1.Location = new Point(0, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 1);
            panel1.TabIndex = 11;
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefone.Location = new Point(360, 108);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(110, 23);
            txtTelefone.TabIndex = 10;
            // 
            // lbTelefone
            // 
            lbTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new Point(300, 113);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(54, 15);
            lbTelefone.TabIndex = 9;
            lbTelefone.Text = "Telefone:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(524, 108);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtDtNascimento
            // 
            txtDtNascimento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDtNascimento.Location = new Point(146, 108);
            txtDtNascimento.Name = "txtDtNascimento";
            txtDtNascimento.Size = new Size(138, 23);
            txtDtNascimento.TabIndex = 7;
            // 
            // lbEmail
            // 
            lbEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(486, 112);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(39, 15);
            lbEmail.TabIndex = 6;
            lbEmail.Text = "Email:";
            // 
            // lbDtNascimento
            // 
            lbDtNascimento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbDtNascimento.AutoSize = true;
            lbDtNascimento.Location = new Point(25, 113);
            lbDtNascimento.Name = "lbDtNascimento";
            lbDtNascimento.Size = new Size(117, 15);
            lbDtNascimento.TabIndex = 5;
            lbDtNascimento.Text = "Data de Nascimento:";
            // 
            // txtCPFGClientes
            // 
            txtCPFGClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCPFGClientes.Location = new Point(524, 64);
            txtCPFGClientes.Name = "txtCPFGClientes";
            txtCPFGClientes.Size = new Size(176, 23);
            txtCPFGClientes.TabIndex = 4;
            // 
            // txtNomeGClientes
            // 
            txtNomeGClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeGClientes.Location = new Point(123, 64);
            txtNomeGClientes.Name = "txtNomeGClientes";
            txtNomeGClientes.Size = new Size(348, 23);
            txtNomeGClientes.TabIndex = 3;
            // 
            // lbCPFGClientes
            // 
            lbCPFGClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCPFGClientes.AutoSize = true;
            lbCPFGClientes.Location = new Point(489, 68);
            lbCPFGClientes.Name = "lbCPFGClientes";
            lbCPFGClientes.Size = new Size(31, 15);
            lbCPFGClientes.TabIndex = 2;
            lbCPFGClientes.Text = "CPF:";
            // 
            // lbNomeGClientes
            // 
            lbNomeGClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbNomeGClientes.AutoSize = true;
            lbNomeGClientes.Location = new Point(23, 69);
            lbNomeGClientes.Name = "lbNomeGClientes";
            lbNomeGClientes.Size = new Size(99, 15);
            lbNomeGClientes.TabIndex = 1;
            lbNomeGClientes.Text = "Nome Completo:";
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(232, 232, 232);
            pnlTitulo.Controls.Add(lbCadastrarCliente);
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(722, 53);
            pnlTitulo.TabIndex = 0;
            // 
            // lbCadastrarCliente
            // 
            lbCadastrarCliente.AutoSize = true;
            lbCadastrarCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCadastrarCliente.Location = new Point(18, 19);
            lbCadastrarCliente.Name = "lbCadastrarCliente";
            lbCadastrarCliente.Size = new Size(113, 17);
            lbCadastrarCliente.TabIndex = 0;
            lbCadastrarCliente.Text = "Cadastrar Cliente";
            // 
            // pnlSeparador
            // 
            pnlSeparador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSeparador.BackColor = Color.FromArgb(232, 232, 232);
            pnlSeparador.Location = new Point(46, 342);
            pnlSeparador.Name = "pnlSeparador";
            pnlSeparador.Size = new Size(724, 1);
            pnlSeparador.TabIndex = 5;
            // 
            // UC_GestaoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlSeparador);
            Controls.Add(pnlCadastroCliente);
            Controls.Add(dgvClientes);
            Controls.Add(btnBuscarGClientes);
            Controls.Add(txtBuscaGCliente);
            Name = "UC_GestaoClientes";
            Padding = new Padding(20);
            Size = new Size(826, 506);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            pnlCadastroCliente.ResumeLayout(false);
            pnlCadastroCliente.PerformLayout();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscaGCliente;
        private BotaoPadraoMandecas btnBuscarGClientes;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colCPF;
        private DataGridViewTextBoxColumn colContato;
        private DataGridViewTextBoxColumn colEmail;
        private Panel pnlCadastroCliente;
        private Panel pnlTitulo;
        private TextBox txtCPFGClientes;
        private TextBox txtNomeGClientes;
        private Label lbCPFGClientes;
        private Label lbNomeGClientes;
        private Label lbCadastrarCliente;
        private Panel pnlSeparador;
        private TextBox txtEmail;
        private TextBox txtDtNascimento;
        private Label lbEmail;
        private Label lbDtNascimento;
        private Panel panel1;
        private TextBox txtTelefone;
        private Label lbTelefone;
        private BotaoPadraoMandecas btnCancelarGClientes;
        private Label lbGratuidade;
        private BotaoPadraoMandecas botaoPadraoMandecas1;
    }
}
