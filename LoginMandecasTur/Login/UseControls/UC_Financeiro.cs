using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.IO;
using Color = System.Drawing.Color;

namespace Login.UseControls
{
    public partial class UC_Financeiro : UserControl
    {
        public UC_Financeiro()
        {
            InitializeComponent();
            ConfigurarEstiloGrid();
            AtualizarGrid();
            AtualizarCards();

            // Licença do QuestPDF (obrigatória e gratuita)
            QuestPDF.Settings.License = LicenseType.Community;
        }

        #region Configurações de Design e UI

        private void ConfigurarEstiloGrid()
        {
            dgv_Financeiro.ReadOnly = true;
            dgv_Financeiro.RowHeadersVisible = false;

            Color verdeClaroZebrado = Color.FromArgb(235, 247, 240);
            Color verdeMandecas = Color.FromArgb(46, 204, 113);
            Color cinzaCabecalho = Color.FromArgb(230, 230, 235);

            dgv_Financeiro.BackgroundColor = Color.White;
            dgv_Financeiro.BorderStyle = BorderStyle.None;
            dgv_Financeiro.AllowUserToAddRows = false;
            dgv_Financeiro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Financeiro.Font = new Font("Segoe UI", 9);

            dgv_Financeiro.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_Financeiro.AlternatingRowsDefaultCellStyle.BackColor = verdeClaroZebrado;
            dgv_Financeiro.RowsDefaultCellStyle.SelectionBackColor = verdeMandecas;
            dgv_Financeiro.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            dgv_Financeiro.EnableHeadersVisualStyles = false;
            dgv_Financeiro.ColumnHeadersVisible = true;
            dgv_Financeiro.ColumnHeadersDefaultCellStyle.BackColor = cinzaCabecalho;
            dgv_Financeiro.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv_Financeiro.ColumnHeadersHeight = 35;
            dgv_Financeiro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Financeiro.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        private void dgv_Financeiro_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgv_Financeiro.Columns[e.ColumnIndex].Name == "status_pagamento" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                string status = e.Value?.ToString() ?? "";
                Color corPilula = Color.Gray;
                Color corTexto = Color.White;

                if (status == "Pago") corPilula = Color.FromArgb(46, 204, 113);
                else if (status == "Pendente") corPilula = Color.FromArgb(241, 196, 15);
                else if (status == "Vencido") corPilula = Color.FromArgb(231, 76, 60);

                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(e.CellBounds.X + 10, e.CellBounds.Y + 5, e.CellBounds.Width - 20, e.CellBounds.Height - 11);
                using (GraphicsPath path = new GraphicsPath())
                {
                    int r = rect.Height;
                    path.AddArc(rect.X, rect.Y, r, r, 90, 180);
                    path.AddArc(rect.Right - r, rect.Y, r, r, 270, 180);
                    path.CloseFigure();
                    g.FillPath(new SolidBrush(corPilula), path);
                }

                TextRenderer.DrawText(g, status, dgv_Financeiro.Font, rect, corTexto, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                e.Handled = true;
            }
        }

        private void DesenharCard(object sender, PaintEventArgs e)
        {
            Panel pnl = (Panel)sender;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color corCard = Color.Gray;
            if (pnl.Name.Contains("Entrada")) corCard = Color.FromArgb(46, 204, 113);
            else if (pnl.Name.Contains("Pendentes")) corCard = Color.FromArgb(241, 196, 15);
            else if (pnl.Name.Contains("Vencidos")) corCard = Color.FromArgb(231, 76, 60);

            int radius = 20;
            using (GraphicsPath path = new GraphicsPath())
            {
                Rectangle rect = new Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1);
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                e.Graphics.FillPath(new SolidBrush(Color.FromArgb(40, corCard)), path);
                e.Graphics.DrawPath(new Pen(corCard, 3), path);
            }
        }

