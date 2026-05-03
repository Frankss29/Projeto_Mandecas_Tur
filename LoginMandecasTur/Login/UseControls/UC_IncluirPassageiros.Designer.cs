namespace Login.UseControls
{
    partial class UC_IncluirPassageiros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_IncluirPassageiros));
            lbUCIncluirPassageiros = new Label();
            pnlSeparador1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            cbCliente = new ComboBox();
            btnVoltarIncluirPassageiros = new BotaoPadraoMandecas();
            btnSalvarIncluirPassageiros = new BotaoPadraoMandecas();
            panel1 = new Panel();
            txtNumeroDeParcelasIncluirPassageiros = new TextBox();
            txtValorDaEntradaIncluirPassageiros = new TextBox();
            txtFormaDePagamentoIncluirPassageiros = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            lbIDViagemIncluirPassageiros = new Label();
            dgvListaDePassageiros = new DataGridView();
            btnExcluir = new DataGridViewImageColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaDePassageiros).BeginInit();
            SuspendLayout();
            // 
            // lbUCIncluirPassageiros
            // 
            lbUCIncluirPassageiros.AutoSize = true;
            lbUCIncluirPassageiros.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUCIncluirPassageiros.Location = new Point(16, 59);
            lbUCIncluirPassageiros.Name = "lbUCIncluirPassageiros";
            lbUCIncluirPassageiros.Size = new Size(207, 32);
            lbUCIncluirPassageiros.TabIndex = 0;
            lbUCIncluirPassageiros.Text = "Incluir Passageiros";
            // 
            // pnlSeparador1
            // 
            pnlSeparador1.BackColor = Color.FromArgb(232, 232, 232);
            pnlSeparador1.Location = new Point(16, 94);
            pnlSeparador1.Name = "pnlSeparador1";
            pnlSeparador1.Size = new Size(793, 2);
            pnlSeparador1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(646, 97);
            label2.Name = "label2";
            label2.Size = new Size(106, 17);
            label2.TabIndex = 2;
            label2.Text = "Vagas Restantes:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(cbCliente);
            panel2.Controls.Add(btnVoltarIncluirPassageiros);
            panel2.Controls.Add(btnSalvarIncluirPassageiros);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(txtNumeroDeParcelasIncluirPassageiros);
            panel2.Controls.Add(txtValorDaEntradaIncluirPassageiros);
            panel2.Controls.Add(txtFormaDePagamentoIncluirPassageiros);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(25, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 219);
            panel2.TabIndex = 3;
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(194, 15);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(565, 23);
            cbCliente.TabIndex = 11;
            // 
            // btnVoltarIncluirPassageiros
            // 
            btnVoltarIncluirPassageiros.BackColor = Color.FromArgb(194, 194, 194);
            btnVoltarIncluirPassageiros.FlatAppearance.BorderSize = 0;
            btnVoltarIncluirPassageiros.FlatStyle = FlatStyle.Flat;
            btnVoltarIncluirPassageiros.Font = new Font("Segoe UI Semibold", 11F);
            btnVoltarIncluirPassageiros.ForeColor = Color.Black;
            btnVoltarIncluirPassageiros.Location = new Point(294, 178);
            btnVoltarIncluirPassageiros.Name = "btnVoltarIncluirPassageiros";
            btnVoltarIncluirPassageiros.Size = new Size(103, 28);
            btnVoltarIncluirPassageiros.TabIndex = 10;
            btnVoltarIncluirPassageiros.Text = "Voltar";
            btnVoltarIncluirPassageiros.UseVisualStyleBackColor = false;
            btnVoltarIncluirPassageiros.Click += btnVoltarIncluirPassageiros_Click;
            // 
            // btnSalvarIncluirPassageiros
            // 
            btnSalvarIncluirPassageiros.BackColor = Color.FromArgb(68, 252, 124);
            btnSalvarIncluirPassageiros.FlatAppearance.BorderSize = 0;
            btnSalvarIncluirPassageiros.FlatStyle = FlatStyle.Flat;
            btnSalvarIncluirPassageiros.Font = new Font("Segoe UI Semibold", 11F);
            btnSalvarIncluirPassageiros.ForeColor = Color.Black;
            btnSalvarIncluirPassageiros.Location = new Point(403, 178);
            btnSalvarIncluirPassageiros.Name = "btnSalvarIncluirPassageiros";
            btnSalvarIncluirPassageiros.Size = new Size(103, 28);
            btnSalvarIncluirPassageiros.TabIndex = 9;
            btnSalvarIncluirPassageiros.Text = "Salvar";
            btnSalvarIncluirPassageiros.UseVisualStyleBackColor = false;
            btnSalvarIncluirPassageiros.Click += btnSalvarIncluirPassageiros_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(232, 232, 232);
            panel1.Location = new Point(0, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 2);
            panel1.TabIndex = 8;
            // 
            // txtNumeroDeParcelasIncluirPassageiros
            // 
            txtNumeroDeParcelasIncluirPassageiros.Location = new Point(194, 118);
            txtNumeroDeParcelasIncluirPassageiros.Name = "txtNumeroDeParcelasIncluirPassageiros";
            txtNumeroDeParcelasIncluirPassageiros.Size = new Size(565, 23);
            txtNumeroDeParcelasIncluirPassageiros.TabIndex = 7;
            // 
            // txtValorDaEntradaIncluirPassageiros
            // 
            txtValorDaEntradaIncluirPassageiros.Location = new Point(194, 85);
            txtValorDaEntradaIncluirPassageiros.Name = "txtValorDaEntradaIncluirPassageiros";
            txtValorDaEntradaIncluirPassageiros.Size = new Size(565, 23);
            txtValorDaEntradaIncluirPassageiros.TabIndex = 6;
            // 
            // txtFormaDePagamentoIncluirPassageiros
            // 
            txtFormaDePagamentoIncluirPassageiros.Location = new Point(194, 48);
            txtFormaDePagamentoIncluirPassageiros.Name = "txtFormaDePagamentoIncluirPassageiros";
            txtFormaDePagamentoIncluirPassageiros.Size = new Size(565, 23);
            txtFormaDePagamentoIncluirPassageiros.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 121);
            label6.Name = "label6";
            label6.Size = new Size(116, 15);
            label6.TabIndex = 3;
            label6.Text = "Número de Parcelas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 85);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 2;
            label5.Text = "Valor da Entrada:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 51);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 1;
            label4.Text = "Forma de Pagamento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 18);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Cliente:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 370);
            label7.Name = "label7";
            label7.Size = new Size(223, 32);
            label7.TabIndex = 5;
            label7.Text = "Lista de Passageiros";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(232, 232, 232);
            panel3.Location = new Point(25, 405);
            panel3.Name = "panel3";
            panel3.Size = new Size(788, 2);
            panel3.TabIndex = 2;
            // 
            // lbIDViagemIncluirPassageiros
            // 
            lbIDViagemIncluirPassageiros.AutoSize = true;
            lbIDViagemIncluirPassageiros.Location = new Point(19, 96);
            lbIDViagemIncluirPassageiros.Name = "lbIDViagemIncluirPassageiros";
            lbIDViagemIncluirPassageiros.Size = new Size(38, 15);
            lbIDViagemIncluirPassageiros.TabIndex = 8;
            lbIDViagemIncluirPassageiros.Text = "label1";
            // 
            // dgvListaDePassageiros
            // 
            dgvListaDePassageiros.AllowUserToAddRows = false;
            dgvListaDePassageiros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListaDePassageiros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaDePassageiros.BackgroundColor = Color.White;
            dgvListaDePassageiros.BorderStyle = BorderStyle.None;
            dgvListaDePassageiros.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListaDePassageiros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaDePassageiros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListaDePassageiros.ColumnHeadersHeight = 40;
            dgvListaDePassageiros.Columns.AddRange(new DataGridViewColumn[] { btnExcluir });
            dgvListaDePassageiros.EnableHeadersVisualStyles = false;
            dgvListaDePassageiros.Location = new Point(29, 438);
            dgvListaDePassageiros.Name = "dgvListaDePassageiros";
            dgvListaDePassageiros.RowHeadersVisible = false;
            dgvListaDePassageiros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaDePassageiros.Size = new Size(779, 134);
            dgvListaDePassageiros.TabIndex = 9;
            dgvListaDePassageiros.CellClick += dgvListaDePassageiros_CellClick_1;
            dgvListaDePassageiros.Paint += dgvListaDePassageiros_Paint_1;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = resources.GetObject("dataGridViewCellStyle2.NullValue");
            dataGridViewCellStyle2.Padding = new Padding(8);
            btnExcluir.DefaultCellStyle = dataGridViewCellStyle2;
            btnExcluir.HeaderText = "";
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageLayout = DataGridViewImageCellLayout.Zoom;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Width = 50;
            // 
            // UC_IncluirPassageiros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvListaDePassageiros);
            Controls.Add(lbIDViagemIncluirPassageiros);
            Controls.Add(panel3);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(pnlSeparador1);
            Controls.Add(lbUCIncluirPassageiros);
            Name = "UC_IncluirPassageiros";
            Size = new Size(826, 633);
            Load += UC_IncluirPassageiros_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaDePassageiros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUCIncluirPassageiros;
        private Panel pnlSeparador1;
        private Label label2;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtNumeroDeParcelasIncluirPassageiros;
        private TextBox txtValorDaEntradaIncluirPassageiros;
        private TextBox txtFormaDePagamentoIncluirPassageiros;
        private Label label7;
        private Panel panel1;
        private Panel panel3;
        private BotaoPadraoMandecas btnVoltarIncluirPassageiros;
        private BotaoPadraoMandecas btnSalvarIncluirPassageiros;
        private Label lbIDViagemIncluirPassageiros;
        private ComboBox cbCliente;
        private DataGridView dgvListaDePassageiros;
        private DataGridViewImageColumn btnExcluir;
    }
}
