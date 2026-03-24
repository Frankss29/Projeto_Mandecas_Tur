using Login.UseControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            UC_GestaoClientes uc = new UC_GestaoClientes();
            addUserControl(uc);

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pnlUserName_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnGestaoClientes_Click(object sender, EventArgs e)
        {
            UC_GestaoClientes Home = new UC_GestaoClientes();
            addUserControl(Home);

        }

        private void btnGestaoViagens_Click(object sender, EventArgs e)
        {
            UC_GestaoViagens Viagem = new UC_GestaoViagens();
            addUserControl(Viagem);
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            UC_Financeiro Financeiro = new UC_Financeiro();
            addUserControl(Financeiro);

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            UC_Relatorio Relatorio = new UC_Relatorio();
            addUserControl(Relatorio);
        }
    }
}
