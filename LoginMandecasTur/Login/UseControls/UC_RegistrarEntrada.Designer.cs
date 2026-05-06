namespace Login.UseControls
{
    partial class UC_RegistrarEntrada
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
            label1 = new Label();
            panel2 = new Panel();
            lblInformativo = new Label();
            panel3 = new Panel();
            cbPassageiros = new ComboBox();
            cbViagens = new ComboBox();
            label12 = new Label();
            txtValorParcela = new TextBox();
            txtFormaPgto = new TextBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            panel4 = new Panel();
            btnregistrar = new Button();
            btnCancelar = new Button();
            panel5 = new Panel();
            label10 = new Label();
            panel6 = new Panel();
            btnlancar = new Button();
            btnCancelar2 = new Button();
            richTextBox1 = new RichTextBox();
            label11 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(68, 252, 124);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(59, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(707, 2);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 30);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 1;
            label1.Text = "Registrar Entrada";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblInformativo);
            panel2.Location = new Point(59, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(707, 71);
            panel2.TabIndex = 2;
            // 
            // lblInformativo
            // 
            lblInformativo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInformativo.Location = new Point(0, 22);
            lblInformativo.Name = "lblInformativo";
            lblInformativo.Size = new Size(707, 25);
            lblInformativo.TabIndex = 0;
            lblInformativo.Text = "Selecione a viagem e o cliente para iniciar:";
            lblInformativo.TextAlign = ContentAlignment.MiddleCenter;
            lblInformativo.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(cbPassageiros);
            panel3.Controls.Add(cbViagens);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtValorParcela);
            panel3.Controls.Add(txtFormaPgto);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label17);
            panel3.Location = new Point(59, 166);
            panel3.Name = "panel3";
            panel3.Size = new Size(707, 173);
            panel3.TabIndex = 3;
            // 
            // cbPassageiros
            // 
            cbPassageiros.FormattingEnabled = true;
            cbPassageiros.Location = new Point(240, 56);
            cbPassageiros.Name = "cbPassageiros";
            cbPassageiros.Size = new Size(285, 23);
            cbPassageiros.TabIndex = 8;
            cbPassageiros.SelectedIndexChanged += cbPassageiros_SelectedIndexChanged;
            // 
            // cbViagens
            // 
            cbViagens.FormattingEnabled = true;
            cbViagens.Location = new Point(240, 17);
            cbViagens.Name = "cbViagens";
            cbViagens.Size = new Size(285, 23);
            cbViagens.TabIndex = 7;
            cbViagens.SelectedIndexChanged += cbViagens_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(46, 20);
            label12.Name = "label12";
            label12.Size = new Size(65, 20);
            label12.TabIndex = 6;
            label12.Text = "Viagem:";
            // 
            // txtValorParcela
            // 
            txtValorParcela.Location = new Point(240, 127);
            txtValorParcela.Name = "txtValorParcela";
            txtValorParcela.Size = new Size(285, 23);
            txtValorParcela.TabIndex = 5;
            // 
            // txtFormaPgto
            // 
            txtFormaPgto.Location = new Point(240, 92);
            txtFormaPgto.Name = "txtFormaPgto";
            txtFormaPgto.Size = new Size(285, 23);
            txtFormaPgto.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(46, 130);
            label15.Name = "label15";
            label15.Size = new Size(124, 20);
            label15.TabIndex = 2;
            label15.Text = "Valor da Parcela:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(46, 91);
            label16.Name = "label16";
            label16.Size = new Size(160, 20);
            label16.TabIndex = 1;
            label16.Text = "Forma de Pagamento:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(46, 55);
            label17.Name = "label17";
            label17.Size = new Size(60, 20);
            label17.TabIndex = 0;
            label17.Text = "Cliente:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btnregistrar);
            panel4.Controls.Add(btnCancelar);
            panel4.Location = new Point(59, 334);
            panel4.Name = "panel4";
            panel4.Size = new Size(707, 50);
            panel4.TabIndex = 4;
            // 
            // btnregistrar
            // 
            btnregistrar.BackColor = Color.LimeGreen;
            btnregistrar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregistrar.Location = new Point(365, 11);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(160, 30);
            btnregistrar.TabIndex = 1;
            btnregistrar.Text = "Registrar Pagamento";
            btnregistrar.UseVisualStyleBackColor = false;
            btnregistrar.Click += btnregistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(254, 11);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 30);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGray;
            panel5.Controls.Add(label10);
            panel5.Location = new Point(59, 407);
            panel5.Name = "panel5";
            panel5.Size = new Size(707, 50);
            panel5.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(14, 11);
            label10.Name = "label10";
            label10.Size = new Size(133, 20);
            label10.TabIndex = 1;
            label10.Text = "Lançar Reembolso";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(btnlancar);
            panel6.Controls.Add(btnCancelar2);
            panel6.Controls.Add(richTextBox1);
            panel6.Controls.Add(label11);
            panel6.Location = new Point(59, 451);
            panel6.Name = "panel6";
            panel6.Size = new Size(707, 165);
            panel6.TabIndex = 6;
            // 
            // btnlancar
            // 
            btnlancar.BackColor = Color.LimeGreen;
            btnlancar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlancar.Location = new Point(384, 114);
            btnlancar.Name = "btnlancar";
            btnlancar.Size = new Size(90, 30);
            btnlancar.TabIndex = 5;
            btnlancar.Text = "Lançar";
            btnlancar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar2
            // 
            btnCancelar2.BackColor = Color.Silver;
            btnCancelar2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar2.Location = new Point(254, 114);
            btnCancelar2.Name = "btnCancelar2";
            btnCancelar2.Size = new Size(85, 30);
            btnCancelar2.TabIndex = 4;
            btnCancelar2.Text = "Cancelar";
            btnCancelar2.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(23, 29);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(650, 65);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(23, 9);
            label11.Name = "label11";
            label11.Size = new Size(54, 17);
            label11.TabIndex = 2;
            label11.Text = "Motivo:";
            // 
            // UC_RegistrarEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "UC_RegistrarEntrada";
            Size = new Size(826, 648);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label lblInformativo;
        private Panel panel3;
        private TextBox txtValorParcela;
        private TextBox txtFormaPgto;
        private Label label15;
        private Label label16;
        private Label label17;
        private Panel panel4;
        private Button btnregistrar;
        private Button btnCancelar;
        private Panel panel5;
        private Label label10;
        private Panel panel6;
        private Button btnlancar;
        private Button btnCancelar2;
        private RichTextBox richTextBox1;
        private Label label11;
        private Label label12;
        private ComboBox cbPassageiros;
        private ComboBox cbViagens;
    }
}