        private void ConfigurarColunas()
        {
            if (dgv_Financeiro.Columns.Contains("id_reserva"))
            {
                dgv_Financeiro.Columns["id_reserva"].HeaderText = "Código";
                dgv_Financeiro.Columns["id_reserva"].DisplayIndex = 0;
            }
            if (dgv_Financeiro.Columns.Contains("nome_cliente"))
            {
                dgv_Financeiro.Columns["nome_cliente"].HeaderText = "Cliente";
                dgv_Financeiro.Columns["nome_cliente"].DisplayIndex = 1;
            }
            if (dgv_Financeiro.Columns.Contains("nome_viagem"))
            {
                dgv_Financeiro.Columns["nome_viagem"].HeaderText = "Viagem";
                dgv_Financeiro.Columns["nome_viagem"].DisplayIndex = 2;
            }
            if (dgv_Financeiro.Columns.Contains("total_pago"))
            {
                dgv_Financeiro.Columns["total_pago"].HeaderText = "Total Pago";
                dgv_Financeiro.Columns["total_pago"].DisplayIndex = 3;
                dgv_Financeiro.Columns["total_pago"].DefaultCellStyle.Format = "C2";
            }
            if (dgv_Financeiro.Columns.Contains("valor_viagem"))
            {
                dgv_Financeiro.Columns["valor_viagem"].HeaderText = "Valor da Viagem";
                dgv_Financeiro.Columns["valor_viagem"].DisplayIndex = 4;
                dgv_Financeiro.Columns["valor_viagem"].DefaultCellStyle.Format = "C2";
            }
            if (dgv_Financeiro.Columns.Contains("data_inicio_pag"))
            {
                dgv_Financeiro.Columns["data_inicio_pag"].HeaderText = "Vencimento";
                dgv_Financeiro.Columns["data_inicio_pag"].DisplayIndex = 5;
            }
            if (dgv_Financeiro.Columns.Contains("status_pagamento"))
            {
                dgv_Financeiro.Columns["status_pagamento"].HeaderText = "Status";
                dgv_Financeiro.Columns["status_pagamento"].DisplayIndex = 6;
            }
        }

        #endregion

        #region Lógica de Dados e Buscas

