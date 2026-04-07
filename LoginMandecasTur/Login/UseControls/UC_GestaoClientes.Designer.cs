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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_GestaoClientes));
            txtBuscaGCliente = new TextBox();
            btnBuscarGClientes = new BotaoPadraoMandecas();
            pnlCadastroCliente = new Panel();
            pnlTitulo = new Panel();
            lbCadastrarCliente = new Label();
            pnlSeparador = new Panel();
            pnlBotoes = new Panel();
            btnCancelarGClientes = new BotaoPadraoMandecas();
            botaoPadraoMandecas1 = new BotaoPadraoMandecas();
            lbGratuidade = new Label();
            pnlSeparador2 = new Panel();
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
            dvgClientes = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colCPF = new DataGridViewTextBoxColumn();
            colContato = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            btnEditar = new DataGridViewImageColumn();
            btnExcluir = new DataGridViewImageColumn();
            pnlCadastroCliente.SuspendLayout();
            pnlTitulo.SuspendLayout();
            pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgClientes).BeginInit();
            SuspendLayout();
            // 
            // txtBuscaGCliente
            // 
            txtBuscaGCliente.Location = new Point(46, 36);
            txtBuscaGCliente.Name = "txtBuscaGCliente";
            txtBuscaGCliente.PlaceholderText = "  Buscar por Nome, CPF";
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
            btnBuscarGClientes.Click += btnBuscarGClientes_Click;
            // 
            // pnlCadastroCliente
            // 
            pnlCadastroCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCadastroCliente.BackColor = Color.White;
            pnlCadastroCliente.BorderStyle = BorderStyle.FixedSingle;
            pnlCadastroCliente.Controls.Add(pnlTitulo);
            pnlCadastroCliente.Controls.Add(pnlSeparador);
            pnlCadastroCliente.Controls.Add(pnlBotoes);
            pnlCadastroCliente.Controls.Add(lbGratuidade);
            pnlCadastroCliente.Controls.Add(pnlSeparador2);
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
            pnlCadastroCliente.Location = new Point(47, 263);
            pnlCadastroCliente.Name = "pnlCadastroCliente";
            pnlCadastroCliente.Size = new Size(724, 199);
            pnlCadastroCliente.TabIndex = 3;
            pnlCadastroCliente.Paint += pnlCadastroCliente_Paint;
            // 
            // pnlTitulo
            // 
            pnlTitulo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlTitulo.BackColor = Color.FromArgb(232, 232, 232);
            pnlTitulo.Controls.Add(lbCadastrarCliente);
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(722, 53);
            pnlTitulo.TabIndex = 0;
            // 
            // lbCadastrarCliente
            // 
            lbCadastrarCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            pnlSeparador.Location = new Point(3, 96);
            pnlSeparador.Name = "pnlSeparador";
            pnlSeparador.Size = new Size(724, 1);
            pnlSeparador.TabIndex = 5;
            // 
            // pnlBotoes
            // 
            pnlBotoes.Controls.Add(btnCancelarGClientes);
            pnlBotoes.Controls.Add(botaoPadraoMandecas1);
            pnlBotoes.Location = new Point(279, 147);
            pnlBotoes.Name = "pnlBotoes";
            pnlBotoes.Size = new Size(200, 47);
            pnlBotoes.TabIndex = 15;
            // 
            // btnCancelarGClientes
            // 
            btnCancelarGClientes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelarGClientes.BackColor = Color.FromArgb(194, 194, 194);
            btnCancelarGClientes.FlatAppearance.BorderSize = 0;
            btnCancelarGClientes.FlatStyle = FlatStyle.Flat;
            btnCancelarGClientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarGClientes.ForeColor = Color.Black;
            btnCancelarGClientes.Location = new Point(13, 11);
            btnCancelarGClientes.Name = "btnCancelarGClientes";
            btnCancelarGClientes.Size = new Size(82, 26);
            btnCancelarGClientes.TabIndex = 13;
            btnCancelarGClientes.Text = "Cancelar";
            btnCancelarGClientes.UseVisualStyleBackColor = false;
            // 
            // botaoPadraoMandecas1
            // 
            botaoPadraoMandecas1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            botaoPadraoMandecas1.BackColor = Color.FromArgb(68, 252, 124);
            botaoPadraoMandecas1.FlatAppearance.BorderSize = 0;
            botaoPadraoMandecas1.FlatStyle = FlatStyle.Flat;
            botaoPadraoMandecas1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botaoPadraoMandecas1.ForeColor = Color.Black;
            botaoPadraoMandecas1.Location = new Point(104, 11);
            botaoPadraoMandecas1.Name = "botaoPadraoMandecas1";
            botaoPadraoMandecas1.Size = new Size(82, 26);
            botaoPadraoMandecas1.TabIndex = 14;
            botaoPadraoMandecas1.Text = "Salvar";
            botaoPadraoMandecas1.UseVisualStyleBackColor = false;
            // 
            // lbGratuidade
            // 
            lbGratuidade.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbGratuidade.AutoSize = true;
            lbGratuidade.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbGratuidade.Location = new Point(25, 153);
            lbGratuidade.Name = "lbGratuidade";
            lbGratuidade.Size = new Size(181, 13);
            lbGratuidade.TabIndex = 12;
            lbGratuidade.Text = "*Gratuidade para menores de 5 anos";
            // 
            // pnlSeparador2
            // 
            pnlSeparador2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSeparador2.BackColor = Color.FromArgb(232, 232, 232);
            pnlSeparador2.Location = new Point(0, 140);
            pnlSeparador2.Name = "pnlSeparador2";
            pnlSeparador2.Size = new Size(724, 1);
            pnlSeparador2.TabIndex = 11;
            // 
            // txtTelefone
            // 
            txtTelefone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTelefone.Location = new Point(360, 108);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(110, 23);
            txtTelefone.TabIndex = 10;
            // 
            // lbTelefone
            // 
            lbTelefone.Anchor = AnchorStyles.Left;
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new Point(300, 113);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(55, 15);
            lbTelefone.TabIndex = 9;
            lbTelefone.Text = "Telefone:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(524, 108);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtDtNascimento
            // 
            txtDtNascimento.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDtNascimento.Location = new Point(146, 108);
            txtDtNascimento.Name = "txtDtNascimento";
            txtDtNascimento.Size = new Size(135, 23);
            txtDtNascimento.TabIndex = 7;
            // 
            // lbEmail
            // 
            lbEmail.Anchor = AnchorStyles.Left;
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(486, 112);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(39, 15);
            lbEmail.TabIndex = 6;
            lbEmail.Text = "Email:";
            // 
            // lbDtNascimento
            // 
            lbDtNascimento.Anchor = AnchorStyles.Left;
            lbDtNascimento.AutoSize = true;
            lbDtNascimento.Location = new Point(25, 113);
            lbDtNascimento.Name = "lbDtNascimento";
            lbDtNascimento.Size = new Size(117, 15);
            lbDtNascimento.TabIndex = 5;
            lbDtNascimento.Text = "Data de Nascimento:";
            // 
            // txtCPFGClientes
            // 
            txtCPFGClientes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCPFGClientes.Location = new Point(524, 64);
            txtCPFGClientes.Name = "txtCPFGClientes";
            txtCPFGClientes.Size = new Size(176, 23);
            txtCPFGClientes.TabIndex = 4;
            // 
            // txtNomeGClientes
            // 
            txtNomeGClientes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNomeGClientes.Location = new Point(123, 64);
            txtNomeGClientes.Name = "txtNomeGClientes";
            txtNomeGClientes.Size = new Size(356, 23);
            txtNomeGClientes.TabIndex = 3;
            // 
            // lbCPFGClientes
            // 
            lbCPFGClientes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbCPFGClientes.AutoSize = true;
            lbCPFGClientes.Location = new Point(494, 64);
            lbCPFGClientes.Name = "lbCPFGClientes";
            lbCPFGClientes.Size = new Size(31, 15);
            lbCPFGClientes.TabIndex = 2;
            lbCPFGClientes.Text = "CPF:";
            // 
            // lbNomeGClientes
            // 
            lbNomeGClientes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbNomeGClientes.AutoSize = true;
            lbNomeGClientes.Location = new Point(23, 69);
            lbNomeGClientes.Name = "lbNomeGClientes";
            lbNomeGClientes.Size = new Size(99, 15);
            lbNomeGClientes.TabIndex = 1;
            lbNomeGClientes.Text = "Nome Completo:";
            // 
            // dvgClientes
            // 
            dvgClientes.AllowUserToAddRows = false;
            dvgClientes.BackgroundColor = Color.White;
            dvgClientes.BorderStyle = BorderStyle.None;
            dvgClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dvgClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgClientes.ColumnHeadersHeight = 40;
            dvgClientes.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colNome, colCPF, colContato, colEmail, btnEditar, btnExcluir });
            dvgClientes.EnableHeadersVisualStyles = false;
            dvgClientes.Location = new Point(47, 101);
            dvgClientes.Name = "dvgClientes";
            dvgClientes.RowHeadersVisible = false;
            dvgClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgClientes.Size = new Size(723, 134);
            dvgClientes.TabIndex = 4;
            dvgClientes.CellClick += dvgClientes_CellClick;
            dvgClientes.CellContentClick += dvgClientes_CellContentClick;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.Name = "colCodigo";
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            // 
            // colCPF
            // 
            colCPF.HeaderText = "CPF";
            colCPF.Name = "colCPF";
            // 
            // colContato
            // 
            colContato.HeaderText = "Contato";
            colContato.Name = "colContato";
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            // 
            // btnEditar
            // 
            btnEditar.HeaderText = "";
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnEditar.Name = "btnEditar";
            // 
            // btnExcluir
            // 
            btnExcluir.HeaderText = "";
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnExcluir.Name = "btnExcluir";
            // 
            // UC_GestaoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(dvgClientes);
            Controls.Add(pnlCadastroCliente);
            Controls.Add(btnBuscarGClientes);
            Controls.Add(txtBuscaGCliente);
            Name = "UC_GestaoClientes";
            Padding = new Padding(20);
            Size = new Size(826, 506);
            pnlCadastroCliente.ResumeLayout(false);
            pnlCadastroCliente.PerformLayout();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscaGCliente;
        private BotaoPadraoMandecas btnBuscarGClientes;
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
        private Panel pnlSeparador2;
        private TextBox txtTelefone;
        private Label lbTelefone;
        private BotaoPadraoMandecas btnCancelarGClientes;
        private Label lbGratuidade;
        private BotaoPadraoMandecas botaoPadraoMandecas1;
        private Panel pnlBotoes;
        private DataGridView dvgClientes;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colCPF;
        private DataGridViewTextBoxColumn colContato;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewImageColumn btnEditar;
        private DataGridViewImageColumn btnExcluir;
    }
}
