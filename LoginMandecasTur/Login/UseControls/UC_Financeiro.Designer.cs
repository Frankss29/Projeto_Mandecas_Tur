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
            panel4 = new Panel();
            richTextBox1 = new RichTextBox();
            btn_Cancelar = new BotaoPadraoMandecas();
            btn_Lancar_FN = new BotaoPadraoMandecas();
            lbl_descricao = new Label();
            panel2 = new Panel();
            lbl_Valor = new Label();
            comboBox2 = new ComboBox();
            txt_Valor = new TextBox();
            lbl_viagem = new Label();
            panel_gastos = new Panel();
            label1 = new Label();
            panel_linha = new Panel();
            panel3 = new Panel();
            btn_buscar_FN = new BotaoPadraoMandecas();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            Panel_Vencidos = new Panel();
            label7 = new Label();
            label6 = new Label();
            Panel_Pendentes = new Panel();
            label5 = new Label();
            label4 = new Label();
            Panel_Entrada = new Panel();
            label3 = new Label();
            label2 = new Label();
            dgv_Financeiro = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            viagem = new DataGridViewTextBoxColumn();
            valor_parcela = new DataGridViewTextBoxColumn();
            vencimento = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel_gastos.SuspendLayout();
            panel3.SuspendLayout();
            Panel_Vencidos.SuspendLayout();
            Panel_Pendentes.SuspendLayout();
            Panel_Entrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Financeiro).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel_gastos);
            panel1.Controls.Add(panel_linha);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(Panel_Vencidos);
            panel1.Controls.Add(Panel_Pendentes);
            panel1.Controls.Add(Panel_Entrada);
            panel1.Controls.Add(dgv_Financeiro);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 784);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(richTextBox1);
            panel4.Controls.Add(btn_Cancelar);
            panel4.Controls.Add(btn_Lancar_FN);
            panel4.Controls.Add(lbl_descricao);
            panel4.Location = new Point(32, 571);
            panel4.Name = "panel4";
            panel4.Size = new Size(761, 186);
            panel4.TabIndex = 12;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(18, 37);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(700, 84);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = SystemColors.ControlLight;
            btn_Cancelar.FlatAppearance.BorderSize = 0;
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cancelar.ForeColor = Color.Black;
            btn_Cancelar.Location = new Point(312, 142);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(79, 23);
            btn_Cancelar.TabIndex = 12;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_Lancar_FN
            // 
            btn_Lancar_FN.BackColor = Color.FromArgb(68, 252, 124);
            btn_Lancar_FN.FlatAppearance.BorderSize = 0;
            btn_Lancar_FN.FlatStyle = FlatStyle.Flat;
            btn_Lancar_FN.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Lancar_FN.ForeColor = Color.Black;
            btn_Lancar_FN.Location = new Point(397, 142);
            btn_Lancar_FN.Name = "btn_Lancar_FN";
            btn_Lancar_FN.Size = new Size(79, 23);
            btn_Lancar_FN.TabIndex = 11;
            btn_Lancar_FN.Text = "Lançar";
            btn_Lancar_FN.UseVisualStyleBackColor = false;
            // 
            // lbl_descricao
            // 
            lbl_descricao.AutoSize = true;
            lbl_descricao.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_descricao.Location = new Point(18, 15);
            lbl_descricao.Name = "lbl_descricao";
            lbl_descricao.Size = new Size(68, 17);
            lbl_descricao.TabIndex = 0;
            lbl_descricao.Text = "Descrição:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbl_Valor);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(txt_Valor);
            panel2.Controls.Add(lbl_viagem);
            panel2.Location = new Point(32, 527);
            panel2.Name = "panel2";
            panel2.Size = new Size(761, 47);
            panel2.TabIndex = 11;
            // 
            // lbl_Valor
            // 
            lbl_Valor.AutoSize = true;
            lbl_Valor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Valor.Location = new Point(550, 15);
            lbl_Valor.Name = "lbl_Valor";
            lbl_Valor.Size = new Size(41, 17);
            lbl_Valor.TabIndex = 3;
            lbl_Valor.Text = "Valor:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(79, 14);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(397, 23);
            comboBox2.TabIndex = 2;
            // 
            // txt_Valor
            // 
            txt_Valor.Location = new Point(588, 14);
            txt_Valor.Name = "txt_Valor";
            txt_Valor.Size = new Size(130, 23);
            txt_Valor.TabIndex = 1;
            // 
            // lbl_viagem
            // 
            lbl_viagem.AutoSize = true;
            lbl_viagem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_viagem.Location = new Point(18, 15);
            lbl_viagem.Name = "lbl_viagem";
            lbl_viagem.Size = new Size(55, 17);
            lbl_viagem.TabIndex = 0;
            lbl_viagem.Text = "Viagem:";
            // 
            // panel_gastos
            // 
            panel_gastos.BackColor = SystemColors.ControlLight;
            panel_gastos.Controls.Add(label1);
            panel_gastos.Location = new Point(32, 490);
            panel_gastos.Name = "panel_gastos";
            panel_gastos.Size = new Size(761, 41);
            panel_gastos.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(133, 17);
            label1.TabIndex = 0;
            label1.Text = "Lançar Gastos Extras";
            // 
            // panel_linha
            // 
            panel_linha.BackColor = SystemColors.ControlLight;
            panel_linha.Location = new Point(32, 464);
            panel_linha.Name = "panel_linha";
            panel_linha.Size = new Size(761, 1);
            panel_linha.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(btn_buscar_FN);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(comboBox1);
            panel3.Location = new Point(32, 202);
            panel3.Name = "panel3";
            panel3.Size = new Size(763, 59);
            panel3.TabIndex = 7;
            // 
            // btn_buscar_FN
            // 
            btn_buscar_FN.BackColor = Color.FromArgb(68, 252, 124);
            btn_buscar_FN.FlatAppearance.BorderSize = 0;
            btn_buscar_FN.FlatStyle = FlatStyle.Flat;
            btn_buscar_FN.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_buscar_FN.ForeColor = Color.Black;
            btn_buscar_FN.Location = new Point(671, 20);
            btn_buscar_FN.Name = "btn_buscar_FN";
            btn_buscar_FN.Size = new Size(79, 23);
            btn_buscar_FN.TabIndex = 10;
            btn_buscar_FN.Text = "Buscar";
            btn_buscar_FN.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(267, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(387, 23);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Filtrar por Status", "Pago", "Pendente", "Vencido" });
            comboBox1.Location = new Point(19, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(231, 24);
            comboBox1.TabIndex = 0;
            comboBox1.DrawItem += comboBox1_DrawItem;
            // 
            // Panel_Vencidos
            // 
            Panel_Vencidos.BackColor = Color.OrangeRed;
            Panel_Vencidos.Controls.Add(label7);
            Panel_Vencidos.Controls.Add(label6);
            Panel_Vencidos.Location = new Point(567, 29);
            Panel_Vencidos.Name = "Panel_Vencidos";
            Panel_Vencidos.Size = new Size(228, 145);
            Panel_Vencidos.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(54, 65);
            label7.Name = "label7";
            label7.Size = new Size(111, 25);
            label7.TabIndex = 3;
            label7.Text = "R$2.330,00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(8, 16);
            label6.Name = "label6";
            label6.Size = new Size(217, 25);
            label6.TabIndex = 2;
            label6.Text = "Vencidos/Inadimplência";
            // 
            // Panel_Pendentes
            // 
            Panel_Pendentes.BackColor = Color.Gold;
            Panel_Pendentes.Controls.Add(label5);
            Panel_Pendentes.Controls.Add(label4);
            Panel_Pendentes.Location = new Point(299, 29);
            Panel_Pendentes.Name = "Panel_Pendentes";
            Panel_Pendentes.Size = new Size(228, 145);
            Panel_Pendentes.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(56, 65);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 2;
            label5.Text = "R$5.380,00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(30, 16);
            label4.Name = "label4";
            label4.Size = new Size(164, 25);
            label4.TabIndex = 1;
            label4.Text = "Contas Pendentes";
            // 
            // Panel_Entrada
            // 
            Panel_Entrada.BackColor = Color.MediumSeaGreen;
            Panel_Entrada.Controls.Add(label3);
            Panel_Entrada.Controls.Add(label2);
            Panel_Entrada.Location = new Point(32, 29);
            Panel_Entrada.Name = "Panel_Entrada";
            Panel_Entrada.Size = new Size(228, 145);
            Panel_Entrada.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(53, 65);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 0;
            label3.Text = "R$30.250,00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 16);
            label2.Name = "label2";
            label2.Size = new Size(213, 25);
            label2.TabIndex = 0;
            label2.Text = "Receita Realizada (Mês)";
            // 
            // dgv_Financeiro
            // 
            dgv_Financeiro.AllowUserToOrderColumns = true;
            dgv_Financeiro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Financeiro.BackgroundColor = SystemColors.ControlLight;
            dgv_Financeiro.BorderStyle = BorderStyle.None;
            dgv_Financeiro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Financeiro.Columns.AddRange(new DataGridViewColumn[] { codigo, cliente, viagem, valor_parcela, vencimento, status });
            dgv_Financeiro.Location = new Point(32, 285);
            dgv_Financeiro.Name = "dgv_Financeiro";
            dgv_Financeiro.Size = new Size(763, 151);
            dgv_Financeiro.TabIndex = 8;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            // 
            // cliente
            // 
            cliente.HeaderText = "Cliente";
            cliente.Name = "cliente";
            // 
            // viagem
            // 
            viagem.HeaderText = "Viagem";
            viagem.Name = "viagem";
            // 
            // valor_parcela
            // 
            valor_parcela.HeaderText = "Valor Parcela";
            valor_parcela.Name = "valor_parcela";
            // 
            // vencimento
            // 
            vencimento.HeaderText = "Vencimento";
            vencimento.Name = "vencimento";
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.Name = "status";
            // 
            // UC_Financeiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UC_Financeiro";
            Size = new Size(826, 784);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel_gastos.ResumeLayout(false);
            panel_gastos.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Panel panel3;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Panel Panel_Vencidos;
        private Panel Panel_Pendentes;
        private Panel Panel_Entrada;
        private DataGridView dgv_Financeiro;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn viagem;
        private DataGridViewTextBoxColumn valor_parcela;
        private DataGridViewTextBoxColumn vencimento;
        private DataGridViewTextBoxColumn status;
        private Panel panel_linha;
        private BotaoPadraoMandecas btn_buscar_FN;
        private Panel panel_gastos;
        private Panel panel2;
        private Label lbl_Valor;
        private ComboBox comboBox2;
        private TextBox txt_Valor;
        private Label lbl_viagem;
        private Label label1;
        private Panel panel4;
        private Label lbl_descricao;
        private BotaoPadraoMandecas btn_Cancelar;
        private BotaoPadraoMandecas btn_Lancar_FN;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private RichTextBox richTextBox1;
    }
}
