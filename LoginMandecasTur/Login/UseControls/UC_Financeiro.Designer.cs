namespace Login.UseControls
{
    partial class UC_Financeiro
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
            panel1 = new Panel();
            btnAtualizar = new BotaoPadraoMandecas();
            panel2 = new Panel();
<<<<<<< HEAD
            rbCustoViagem = new RadioButton();
            rbReciboCliente = new RadioButton();
            rbListaPassageiros = new RadioButton();
=======
            comboBox1 = new ComboBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            Lis = new RadioButton();
>>>>>>> 0f9171aa90387ae121e2a25c6a415b0458574b84
            label8 = new Label();
            botaoPadraoMandecas3 = new BotaoPadraoMandecas();
            cboViagemRelatorio = new ComboBox();
            lbViagemFinanceiro = new Label();
            lbRelatorioFinanceiro = new Label();
            panel4 = new Panel();
            label1 = new Label();
            pnlDEBusca = new Panel();
            btnBuscarFinanceiro = new BotaoPadraoMandecas();
            lblLimparFiltro = new Label();
            txtBuscaFinanceiro = new TextBox();
            cboStatus = new ComboBox();
            Panel_Vencidos = new Panel();
            lblVencidos = new Label();
            label6 = new Label();
            Panel_Pendentes = new Panel();
            lblPendentes = new Label();
            label4 = new Label();
            Panel_Entrada = new Panel();
            lblEntradas = new Label();
            label2 = new Label();
            dgv_Financeiro = new DataGridView();
            cboClienteRelatorio = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            pnlDEBusca.SuspendLayout();
            Panel_Vencidos.SuspendLayout();
            Panel_Pendentes.SuspendLayout();
            Panel_Entrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Financeiro).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnAtualizar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnlDEBusca);
            panel1.Controls.Add(Panel_Vencidos);
            panel1.Controls.Add(Panel_Pendentes);
            panel1.Controls.Add(Panel_Entrada);
            panel1.Controls.Add(dgv_Financeiro);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1172, 577);
            panel1.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(68, 252, 124);
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.ForeColor = Color.Black;
            btnAtualizar.Location = new Point(694, 520);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(92, 23);
            btnAtualizar.TabIndex = 9;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ButtonHighlight;
<<<<<<< HEAD
            panel2.Controls.Add(cboClienteRelatorio);
            panel2.Controls.Add(rbCustoViagem);
            panel2.Controls.Add(rbReciboCliente);
            panel2.Controls.Add(rbListaPassageiros);