        public void AtualizarGrid()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string sql = @"SELECT 
                                    r.id_reserva, 
                                    c.nome AS nome_cliente, 
                                    v.destino AS nome_viagem,
                                    COALESCE(r.valor_unitario, 0) AS valor_viagem,
                                    (SELECT COALESCE(SUM(f.valor_parcela), 0) FROM financeiro f WHERE f.id_reserva = r.id_reserva) AS total_pago,
                                    r.data_vencimento,
                                    CASE 
                                        WHEN r.status_pagamento = 'Pago' THEN 'Em Dia'
                                        WHEN r.data_vencimento < CURDATE() AND r.data_vencimento != 'Pago' THEN 'Vencido'
                                        ELSE 'Pendente'
                                    END AS status_pagamento
                                   FROM reserva r
                                   LEFT JOIN cliente c ON r.id_cliente = c.id_cliente
                                   LEFT JOIN viagem v ON r.id_viagem = v.id_viagem
                                   ORDER BY r.id_reserva DESC";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_Financeiro.DataSource = dt;
                ConfigurarColunas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados financeiros: " + ex.Message);
            }
            finally { if (con.State == ConnectionState.Open) con.Close(); }
        }

        public void AtualizarCards()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();

                string sqlEntradas = "SELECT SUM(valor_parcela) FROM financeiro";
                MySqlCommand cmd1 = new MySqlCommand(sqlEntradas, con);
                object resultadoEntradas = cmd1.ExecuteScalar();
                decimal entradas = resultadoEntradas != DBNull.Value ? Convert.ToDecimal(resultadoEntradas) : 0;
                lblEntradas.Text = entradas.ToString("C2");

                string sqlPendentes = @"SELECT (SELECT SUM(COALESCE(valor_unitario, 0)) FROM reserva) - (SELECT SUM(COALESCE(valor_parcela, 0)) FROM financeiro)";
                MySqlCommand cmd2 = new MySqlCommand(sqlPendentes, con);
                object resultadoPendentes = cmd2.ExecuteScalar();
                decimal pendentes = resultadoPendentes != DBNull.Value ? Convert.ToDecimal(resultadoPendentes) : 0;
                lblPendentes.Text = pendentes.ToString("C2");

                string sqlVencidos = @"SELECT SUM(COALESCE(valor_unitario, 0)) FROM reserva WHERE status_pagamento != 'Pago' AND data_vencimento < CURDATE()";
                MySqlCommand cmd3 = new MySqlCommand(sqlVencidos, con);
                object resultadoVencidos = cmd3.ExecuteScalar();
                decimal vencidos = resultadoVencidos != DBNull.Value ? Convert.ToDecimal(resultadoVencidos) : 0;
                lblVencidos.Text = vencidos.ToString("C2");
            }
            catch (Exception ex) { Console.WriteLine("Erro nos cards: " + ex.Message); }
            finally { if (con.State == ConnectionState.Open) con.Close(); }
        }

        public void RealizarBusca()
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string sqlBusca = @"SELECT 
                                r.id_reserva, 
                                c.nome AS nome_cliente, 
                                v.destino AS nome_viagem, 
                                r.valor_entrada, 
                                r.data_vencimento, 
                                r.status_pagamento 
                              FROM reserva r
                              INNER JOIN cliente c ON r.id_cliente = c.id_cliente
                              INNER JOIN viagem v ON r.id_viagem = v.id_viagem
                              WHERE 1=1";

                if (cboStatus.SelectedIndex != -1 && cboStatus.Text != "Todos") sqlBusca += " AND r.status_pagamento = @status";
                if (!string.IsNullOrWhiteSpace(txtBuscaFinanceiro.Text)) sqlBusca += " AND (c.nome LIKE @busca OR v.destino LIKE @busca)";

                MySqlCommand cmd = new MySqlCommand(sqlBusca, con);
                cmd.Parameters.AddWithValue("@status", cboStatus.Text);
                cmd.Parameters.AddWithValue("@busca", "%" + txtBuscaFinanceiro.Text + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_Financeiro.DataSource = dt;

                if (!string.IsNullOrWhiteSpace(txtBuscaFinanceiro.Text) || (cboStatus.SelectedIndex != -1 && cboStatus.Text != "Todos"))
                {
                    lblLimparFiltro.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro na busca: " + ex.Message); }
            finally { if (con != null && con.State == ConnectionState.Open) con.Close(); }
        }

        private void CarregarViagens()
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=mandecas;uid=root;pwd=;"))
            {
                conn.Open();
                string sql = "SELECT id_viagem, destino FROM viagem";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboViagemRelatorio.DataSource = dt;
                cboViagemRelatorio.DisplayMember = "destino";
                cboViagemRelatorio.ValueMember = "id_viagem";
                cboViagemRelatorio.SelectedIndex = -1;
            }
        }

        private void CarregarClientes()
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=mandecas;uid=root;pwd=;"))
            {
                conn.Open();
                string sql = "SELECT id_cliente, nome FROM cliente";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboClienteRelatorio.DataSource = dt;
                cboClienteRelatorio.DisplayMember = "nome";
                cboClienteRelatorio.ValueMember = "id_cliente";
                cboClienteRelatorio.SelectedIndex = -1;
            }
        }

        #endregion

        #region Eventos da Tela

        private void UC_Financeiro_Load(object sender, EventArgs e)
        {
            CarregarClientes();
            CarregarViagens();
            AtualizarGrid();
            AtualizarCards();
            lblVencidos.ForeColor = Color.Black;
        }

        private void lblLimparFiltro_Click(object sender, EventArgs e)
        {
            txtBuscaFinanceiro.Clear();
            cboStatus.SelectedIndex = 0;
            AtualizarGrid();
            lblLimparFiltro.Visible = false;
        }

        private void btnBuscarFinanceiro_Click(object sender, EventArgs e) { RealizarBusca(); }
        private void btnAtualizar_Click(object sender, EventArgs e) { AtualizarGrid(); AtualizarCards(); }
        private void dgv_Financeiro_CellContentClick(object sender, DataGridViewCellEventArgs e) { AtualizarGrid(); }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Lis_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }

        private void botaoPadraoMandecas3_Click(object sender, EventArgs e)
        {
            if (rbListaPassageiros.Checked) GerarListaPassageiros();
            else if (rbReciboCliente.Checked) GerarRecibo();
            else if (rbCustoViagem.Checked) GerarCustos();
            else MessageBox.Show("Selecione um tipo de relatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region Geração de Relatórios em PDF (QuestPDF)

        private void GerarListaPassageiros()
        {
            if (cboViagemRelatorio.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma Viagem para gerar a lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF|*.pdf", FileName = $"Lista_Passageiros.pdf" };
            if (sfd.ShowDialog() != DialogResult.OK) return;

            string caminhoLogo = @"C:\Users\silas.sbsilva\Downloads\Mídia.jpg";

            try
            {
                DataTable dt = new DataTable();
                using (MySqlConnection conn = new Conexao().Conectar())
                {
                    conn.Open();
                    // Atualizado: Puxando a poltrona e local de embarque
                    string sql = @"SELECT c.nome, c.cpf, c.telefone, r.status_pagamento, 
                                          COALESCE(r.poltrona, '-') AS poltrona, 
                                          COALESCE(r.local_embarque, 'Padrão') AS local_embarque 
                                   FROM reserva r 
                                   INNER JOIN cliente c ON r.id_cliente = c.id_cliente 
                                   WHERE r.id_viagem = @id_viagem";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id_viagem", cboViagemRelatorio.SelectedValue);
                    new MySqlDataAdapter(cmd).Fill(dt);
                }

                if (dt.Rows.Count == 0) { MessageBox.Show("Nenhum passageiro encontrado nesta viagem."); return; }

                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(2, Unit.Centimetre);

                        // Cabeçalho com Logo Arredondada
                        page.Header().Row(row =>
                        {
                            if (File.Exists(caminhoLogo))
                                row.ConstantItem(60)
                                   .Height(60)
                                   .CornerRadius(30)
                                   .Image(caminhoLogo, ImageScaling.Resize);

                            row.RelativeItem().PaddingLeft(15).AlignMiddle()
                               .Text($"Lista de Passageiros - {cboViagemRelatorio.Text}")
                               .FontSize(18).SemiBold().FontColor("#2ecc71");
                        });

                        page.Content().PaddingVertical(1, Unit.Centimetre).Table(table =>
                        {
                            table.ColumnsDefinition(columns => {
                                columns.RelativeColumn(3); // Nome
                                columns.RelativeColumn(2); // CPF
                                columns.RelativeColumn(2); // Telefone
                                columns.RelativeColumn(1); // Poltrona
                                columns.RelativeColumn(2); // Embarque
                                columns.RelativeColumn(2); // Status
                            });

                            table.Header(header =>
                            {
                                header.Cell().Text("Nome Completo").SemiBold();
                                header.Cell().Text("Documento").SemiBold();
                                header.Cell().Text("Telefone").SemiBold();
                                header.Cell().Text("Poltrona").SemiBold();
                                header.Cell().Text("Embarque").SemiBold();
                                header.Cell().Text("Status").SemiBold();
                            });

                            int rowIndex = 0;
                            foreach (DataRow row in dt.Rows)
                            {
                                string corFundo = (rowIndex % 2 == 0) ? Colors.White : Colors.Grey.Lighten4;

                                table.Cell().Background(corFundo).BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(4).Text(row["nome"].ToString());
                                table.Cell().Background(corFundo).BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(4).Text(row["cpf"].ToString());
                                table.Cell().Background(corFundo).BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(4).Text(row["telefone"].ToString());
                                table.Cell().Background(corFundo).BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(4).Text(row["poltrona"].ToString());
                                table.Cell().Background(corFundo).BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(4).Text(row["local_embarque"].ToString());
                                table.Cell().Background(corFundo).BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(4).Text(row["status_pagamento"].ToString());
                                rowIndex++;
                            }
                        });
                    });
                }).GeneratePdf(sfd.FileName);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = sfd.FileName, UseShellExecute = true });
            }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
        }

        private void GerarRecibo()
        {
            if (cboClienteRelatorio.SelectedIndex == -1 || cboViagemRelatorio.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Cliente e uma Viagem para gerar o recibo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF|*.pdf", FileName = $"Recibo_{cboClienteRelatorio.Text}.pdf" };
            if (sfd.ShowDialog() != DialogResult.OK) return;

            string caminhoLogo = @"C:\Users\silas.sbsilva\Downloads\Mídia.jpg";

            try
            {
                DataTable dt = new DataTable();
                using (MySqlConnection conn = new Conexao().Conectar())
                {
                    conn.Open();
                    // Atualizado: Puxando o valor_unitario como valor total da reserva
                    string sql = @"SELECT c.nome, r.data_vencimento AS data_inicio, 
                                          r.valor_unitario AS valor_total, 
                                          f.valor_parcela, f.num_parcela, f.data_pagamento, f.forma_pagamento 
                                   FROM financeiro f 
                                   INNER JOIN reserva r ON f.id_reserva = r.id_reserva 
                                   INNER JOIN cliente c ON r.id_cliente = c.id_cliente 
                                   WHERE r.id_cliente = @id_cliente AND r.id_viagem = @id_viagem 
                                   ORDER BY f.data_pagamento DESC LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id_cliente", cboClienteRelatorio.SelectedValue);
                    cmd.Parameters.AddWithValue("@id_viagem", cboViagemRelatorio.SelectedValue);
                    new MySqlDataAdapter(cmd).Fill(dt);
                }

                if (dt.Rows.Count == 0) { MessageBox.Show("Nenhum pagamento encontrado para este cliente nesta viagem."); return; }

                DataRow d = dt.Rows[0];

                string nome = d["nome"].ToString();
                string numParcela = d["num_parcela"] != DBNull.Value ? d["num_parcela"].ToString() : "-";
                decimal valorParcela = d["valor_parcela"] != DBNull.Value ? Convert.ToDecimal(d["valor_parcela"]) : 0;
                decimal valorTotal = d["valor_total"] != DBNull.Value ? Convert.ToDecimal(d["valor_total"]) : 0;

                string dataInicio = d["data_inicio"] != DBNull.Value ? Convert.ToDateTime(d["data_inicio"]).ToString("dd/MM/yyyy") : "Não informada";
                string dataPagamento = d["data_pagamento"] != DBNull.Value ? Convert.ToDateTime(d["data_pagamento"]).ToString("dd/MM/yyyy") : "Não informada";
                string formaPagamento = d["forma_pagamento"] != DBNull.Value ? d["forma_pagamento"].ToString() : "Não informada";

                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A5);
                        page.Margin(1, Unit.Centimetre);
                        page.Content().Column(col =>
                        {
                            if (File.Exists(caminhoLogo))
                                col.Item().AlignCenter()
                                   .Width(70)
                                   .Height(70)
                                   .CornerRadius(35)
                                   .Image(caminhoLogo, ImageScaling.Resize);

                            col.Item().AlignCenter().PaddingTop(5).Text("MANDECASTUR VIAGENS").FontSize(16).Black().FontColor("#2ecc71");
                            col.Item().PaddingTop(5).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);

                            col.Item().PaddingVertical(15).AlignCenter().Text($"RECIBO DE PAGAMENTO - Parcela {numParcela}").FontSize(14).SemiBold();

                            col.Item().Text(txt => { txt.Span("Recebemos de: ").SemiBold(); txt.Span(nome); });
                            col.Item().Text(txt => { txt.Span("A quantia de: ").SemiBold(); txt.Span(valorParcela.ToString("C2")).FontColor(Colors.Green.Darken2).SemiBold(); });
                            col.Item().Text(txt => { txt.Span("Referente à viagem: ").SemiBold(); txt.Span(cboViagemRelatorio.Text); });

                            // Adicionado: Valor total do pacote
                            col.Item().Text(txt => { txt.Span("Valor Total do Pacote: ").SemiBold(); txt.Span(valorTotal.ToString("C2")); });

                            col.Item().PaddingTop(10).Text($"Data de início: {dataInicio}");
                            col.Item().Text($"Data do pagamento atual: {dataPagamento}");
                            col.Item().Text($"Forma de Pagamento: {formaPagamento}");

                            col.Item().PaddingTop(40).AlignCenter().Text("_________________________________________");
                            col.Item().AlignCenter().Text("Assinatura Mandecastur").FontSize(10).FontColor(Colors.Grey.Darken1);
                        });
                    });
                }).GeneratePdf(sfd.FileName);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = sfd.FileName, UseShellExecute = true });
            }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
        }

        private void GerarCustos()
        {
            if (cboViagemRelatorio.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma Viagem para ver os custos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF|*.pdf", FileName = $"Custos_Viagem.pdf" };
            if (sfd.ShowDialog() != DialogResult.OK) return;

            string caminhoLogo = @"C:\Users\silas.sbsilva\Downloads\Mídia.jpg";

            try
            {
                DataTable dt = new DataTable();
                using (MySqlConnection conn = new Conexao().Conectar())
                {
                    conn.Open();
                    // Atualizado: Puxando também a soma das parcelas (receita) da viagem
                    string sql = @"SELECT destino, custo_transporte, custo_hospedagem, gastos_extras, observacoes_gastos, 
                                          (SELECT COALESCE(SUM(f.valor_parcela), 0) 
                                           FROM financeiro f 
                                           INNER JOIN reserva r ON f.id_reserva = r.id_reserva 
                                           WHERE r.id_viagem = @id) AS receita_total
                                   FROM viagem WHERE id_viagem = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", cboViagemRelatorio.SelectedValue);
                    new MySqlDataAdapter(cmd).Fill(dt);
                }

                if (dt.Rows.Count == 0) return;

                DataRow d = dt.Rows[0];

                decimal transporte = d["custo_transporte"] != DBNull.Value ? Convert.ToDecimal(d["custo_transporte"]) : 0;
                decimal hospedagem = d["custo_hospedagem"] != DBNull.Value ? Convert.ToDecimal(d["custo_hospedagem"]) : 0;
                decimal extras = d["gastos_extras"] != DBNull.Value ? Convert.ToDecimal(d["gastos_extras"]) : 0;
                decimal receitaTotal = d["receita_total"] != DBNull.Value ? Convert.ToDecimal(d["receita_total"]) : 0;

                decimal custoTotal = transporte + hospedagem + extras;
                decimal lucroLiquido = receitaTotal - custoTotal;

                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.A4);
                        page.Margin(2, Unit.Centimetre);

                        page.Header().Row(row =>
                        {
                            if (File.Exists(caminhoLogo))
                                row.ConstantItem(60)
                                   .Height(60)
                                   .CornerRadius(30)
                                   .Image(caminhoLogo, ImageScaling.Resize);

                            row.RelativeItem().PaddingLeft(15).AlignMiddle()
                               .Text($"Demonstrativo Financeiro: {d["destino"]}")
                               .FontSize(18).SemiBold().FontColor("#2ecc71");
                        });

                        page.Content().PaddingVertical(1, Unit.Centimetre).Column(col =>
                        {
                            col.Item().Text($"Custo de Transporte: {transporte:C2}");
                            col.Item().Text($"Custo de Hospedagem: {hospedagem:C2}");
                            col.Item().Text($"Gastos Extras: {extras:C2}");

                            col.Item().PaddingVertical(10).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);

                            // Atualizado: Bloco de resumo financeiro mostrando Receita, Custo e Lucro
                            col.Item().Background(Colors.Grey.Lighten4).Padding(10).Column(resumo =>
                            {
                                resumo.Item().Text(txt => { txt.Span("1. TOTAL ARRECADADO (RECEITA): ").SemiBold(); txt.Span(receitaTotal.ToString("C2")).FontColor(Colors.Green.Darken2).SemiBold(); });
                                resumo.Item().Text(txt => { txt.Span("2. CUSTO TOTAL DA VIAGEM: ").SemiBold(); txt.Span(custoTotal.ToString("C2")).FontColor(Colors.Red.Medium).SemiBold(); });
                                resumo.Item().PaddingTop(5).Text(txt =>
                                {
                                    txt.Span("LUCRO LÍQUIDO (1 - 2): ").SemiBold().FontSize(14);
                                    txt.Span(lucroLiquido.ToString("C2"))
                                       .SemiBold().FontSize(14)
                                       .FontColor(lucroLiquido >= 0 ? Colors.Blue.Darken2 : Colors.Red.Darken2);
                                });
                            });

                            col.Item().PaddingTop(20).Text("Observações de Custos:").SemiBold();
                            col.Item().Text(d["observacoes_gastos"] != DBNull.Value ? d["observacoes_gastos"].ToString() : "Nenhuma observação registrada.");
                        });
                    });
                }).GeneratePdf(sfd.FileName);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = sfd.FileName, UseShellExecute = true });
            }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
        }

        #endregion
    }
}