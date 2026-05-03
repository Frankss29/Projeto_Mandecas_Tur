using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Login.UseControls
{
    public partial class UC_Financeiro : UserControl
    {
        public UC_Financeiro()
        {
            InitializeComponent();
        }

        private void ArredondarPainel(Panel panel, int radius, Color corFundo)
        {
            panel.Paint += (s, e) =>
             {
                 Graphics g = e.Graphics;
                 g.SmoothingMode = SmoothingMode.AntiAlias;

                 Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
                 GraphicsPath path = new GraphicsPath();

                 path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                 path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
                 path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
                 path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
                 path.CloseAllFigures();

                 using (SolidBrush brush = new SolidBrush(corFundo))
                 {
                     g.FillPath(brush, path);
                 }

                 panel.Region = new Region(path);
             };
        }

        private void UC_Financeiro_Load(object sender, EventArgs e)
        {

            ArredondarPainel(Panel_Entrada, 20, Color.FromArgb(67, 184, 119));      // Verde
            ArredondarPainel(Panel_Pendentes, 20, Color.FromArgb(255, 193, 7));     // Amarelo
            ArredondarPainel(Panel_Vencidos, 20, Color.FromArgb(255, 87, 34)); // Vermelho

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
