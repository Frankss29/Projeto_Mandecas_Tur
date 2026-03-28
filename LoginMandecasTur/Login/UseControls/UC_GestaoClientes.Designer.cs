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
            textBuscaGCliente = new TextBox();
            botaoPadraoMandecas1 = new BotaoPadraoMandecas();
            dgvClientes = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colCPF = new DataGridViewTextBoxColumn();
            colContato = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // textBuscaGCliente
            // 
            textBuscaGCliente.Location = new Point(46, 36);
            textBuscaGCliente.Name = "textBuscaGCliente";
            textBuscaGCliente.Size = new Size(415, 23);
            textBuscaGCliente.TabIndex = 0;
            textBuscaGCliente.TextChanged += textBuscaGCliente_TextChanged;
            // 
            // botaoPadraoMandecas1
            // 
            botaoPadraoMandecas1.BackColor = Color.FromArgb(68, 252, 124);
            botaoPadraoMandecas1.FlatAppearance.BorderSize = 0;
            botaoPadraoMandecas1.FlatStyle = FlatStyle.Flat;
            botaoPadraoMandecas1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botaoPadraoMandecas1.ForeColor = Color.Black;
            botaoPadraoMandecas1.Location = new Point(471, 34);
            botaoPadraoMandecas1.Name = "botaoPadraoMandecas1";
            botaoPadraoMandecas1.Size = new Size(75, 27);
            botaoPadraoMandecas1.TabIndex = 1;
            botaoPadraoMandecas1.Text = "Buscar";
            botaoPadraoMandecas1.UseVisualStyleBackColor = false;
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
            dgvClientes.Size = new Size(819, 168);
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
            // UC_GestaoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(dgvClientes);
            Controls.Add(botaoPadraoMandecas1);
            Controls.Add(textBuscaGCliente);
            Name = "UC_GestaoClientes";
            Padding = new Padding(20);
            Size = new Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBuscaGCliente;
        private BotaoPadraoMandecas botaoPadraoMandecas1;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colCPF;
        private DataGridViewTextBoxColumn colContato;
        private DataGridViewTextBoxColumn colEmail;
    }
}
