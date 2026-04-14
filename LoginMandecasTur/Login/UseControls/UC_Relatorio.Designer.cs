namespace Login.UseControls
{
    partial class UC_Relatorio
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            Lis = new RadioButton();
            panel1 = new Panel();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(58, 97);
            label1.Name = "label1";
            label1.Size = new Size(261, 48);
            label1.TabIndex = 3;
            label1.Text = "Gerar Relatório";
            label1.Click += label1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(68, 252, 124);
            flowLayoutPanel1.Controls.Add(dataGridView1);
            flowLayoutPanel1.ForeColor = SystemColors.ControlText;
            flowLayoutPanel1.Location = new Point(49, 171);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(727, 2);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 0;
            // 
            // Lis
            // 
            Lis.AutoSize = true;
            Lis.Font = new Font("Segoe UI", 10F);
            Lis.Location = new Point(35, 15);
            Lis.Name = "Lis";
            Lis.Size = new Size(149, 23);
            Lis.TabIndex = 6;
            Lis.TabStop = true;
            Lis.Text = "Lista de Passageiros";
            Lis.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(Lis);
            panel1.Font = new Font("Microsoft Sans Serif", 9.75F);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(53, 191);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 54);
            panel1.TabIndex = 7;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 10F);
            radioButton3.Location = new Point(447, 15);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(246, 23);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "Demonstrativo de Custo da Viagem";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 10F);
            radioButton2.Location = new Point(260, 15);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(132, 23);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Recibo de Cliente";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Microsoft Sans Serif", 9.75F);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(53, 268);
            panel2.Name = "panel2";
            panel2.Size = new Size(723, 115);
            panel2.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(464, 14);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(229, 24);
            comboBox2.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(68, 252, 124);
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(321, 69);
            button1.Name = "button1";
            button1.Size = new Size(84, 32);
            button1.TabIndex = 12;
            button1.Text = "Gerar PDF";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(170, 14);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 24);
            comboBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 17);
            label3.Name = "label3";
            label3.Size = new Size(51, 16);
            label3.TabIndex = 9;
            label3.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 17);
            label2.Name = "label2";
            label2.Size = new Size(153, 16);
            label2.TabIndex = 0;
            label2.Text = "Selecione uma Viagem: ";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // UC_Relatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Name = "UC_Relatorio";
            Size = new Size(820, 514);
            Load += UC_Relatorio_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridView1;
        private RadioButton Lis;
        private Panel panel1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}