=======
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(Lis);
>>>>>>> 0f9171aa90387ae121e2a25c6a415b0458574b84
            panel2.Controls.Add(label8);
            panel2.Controls.Add(botaoPadraoMandecas3);
            panel2.Controls.Add(cboViagemRelatorio);
            panel2.Controls.Add(lbViagemFinanceiro);
            panel2.Controls.Add(lbRelatorioFinanceiro);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(808, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(319, 424);
            panel2.TabIndex = 1;
            // 
<<<<<<< HEAD
            // rbCustoViagem
=======
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(85, 242);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(203, 23);
            comboBox1.TabIndex = 11;
            // 
            // radioButton3
>>>>>>> 0f9171aa90387ae121e2a25c6a415b0458574b84
            // 
            rbCustoViagem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rbCustoViagem.AutoSize = true;
            rbCustoViagem.Font = new Font("Segoe UI", 10F);
            rbCustoViagem.Location = new Point(42, 172);
            rbCustoViagem.Name = "rbCustoViagem";
            rbCustoViagem.Size = new Size(246, 23);
            rbCustoViagem.TabIndex = 10;
            rbCustoViagem.TabStop = true;
            rbCustoViagem.Text = "Demonstrativo de Custo da Viagem";
            rbCustoViagem.UseVisualStyleBackColor = true;
            // 
            // rbReciboCliente
            // 
            rbReciboCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rbReciboCliente.AutoSize = true;
            rbReciboCliente.Font = new Font("Segoe UI", 10F);
            rbReciboCliente.Location = new Point(42, 143);
            rbReciboCliente.Name = "rbReciboCliente";
            rbReciboCliente.Size = new Size(132, 23);
            rbReciboCliente.TabIndex = 9;
            rbReciboCliente.TabStop = true;
            rbReciboCliente.Text = "Recibo de Cliente";
            rbReciboCliente.UseVisualStyleBackColor = true;
            rbReciboCliente.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbListaPassageiros
            // 
            rbListaPassageiros.AutoSize = true;
            rbListaPassageiros.Font = new Font("Segoe UI", 10F);
            rbListaPassageiros.Location = new Point(42, 113);
            rbListaPassageiros.Name = "rbListaPassageiros";
            rbListaPassageiros.Size = new Size(149, 23);
            rbListaPassageiros.TabIndex = 8;
            rbListaPassageiros.TabStop = true;
            rbListaPassageiros.Text = "Lista de Passageiros";
            rbListaPassageiros.UseVisualStyleBackColor = true;
            rbListaPassageiros.CheckedChanged += Lis_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(33, 75);
            label8.Name = "label8";
            label8.Size = new Size(255, 20);
            label8.TabIndex = 7;
            label8.Text = "Selecione um dos tipos de relatórios";
            // 
            // botaoPadraoMandecas3
            // 
            botaoPadraoMandecas3.BackColor = Color.FromArgb(68, 252, 124);
            botaoPadraoMandecas3.FlatAppearance.BorderSize = 0;
            botaoPadraoMandecas3.FlatStyle = FlatStyle.Flat;
            botaoPadraoMandecas3.Font = new Font("Segoe UI Semibold", 11F);
            botaoPadraoMandecas3.ForeColor = Color.Black;
            botaoPadraoMandecas3.Location = new Point(112, 363);
            botaoPadraoMandecas3.Name = "botaoPadraoMandecas3";
            botaoPadraoMandecas3.Size = new Size(113, 28);
            botaoPadraoMandecas3.TabIndex = 6;
            botaoPadraoMandecas3.Text = "Gerar PDF";
            botaoPadraoMandecas3.UseVisualStyleBackColor = false;
            botaoPadraoMandecas3.Click += botaoPadraoMandecas3_Click;
            // 
            // cboViagemRelatorio
            // 
            cboViagemRelatorio.FormattingEnabled = true;
            cboViagemRelatorio.Location = new Point(85, 288);
            cboViagemRelatorio.Name = "cboViagemRelatorio";
            cboViagemRelatorio.Size = new Size(203, 23);
            cboViagemRelatorio.TabIndex = 5;
            // 
            // lbViagemFinanceiro
            // 
            lbViagemFinanceiro.AutoSize = true;
            lbViagemFinanceiro.Location = new Point(29, 292);
            lbViagemFinanceiro.Name = "lbViagemFinanceiro";
            lbViagemFinanceiro.Size = new Size(50, 15);
            lbViagemFinanceiro.TabIndex = 2;
            lbViagemFinanceiro.Text = "Viagem:";
            // 
            // lbRelatorioFinanceiro
            // 
            lbRelatorioFinanceiro.AutoSize = true;
            lbRelatorioFinanceiro.Location = new Point(29, 245);
            lbRelatorioFinanceiro.Name = "lbRelatorioFinanceiro";
            lbRelatorioFinanceiro.Size = new Size(47, 15);
            lbRelatorioFinanceiro.TabIndex = 1;
            lbRelatorioFinanceiro.Text = "Cliente:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(68, 252, 124);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(319, 51);
            panel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 14);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 0;
            label1.Text = "Gerar Relatórios";
            // 
            // pnlDEBusca
            // 
            pnlDEBusca.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlDEBusca.BackColor = SystemColors.ControlLight;
            pnlDEBusca.Controls.Add(btnBuscarFinanceiro);
            pnlDEBusca.Controls.Add(lblLimparFiltro);
            pnlDEBusca.Controls.Add(txtBuscaFinanceiro);
            pnlDEBusca.Controls.Add(cboStatus);
            pnlDEBusca.Location = new Point(23, 253);
            pnlDEBusca.Name = "pnlDEBusca";
            pnlDEBusca.Size = new Size(763, 59);
            pnlDEBusca.TabIndex = 7;
            // 
            // btnBuscarFinanceiro
            // 
            btnBuscarFinanceiro.BackColor = Color.FromArgb(68, 252, 124);
            btnBuscarFinanceiro.FlatAppearance.BorderSize = 0;
            btnBuscarFinanceiro.FlatStyle = FlatStyle.Flat;
            btnBuscarFinanceiro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarFinanceiro.ForeColor = Color.Black;
            btnBuscarFinanceiro.Location = new Point(510, 20);
            btnBuscarFinanceiro.Name = "btnBuscarFinanceiro";
            btnBuscarFinanceiro.Size = new Size(79, 23);
            btnBuscarFinanceiro.TabIndex = 4;
            btnBuscarFinanceiro.Text = "Buscar";
            btnBuscarFinanceiro.UseVisualStyleBackColor = false;
            btnBuscarFinanceiro.Click += btnBuscarFinanceiro_Click;
            // 
            // lblLimparFiltro
            // 
            lblLimparFiltro.AutoSize = true;
            lblLimparFiltro.Location = new Point(599, 24);
            lblLimparFiltro.Name = "lblLimparFiltro";
            lblLimparFiltro.Size = new Size(129, 15);
            lblLimparFiltro.TabIndex = 3;
            lblLimparFiltro.Text = "Limpar Filtros de Busca";
            lblLimparFiltro.Click += lblLimparFiltro_Click;
            // 
            // txtBuscaFinanceiro
            // 
            txtBuscaFinanceiro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBuscaFinanceiro.Location = new Point(226, 21);
            txtBuscaFinanceiro.Name = "txtBuscaFinanceiro";
            txtBuscaFinanceiro.Size = new Size(265, 23);
            txtBuscaFinanceiro.TabIndex = 1;
            // 
            // cboStatus
            // 
            cboStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboStatus.DrawMode = DrawMode.OwnerDrawFixed;
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Filtrar por Status", "Pago", "Pendente", "Vencido" });
            cboStatus.Location = new Point(17, 20);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(188, 24);
            cboStatus.TabIndex = 0;
            cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged;
            // 
            // Panel_Vencidos
            // 
            Panel_Vencidos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Panel_Vencidos.BackColor = Color.Transparent;
            Panel_Vencidos.Controls.Add(lblVencidos);
            Panel_Vencidos.Controls.Add(label6);
            Panel_Vencidos.Location = new Point(558, 80);
            Panel_Vencidos.Name = "Panel_Vencidos";
            Panel_Vencidos.Size = new Size(228, 145);
            Panel_Vencidos.TabIndex = 5;
            Panel_Vencidos.Paint += DesenharCard;
            // 
            // lblVencidos
            // 
            lblVencidos.AutoSize = true;
            lblVencidos.BackColor = Color.Transparent;
            lblVencidos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVencidos.ForeColor = SystemColors.ButtonHighlight;
            lblVencidos.Location = new Point(70, 65);
            lblVencidos.Name = "lblVencidos";
            lblVencidos.Size = new Size(0, 25);
            lblVencidos.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(23, 18);
            label6.Name = "label6";
            label6.Size = new Size(185, 21);
            label6.TabIndex = 2;
            label6.Text = "Vencidos/Inadimplência";
            // 
            // Panel_Pendentes
            // 
            Panel_Pendentes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Panel_Pendentes.BackColor = Color.Transparent;
            Panel_Pendentes.Controls.Add(lblPendentes);
            Panel_Pendentes.Controls.Add(label4);
            Panel_Pendentes.Location = new Point(290, 80);
            Panel_Pendentes.Name = "Panel_Pendentes";
            Panel_Pendentes.Size = new Size(228, 145);
            Panel_Pendentes.TabIndex = 6;
            Panel_Pendentes.Paint += DesenharCard;
            // 
            // lblPendentes
            // 
            lblPendentes.AutoSize = true;
            lblPendentes.BackColor = Color.Transparent;
            lblPendentes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendentes.ForeColor = SystemColors.ButtonHighlight;
            lblPendentes.Location = new Point(74, 65);
            lblPendentes.Name = "lblPendentes";
            lblPendentes.Size = new Size(0, 25);
            lblPendentes.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(44, 16);
            label4.Name = "label4";
            label4.Size = new Size(140, 21);
            label4.TabIndex = 1;
            label4.Text = "Contas Pendentes";
            // 
            // Panel_Entrada
            // 
            Panel_Entrada.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Panel_Entrada.BackColor = Color.Transparent;
            Panel_Entrada.Controls.Add(lblEntradas);
            Panel_Entrada.Controls.Add(label2);
            Panel_Entrada.Location = new Point(23, 80);
            Panel_Entrada.Name = "Panel_Entrada";
            Panel_Entrada.Size = new Size(228, 145);
            Panel_Entrada.TabIndex = 4;
            Panel_Entrada.Paint += DesenharCard;
            // 
            // lblEntradas
            // 
            lblEntradas.AutoSize = true;
            lblEntradas.BackColor = Color.Transparent;
            lblEntradas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntradas.ForeColor = SystemColors.ButtonHighlight;
            lblEntradas.Location = new Point(74, 65);
            lblEntradas.Name = "lblEntradas";
            lblEntradas.Size = new Size(0, 25);
            lblEntradas.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(24, 17);
            label2.Name = "label2";
            label2.Size = new Size(181, 21);
            label2.TabIndex = 0;
            label2.Text = "Receita Realizada (Mês)";
            // 
            // dgv_Financeiro
            // 
            dgv_Financeiro.AllowUserToAddRows = false;
            dgv_Financeiro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgv_Financeiro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Financeiro.BackgroundColor = SystemColors.ControlLight;
            dgv_Financeiro.BorderStyle = BorderStyle.None;
            dgv_Financeiro.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Financeiro.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Financeiro.ColumnHeadersHeight = 40;
            dgv_Financeiro.EnableHeadersVisualStyles = false;
            dgv_Financeiro.Location = new Point(23, 336);
            dgv_Financeiro.Name = "dgv_Financeiro";
            dgv_Financeiro.RowHeadersVisible = false;
            dgv_Financeiro.Size = new Size(763, 168);
            dgv_Financeiro.TabIndex = 8;
            dgv_Financeiro.CellContentClick += dgv_Financeiro_CellContentClick;
            dgv_Financeiro.CellPainting += dgv_Financeiro_CellPainting;
            // 
            // cboClienteRelatorio
            // 
            cboClienteRelatorio.FormattingEnabled = true;
            cboClienteRelatorio.Location = new Point(85, 242);
            cboClienteRelatorio.Name = "cboClienteRelatorio";
            cboClienteRelatorio.Size = new Size(203, 23);
            cboClienteRelatorio.TabIndex = 11;
            // 
            // UC_Financeiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UC_Financeiro";
            Size = new Size(1172, 577);
            Load += UC_Financeiro_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            pnlDEBusca.ResumeLayout(false);
            pnlDEBusca.PerformLayout();
            Panel_Vencidos.ResumeLayout(false);
            Panel_Vencidos.PerformLayout();
            Panel_Pendentes.ResumeLayout(false);
            Panel_Pendentes.PerformLayout();
            Panel_Entrada.ResumeLayout(false);
            Panel_Entrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Financeiro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlDEBusca;
        private TextBox txtBuscaFinanceiro;
        private ComboBox cboStatus;
        private Panel Panel_Vencidos;
        private Panel Panel_Pendentes;
        private Panel Panel_Entrada;
        private DataGridView dgv_Financeiro;
        private BotaoPadraoMandecas btn_buscar_FN;
        private Label lblVencidos;
        private Label label6;
        private Label lblPendentes;
        private Label label4;
        private Label lblEntradas;
        private Label label2;
        private Panel panel2;
        private Panel panel4;
        private Label label1;
       // private ComboBox comboBox2;
        private Label lbViagemFinanceiro;
        private Label lbRelatorioFinanceiro;
        private BotaoPadraoMandecas botaoPadraoMandecas2;
        private BotaoPadraoMandecas botaoPadraoMandecas1;
        private ComboBox cboViagemRelatorio;
        private Label label8;
        private BotaoPadraoMandecas botaoPadraoMandecas3;
        private RadioButton rbListaPassageiros;
        private RadioButton rbReciboCliente;
        private RadioButton rbCustoViagem;
        private Label lblLimparFiltro;
        private BotaoPadraoMandecas btnBuscarFinanceiro;
        private BotaoPadraoMandecas btnAtualizar;
<<<<<<< HEAD
        private ComboBox cboClienteRelatorio;
=======
        private ComboBox comboBox1;
>>>>>>> 0f9171aa90387ae121e2a25c6a415b0458574b84
    }
}
