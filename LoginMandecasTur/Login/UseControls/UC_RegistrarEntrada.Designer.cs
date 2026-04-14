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
        /*protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_Registrar_Entrada = new Label();
            panel1 = new Panel();
            lbl_codigo_reserva = new Label();
            panel2 = new Panel();
            lbl_vencimento_RE = new Label();
            label10 = new Label();
            lbl_parcelaatual_RE = new Label();
            label9 = new Label();
            lbl_qtdd_RE = new Label();
            label8 = new Label();
            lbl_Viagem_RE = new Label();
            label7 = new Label();
            panel3 = new Panel();
            txt_valorparcela_RE = new TextBox();
            label6 = new Label();
            txt_pagamento_RE = new TextBox();
            label5 = new Label();
            txt_cliente_RE = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            botaoPadraoMandecas1 = new BotaoPadraoMandecas();
            btn_registrar_RE = new BotaoPadraoMandecas();
            panel5 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            btn_Cancelar_Reembolso = new BotaoPadraoMandecas();
            btn_Lancar_Reembolso = new BotaoPadraoMandecas();
            rtx_Reembolso = new RichTextBox();
            label3 = new Label();
            txt_Reembolso = new TextBox();
            label2 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
          
            // 
            // lbl_Registrar_Entrada
            // 
            lbl_Registrar_Entrada.AutoSize = true;
            lbl_Registrar_Entrada.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Registrar_Entrada.Location = new Point(40, 47);
            lbl_Registrar_Entrada.Name = "lbl_Registrar_Entrada";
            lbl_Registrar_Entrada.Size = new Size(202, 32);
            lbl_Registrar_Entrada.TabIndex = 0;
            lbl_Registrar_Entrada.Text = "Registrar Entrada";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Location = new Point(40, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 1);
            panel1.TabIndex = 1;
            
            // 
            // lbl_codigo_reserva
            // 
            lbl_codigo_reserva.AutoSize = true;
            lbl_codigo_reserva.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_codigo_reserva.Location = new Point(50, 91);
            lbl_codigo_reserva.Name = "lbl_codigo_reserva";
            lbl_codigo_reserva.Size = new Size(85, 13);
            lbl_codigo_reserva.TabIndex = 2;
            lbl_codigo_reserva.Text = "Código: RVD02";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(lbl_vencimento_RE);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lbl_parcelaatual_RE);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(lbl_qtdd_RE);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(lbl_Viagem_RE);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(72, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(680, 81);
            panel2.TabIndex = 3;
            // 
            // lbl_vencimento_RE
            // 
            lbl_vencimento_RE.AutoSize = true;
            lbl_vencimento_RE.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_vencimento_RE.Location = new Point(523, 38);
            lbl_vencimento_RE.Name = "lbl_vencimento_RE";
            lbl_vencimento_RE.Size = new Size(65, 15);
            lbl_vencimento_RE.TabIndex = 11;
            lbl_vencimento_RE.Text = "10/04/2026";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(523, 10);
            label10.Name = "label10";
            label10.Size = new Size(78, 17);
            label10.TabIndex = 10;
            label10.Text = "Vencimento:";
            // 
            // lbl_parcelaatual_RE
            // 
            lbl_parcelaatual_RE.AutoSize = true;
            lbl_parcelaatual_RE.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_parcelaatual_RE.Location = new Point(422, 38);
            lbl_parcelaatual_RE.Name = "lbl_parcelaatual_RE";
            lbl_parcelaatual_RE.Size = new Size(13, 15);
            lbl_parcelaatual_RE.TabIndex = 9;
            lbl_parcelaatual_RE.Text = "4";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(386, 10);
            label9.Name = "label9";
            label9.Size = new Size(86, 17);
            label9.TabIndex = 8;
            label9.Text = "Parcela Atual:";
            // 
            // lbl_qtdd_RE
            // 
            lbl_qtdd_RE.AutoSize = true;
            lbl_qtdd_RE.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_qtdd_RE.Location = new Point(267, 38);
            lbl_qtdd_RE.Name = "lbl_qtdd_RE";
            lbl_qtdd_RE.Size = new Size(13, 15);
            lbl_qtdd_RE.TabIndex = 7;
            lbl_qtdd_RE.Text = "6";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(209, 10);
            label8.Name = "label8";
            label8.Size = new Size(137, 17);
            label8.TabIndex = 6;
            label8.Text = "Qtd. total de Parcelas:";
            // 
            // lbl_Viagem_RE
            // 
            lbl_Viagem_RE.AutoSize = true;
            lbl_Viagem_RE.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Viagem_RE.Location = new Point(81, 38);
            lbl_Viagem_RE.Name = "lbl_Viagem_RE";
            lbl_Viagem_RE.Size = new Size(80, 15);
            lbl_Viagem_RE.TabIndex = 5;
            lbl_Viagem_RE.Text = "Rio de Janeiro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(90, 10);
            label7.Name = "label7";
            label7.Size = new Size(55, 17);
            label7.TabIndex = 4;
            label7.Text = "Viagem:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(txt_valorparcela_RE);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txt_pagamento_RE);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txt_cliente_RE);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(72, 254);
            panel3.Name = "panel3";
            panel3.Size = new Size(680, 180);
            panel3.TabIndex = 4;
            // 
            // txt_valorparcela_RE
            // 
            txt_valorparcela_RE.Location = new Point(267, 117);
            txt_valorparcela_RE.Name = "txt_valorparcela_RE";
            txt_valorparcela_RE.Size = new Size(311, 23);
            txt_valorparcela_RE.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(101, 123);
            label6.Name = "label6";
            label6.Size = new Size(87, 17);
            label6.TabIndex = 7;
            label6.Text = "Valor Parcela:";
            // 
            // txt_pagamento_RE
            // 
            txt_pagamento_RE.Location = new Point(267, 70);
            txt_pagamento_RE.Name = "txt_pagamento_RE";
            txt_pagamento_RE.Size = new Size(311, 23);
            txt_pagamento_RE.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(101, 76);
            label5.Name = "label5";
            label5.Size = new Size(137, 17);
            label5.TabIndex = 5;
            label5.Text = "Forma de Pagamento:";
            // 
            // txt_cliente_RE
            // 
            txt_cliente_RE.Location = new Point(267, 26);
            txt_cliente_RE.Name = "txt_cliente_RE";
            txt_cliente_RE.Size = new Size(311, 23);
            txt_cliente_RE.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(101, 32);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 3;
            label4.Text = "Cliente:";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(botaoPadraoMandecas1);
            panel4.Controls.Add(btn_registrar_RE);
            panel4.Location = new Point(72, 428);
            panel4.Name = "panel4";
            panel4.Size = new Size(680, 81);
            panel4.TabIndex = 5;
            // 
            // botaoPadraoMandecas1
            // 
            botaoPadraoMandecas1.BackColor = SystemColors.ControlLight;
            botaoPadraoMandecas1.FlatAppearance.BorderSize = 0;
            botaoPadraoMandecas1.FlatStyle = FlatStyle.Flat;
            botaoPadraoMandecas1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botaoPadraoMandecas1.ForeColor = Color.Black;
            botaoPadraoMandecas1.Location = new Point(376, 35);
            botaoPadraoMandecas1.Name = "botaoPadraoMandecas1";
            botaoPadraoMandecas1.Size = new Size(86, 23);
            botaoPadraoMandecas1.TabIndex = 14;
            botaoPadraoMandecas1.Text = "Cancelar";
            botaoPadraoMandecas1.UseVisualStyleBackColor = false;
            // 
            // btn_registrar_RE
            // 
            btn_registrar_RE.BackColor = Color.FromArgb(68, 252, 124);
            btn_registrar_RE.FlatAppearance.BorderSize = 0;
            btn_registrar_RE.FlatStyle = FlatStyle.Flat;
            btn_registrar_RE.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_registrar_RE.ForeColor = Color.Black;
            btn_registrar_RE.Location = new Point(215, 35);
            btn_registrar_RE.Name = "btn_registrar_RE";
            btn_registrar_RE.Size = new Size(131, 23);
            btn_registrar_RE.TabIndex = 13;
            btn_registrar_RE.Text = "Registrar Pagamento";
            btn_registrar_RE.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLight;
            panel5.Controls.Add(label1);
            panel5.Location = new Point(72, 566);
            panel5.Name = "panel5";
            panel5.Size = new Size(680, 41);
            panel5.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 11);
            label1.Name = "label1";
            label1.Size = new Size(118, 17);
            label1.TabIndex = 0;
            label1.Text = "Lançar Reembolso";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ButtonHighlight;
            panel6.Controls.Add(btn_Cancelar_Reembolso);
            panel6.Controls.Add(btn_Lancar_Reembolso);
            panel6.Controls.Add(rtx_Reembolso);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(txt_Reembolso);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(72, 604);
            panel6.Name = "panel6";
            panel6.Size = new Size(680, 158);
            panel6.TabIndex = 4;
            // 
            // btn_Cancelar_Reembolso
            // 
            btn_Cancelar_Reembolso.BackColor = SystemColors.ControlLight;
            btn_Cancelar_Reembolso.FlatAppearance.BorderSize = 0;
            btn_Cancelar_Reembolso.FlatStyle = FlatStyle.Flat;
            btn_Cancelar_Reembolso.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cancelar_Reembolso.ForeColor = Color.Black;
            btn_Cancelar_Reembolso.Location = new Point(376, 117);
            btn_Cancelar_Reembolso.Name = "btn_Cancelar_Reembolso";
            btn_Cancelar_Reembolso.Size = new Size(79, 23);
            btn_Cancelar_Reembolso.TabIndex = 13;
            btn_Cancelar_Reembolso.Text = "Cancelar";
            btn_Cancelar_Reembolso.UseVisualStyleBackColor = false;
            // 
            // btn_Lancar_Reembolso
            // 
            btn_Lancar_Reembolso.BackColor = Color.FromArgb(68, 252, 124);
            btn_Lancar_Reembolso.FlatAppearance.BorderSize = 0;
            btn_Lancar_Reembolso.FlatStyle = FlatStyle.Flat;
            btn_Lancar_Reembolso.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Lancar_Reembolso.ForeColor = Color.Black;
            btn_Lancar_Reembolso.Location = new Point(237, 117);
            btn_Lancar_Reembolso.Name = "btn_Lancar_Reembolso";
            btn_Lancar_Reembolso.Size = new Size(79, 23);
            btn_Lancar_Reembolso.TabIndex = 12;
            btn_Lancar_Reembolso.Text = "Lançar";
            btn_Lancar_Reembolso.UseVisualStyleBackColor = false;
            // 
            // rtx_Reembolso
            // 
            rtx_Reembolso.Location = new Point(422, 18);
            rtx_Reembolso.Name = "rtx_Reembolso";
            rtx_Reembolso.Size = new Size(237, 77);
            rtx_Reembolso.TabIndex = 3;
            rtx_Reembolso.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(364, 21);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 2;
            label3.Text = "Motivo:";
            // 
            // txt_Reembolso
            // 
            txt_Reembolso.Location = new Point(176, 18);
            txt_Reembolso.Name = "txt_Reembolso";
            txt_Reembolso.Size = new Size(129, 23);
            txt_Reembolso.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 19);
            label2.Name = "label2";
            label2.Size = new Size(156, 17);
            label2.TabIndex = 0;
            label2.Text = "Valor a ser reembolsado:";
            // 
            // UC_RegistrarEntrada
            // 
         
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
           
        }

        #endregion

        private Label lbl_Registrar_Entrada;
        private Panel panel1;
        private Label lbl_codigo_reserva;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private Panel panel6;
        private Label label2;
        private RichTextBox rtx_Reembolso;
        private Label label3;
        private TextBox txt_Reembolso;
        private BotaoPadraoMandecas btn_Lancar_Reembolso;
        private BotaoPadraoMandecas btn_Cancelar_Reembolso;
        private TextBox txt_valorparcela_RE;
        private Label label6;
        private TextBox txt_pagamento_RE;
        private Label label5;
        private TextBox txt_cliente_RE;
        private Label label4;
        private BotaoPadraoMandecas btn_registrar_RE;
        private Label label10;
        private Label lbl_parcelaatual_RE;
        private Label label9;
        private Label lbl_qtdd_RE;
        private Label label8;
        private Label lbl_Viagem_RE;
        private Label label7;
        private BotaoPadraoMandecas botaoPadraoMandecas1;
        private Label lbl_vencimento_RE;
    }
}
