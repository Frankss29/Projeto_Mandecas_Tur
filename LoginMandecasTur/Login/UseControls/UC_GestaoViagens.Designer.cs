namespace Login.UseControls
{
    partial class UC_GestaoViagens
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_GestaoViagens));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnBuscarGViagens = new BotaoPadraoMandecas();
            txtBuscaGViagens = new TextBox();
            dvgViagens = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colCPF = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colSenha = new DataGridViewTextBoxColumn();
            colPermissao = new DataGridViewTextBoxColumn();
            btnEditar = new DataGridViewImageColumn();
            btnIncluir = new DataGridViewImageColumn();
            btnExcluir = new DataGridViewImageColumn();
            pnlCadastrarViagens = new Panel();
            txtValorUnitarioCViagem = new TextBox();
            pnlBotoesCAcesso = new Panel();
            btnCancelarCViagem = new BotaoPadraoMandecas();
            btnSalvarCViagem = new BotaoPadraoMandecas();
            txtCustoHospedagemCViagem = new TextBox();
            lbValorUnitarioCViagem = new Label();
            txtQTDVagaCViagens = new TextBox();
            lbQTDVagaCViagem = new Label();
            DTPDataCViagem = new DateTimePicker();
            pnlTitulo = new Panel();
            lbCadastraViagem = new Label();
            pnlSeparador = new Panel();
            pnlSeparador2 = new Panel();
            txtTransporteCViagens = new TextBox();
            lbTransporteGViagens = new Label();
            txtCustoTransporteCViagem = new TextBox();
            lbCustoTransporteCViagem = new Label();
            lblbCustoHospedagemCViagem = new Label();
            txtDestinoViagens = new TextBox();
            lbDataGViagens = new Label();
            lbDestinoGViagens = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgViagens).BeginInit();
            pnlCadastrarViagens.SuspendLayout();
            pnlBotoesCAcesso.SuspendLayout();
            pnlTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscarGViagens
            // 
            btnBuscarGViagens.BackColor = Color.FromArgb(68, 252, 124);
            btnBuscarGViagens.FlatAppearance.BorderSize = 0;
            btnBuscarGViagens.FlatStyle = FlatStyle.Flat;
            btnBuscarGViagens.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarGViagens.ForeColor = Color.Black;
            btnBuscarGViagens.Location = new Point(469, 48);
            btnBuscarGViagens.Name = "btnBuscarGViagens";
            btnBuscarGViagens.Size = new Size(75, 27);
            btnBuscarGViagens.TabIndex = 5;
            btnBuscarGViagens.Text = "Buscar";
            btnBuscarGViagens.UseVisualStyleBackColor = false;
            // 
            // txtBuscaGViagens
            // 
            txtBuscaGViagens.Location = new Point(44, 50);
            txtBuscaGViagens.Name = "txtBuscaGViagens";
            txtBuscaGViagens.PlaceholderText = "  Buscar por Destino, Código, Status";
            txtBuscaGViagens.Size = new Size(415, 23);
            txtBuscaGViagens.TabIndex = 4;
            // 
            // dvgViagens
            // 
            dvgViagens.AllowUserToAddRows = false;
            dvgViagens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgViagens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgViagens.BackgroundColor = Color.White;
            dvgViagens.BorderStyle = BorderStyle.None;
            dvgViagens.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dvgViagens.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgViagens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgViagens.ColumnHeadersHeight = 40;
            dvgViagens.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colNome, colCPF, colEmail, colSenha, colPermissao, btnEditar, btnIncluir, btnExcluir });
            dvgViagens.EnableHeadersVisualStyles = false;
            dvgViagens.Location = new Point(43, 101);
            dvgViagens.Name = "dvgViagens";
            dvgViagens.RowHeadersVisible = false;
            dvgViagens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgViagens.Size = new Size(723, 134);
            dvgViagens.TabIndex = 6;
            dvgViagens.CellClick += dvgViagens_CellClick;
            dvgViagens.Paint += dvgViagens_Paint;
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
            colNome.HeaderText = "Destino";
            colNome.Name = "colNome";
            // 
            // colCPF
            // 
            colCPF.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCPF.HeaderText = "Data";
            colCPF.Name = "colCPF";
            // 
            // colEmail
            // 
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEmail.HeaderText = "Vagas";
            colEmail.Name = "colEmail";
            // 
            // colSenha
            // 
            colSenha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSenha.HeaderText = "Transporte";
            colSenha.Name = "colSenha";
            // 
            // colPermissao
            // 
            colPermissao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPermissao.HeaderText = "Status";
            colPermissao.Name = "colPermissao";
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            dataGridViewCellStyle2.Padding = new Padding(8);
            btnEditar.DefaultCellStyle = dataGridViewCellStyle2;
            btnEditar.HeaderText = "";
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnEditar.Name = "btnEditar";
            btnEditar.Width = 50;
            // 
            // btnIncluir
            // 
            btnIncluir.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = resources.GetObject("dataGridViewCellStyle3.NullValue");
            dataGridViewCellStyle3.Padding = new Padding(8);
            btnIncluir.DefaultCellStyle = dataGridViewCellStyle3;
            btnIncluir.HeaderText = "";
            btnIncluir.Image = (Image)resources.GetObject("btnIncluir.Image");
            btnIncluir.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnIncluir.Name = "btnIncluir";
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = resources.GetObject("dataGridViewCellStyle4.NullValue");
            dataGridViewCellStyle4.Padding = new Padding(8);
            btnExcluir.DefaultCellStyle = dataGridViewCellStyle4;
            btnExcluir.HeaderText = "";
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Width = 50;
            // 
            // pnlCadastrarViagens
            // 
            pnlCadastrarViagens.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCadastrarViagens.BackColor = Color.White;
            pnlCadastrarViagens.BorderStyle = BorderStyle.FixedSingle;
            pnlCadastrarViagens.Controls.Add(txtValorUnitarioCViagem);
            pnlCadastrarViagens.Controls.Add(pnlBotoesCAcesso);
            pnlCadastrarViagens.Controls.Add(txtCustoHospedagemCViagem);
            pnlCadastrarViagens.Controls.Add(lbValorUnitarioCViagem);
            pnlCadastrarViagens.Controls.Add(txtQTDVagaCViagens);
            pnlCadastrarViagens.Controls.Add(lbQTDVagaCViagem);
            pnlCadastrarViagens.Controls.Add(DTPDataCViagem);
            pnlCadastrarViagens.Controls.Add(pnlTitulo);
            pnlCadastrarViagens.Controls.Add(pnlSeparador);
            pnlCadastrarViagens.Controls.Add(pnlSeparador2);
            pnlCadastrarViagens.Controls.Add(txtTransporteCViagens);
            pnlCadastrarViagens.Controls.Add(lbTransporteGViagens);
            pnlCadastrarViagens.Controls.Add(txtCustoTransporteCViagem);
            pnlCadastrarViagens.Controls.Add(lbCustoTransporteCViagem);
            pnlCadastrarViagens.Controls.Add(lblbCustoHospedagemCViagem);
            pnlCadastrarViagens.Controls.Add(txtDestinoViagens);
            pnlCadastrarViagens.Controls.Add(lbDataGViagens);
            pnlCadastrarViagens.Controls.Add(lbDestinoGViagens);
            pnlCadastrarViagens.Location = new Point(44, 266);
            pnlCadastrarViagens.Name = "pnlCadastrarViagens";
            pnlCadastrarViagens.Size = new Size(724, 199);
            pnlCadastrarViagens.TabIndex = 7;
            // 
            // txtValorUnitarioCViagem
            // 
            txtValorUnitarioCViagem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtValorUnitarioCViagem.Location = new Point(611, 113);
            txtValorUnitarioCViagem.Name = "txtValorUnitarioCViagem";
            txtValorUnitarioCViagem.Size = new Size(93, 23);
            txtValorUnitarioCViagem.TabIndex = 17;
            // 
            // pnlBotoesCAcesso
            // 
            pnlBotoesCAcesso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlBotoesCAcesso.Controls.Add(btnCancelarCViagem);
            pnlBotoesCAcesso.Controls.Add(btnSalvarCViagem);
            pnlBotoesCAcesso.Location = new Point(269, 151);
            pnlBotoesCAcesso.Name = "pnlBotoesCAcesso";
            pnlBotoesCAcesso.Size = new Size(200, 43);
            pnlBotoesCAcesso.TabIndex = 15;
            // 
            // btnCancelarCViagem
            // 
            btnCancelarCViagem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelarCViagem.BackColor = Color.FromArgb(194, 194, 194);
            btnCancelarCViagem.FlatAppearance.BorderSize = 0;
            btnCancelarCViagem.FlatStyle = FlatStyle.Flat;
            btnCancelarCViagem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarCViagem.ForeColor = Color.Black;
            btnCancelarCViagem.Location = new Point(13, 9);
            btnCancelarCViagem.Name = "btnCancelarCViagem";
            btnCancelarCViagem.Size = new Size(82, 26);
            btnCancelarCViagem.TabIndex = 13;
            btnCancelarCViagem.Text = "Cancelar";
            btnCancelarCViagem.UseVisualStyleBackColor = false;
            // 
            // btnSalvarCViagem
            // 
            btnSalvarCViagem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvarCViagem.BackColor = Color.FromArgb(68, 252, 124);
            btnSalvarCViagem.FlatAppearance.BorderSize = 0;
            btnSalvarCViagem.FlatStyle = FlatStyle.Flat;
            btnSalvarCViagem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvarCViagem.ForeColor = Color.Black;
            btnSalvarCViagem.Location = new Point(104, 9);
            btnSalvarCViagem.Name = "btnSalvarCViagem";
            btnSalvarCViagem.Size = new Size(82, 26);
            btnSalvarCViagem.TabIndex = 14;
            btnSalvarCViagem.Text = "Salvar";
            btnSalvarCViagem.UseVisualStyleBackColor = false;
            // 
            // txtCustoHospedagemCViagem
            // 
            txtCustoHospedagemCViagem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCustoHospedagemCViagem.Location = new Point(403, 112);
            txtCustoHospedagemCViagem.Name = "txtCustoHospedagemCViagem";
            txtCustoHospedagemCViagem.Size = new Size(106, 23);
            txtCustoHospedagemCViagem.TabIndex = 16;
            // 
            // lbValorUnitarioCViagem
            // 
            lbValorUnitarioCViagem.Anchor = AnchorStyles.Right;
            lbValorUnitarioCViagem.AutoSize = true;
            lbValorUnitarioCViagem.Location = new Point(524, 116);
            lbValorUnitarioCViagem.Name = "lbValorUnitarioCViagem";
            lbValorUnitarioCViagem.Size = new Size(81, 15);
            lbValorUnitarioCViagem.TabIndex = 15;
            lbValorUnitarioCViagem.Text = "Valor Unitário:";
            // 
            // txtQTDVagaCViagens
            // 
            txtQTDVagaCViagens.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtQTDVagaCViagens.Location = new Point(633, 70);
            txtQTDVagaCViagens.Name = "txtQTDVagaCViagens";
            txtQTDVagaCViagens.Size = new Size(71, 23);
            txtQTDVagaCViagens.TabIndex = 14;
            // 
            // lbQTDVagaCViagem
            // 
            lbQTDVagaCViagem.Anchor = AnchorStyles.Right;
            lbQTDVagaCViagem.AutoSize = true;
            lbQTDVagaCViagem.Location = new Point(550, 73);
            lbQTDVagaCViagem.Name = "lbQTDVagaCViagem";
            lbQTDVagaCViagem.Size = new Size(77, 15);
            lbQTDVagaCViagem.TabIndex = 13;
            lbQTDVagaCViagem.Text = "Qtd. de Vaga:";
            // 
            // DTPDataCViagem
            // 
            DTPDataCViagem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DTPDataCViagem.Format = DateTimePickerFormat.Short;
            DTPDataCViagem.Location = new Point(242, 67);
            DTPDataCViagem.Name = "DTPDataCViagem";
            DTPDataCViagem.Size = new Size(110, 23);
            DTPDataCViagem.TabIndex = 12;
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(232, 232, 232);
            pnlTitulo.Controls.Add(lbCadastraViagem);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(722, 53);
            pnlTitulo.TabIndex = 0;
            // 
            // lbCadastraViagem
            // 
            lbCadastraViagem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCadastraViagem.AutoSize = true;
            lbCadastraViagem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCadastraViagem.Location = new Point(18, 19);
            lbCadastraViagem.Name = "lbCadastraViagem";
            lbCadastraViagem.Size = new Size(117, 17);
            lbCadastraViagem.TabIndex = 0;
            lbCadastraViagem.Text = "Cadastrar Viagem";
            // 
            // pnlSeparador
            // 
            pnlSeparador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSeparador.BackColor = Color.FromArgb(232, 232, 232);
            pnlSeparador.Location = new Point(0, 99);
            pnlSeparador.Name = "pnlSeparador";
            pnlSeparador.Size = new Size(724, 1);
            pnlSeparador.TabIndex = 5;
            // 
            // pnlSeparador2
            // 
            pnlSeparador2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSeparador2.BackColor = Color.FromArgb(232, 232, 232);
            pnlSeparador2.Location = new Point(0, 146);
            pnlSeparador2.Name = "pnlSeparador2";
            pnlSeparador2.Size = new Size(724, 1);
            pnlSeparador2.TabIndex = 11;
            // 
            // txtTransporteCViagens
            // 
            txtTransporteCViagens.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTransporteCViagens.Location = new Point(427, 67);
            txtTransporteCViagens.Name = "txtTransporteCViagens";
            txtTransporteCViagens.Size = new Size(110, 23);
            txtTransporteCViagens.TabIndex = 10;
            // 
            // lbTransporteGViagens
            // 
            lbTransporteGViagens.Anchor = AnchorStyles.Right;
            lbTransporteGViagens.AutoSize = true;
            lbTransporteGViagens.Location = new Point(360, 72);
            lbTransporteGViagens.Name = "lbTransporteGViagens";
            lbTransporteGViagens.Size = new Size(66, 15);
            lbTransporteGViagens.TabIndex = 9;
            lbTransporteGViagens.Text = "Transporte:";
            // 
            // txtCustoTransporteCViagem
            // 
            txtCustoTransporteCViagem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCustoTransporteCViagem.Location = new Point(138, 111);
            txtCustoTransporteCViagem.Name = "txtCustoTransporteCViagem";
            txtCustoTransporteCViagem.Size = new Size(116, 23);
            txtCustoTransporteCViagem.TabIndex = 8;
            // 
            // lbCustoTransporteCViagem
            // 
            lbCustoTransporteCViagem.Anchor = AnchorStyles.Left;
            lbCustoTransporteCViagem.AutoSize = true;
            lbCustoTransporteCViagem.Location = new Point(17, 116);
            lbCustoTransporteCViagem.Name = "lbCustoTransporteCViagem";
            lbCustoTransporteCViagem.Size = new Size(117, 15);
            lbCustoTransporteCViagem.TabIndex = 6;
            lbCustoTransporteCViagem.Text = "Custo do Transporte:";
            // 
            // lblbCustoHospedagemCViagem
            // 
            lblbCustoHospedagemCViagem.Anchor = AnchorStyles.Left;
            lblbCustoHospedagemCViagem.AutoSize = true;
            lblbCustoHospedagemCViagem.Location = new Point(269, 116);
            lblbCustoHospedagemCViagem.Name = "lblbCustoHospedagemCViagem";
            lblbCustoHospedagemCViagem.Size = new Size(131, 15);
            lblbCustoHospedagemCViagem.TabIndex = 5;
            lblbCustoHospedagemCViagem.Text = "Custo da Hospedagem:";
            // 
            // txtDestinoViagens
            // 
            txtDestinoViagens.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDestinoViagens.Location = new Point(70, 67);
            txtDestinoViagens.Name = "txtDestinoViagens";
            txtDestinoViagens.Size = new Size(119, 23);
            txtDestinoViagens.TabIndex = 3;
            // 
            // lbDataGViagens
            // 
            lbDataGViagens.Anchor = AnchorStyles.Left;
            lbDataGViagens.AutoSize = true;
            lbDataGViagens.Location = new Point(202, 72);
            lbDataGViagens.Name = "lbDataGViagens";
            lbDataGViagens.Size = new Size(34, 15);
            lbDataGViagens.TabIndex = 2;
            lbDataGViagens.Text = "Data:";
            // 
            // lbDestinoGViagens
            // 
            lbDestinoGViagens.Anchor = AnchorStyles.Left;
            lbDestinoGViagens.AutoSize = true;
            lbDestinoGViagens.Location = new Point(17, 72);
            lbDestinoGViagens.Name = "lbDestinoGViagens";
            lbDestinoGViagens.Size = new Size(50, 15);
            lbDestinoGViagens.TabIndex = 1;
            lbDestinoGViagens.Text = "Destino:";
            // 
            // UC_GestaoViagens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlCadastrarViagens);
            Controls.Add(dvgViagens);
            Controls.Add(btnBuscarGViagens);
            Controls.Add(txtBuscaGViagens);
            Name = "UC_GestaoViagens";
            Size = new Size(826, 506);
            ((System.ComponentModel.ISupportInitialize)dvgViagens).EndInit();
            pnlCadastrarViagens.ResumeLayout(false);
            pnlCadastrarViagens.PerformLayout();
            pnlBotoesCAcesso.ResumeLayout(false);
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BotaoPadraoMandecas btnBuscarGViagens;
        private TextBox txtBuscaGViagens;
        private DataGridView dvgViagens;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colCPF;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colSenha;
        private DataGridViewTextBoxColumn colPermissao;
        private DataGridViewImageColumn btnEditar;
        private DataGridViewImageColumn btnIncluir;
        private DataGridViewImageColumn btnExcluir;
        private Panel pnlCadastrarViagens;
        private Panel pnlTitulo;
        private Label lbCadastraViagem;
        private Panel pnlSeparador;
        private Panel pnlSeparador2;
        private TextBox txtTransporteCViagens;
        private Label lbTransporteGViagens;
        private TextBox txtCustoTransporteCViagem;
        private Label lbCustoTransporteCViagem;
        private Label lblbCustoHospedagemCViagem;
        private TextBox txtDestinoViagens;
        private Label lbDataGViagens;
        private Label lbDestinoGViagens;
        private Panel pnlBotoesCAcesso;
        private BotaoPadraoMandecas btnCancelarCViagem;
        private BotaoPadraoMandecas btnSalvarCViagem;
        private DateTimePicker DTPDataCViagem;
        private TextBox txtQTDVagaCViagens;
        private Label lbQTDVagaCViagem;
        private TextBox txtValorUnitarioCViagem;
        private TextBox txtCustoHospedagemCViagem;
        private Label lbValorUnitarioCViagem;
    }
}
