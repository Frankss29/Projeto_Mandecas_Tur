using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.UseControls
{
    public partial class UC_GestaoClientes : UserControl
    {
        public UC_GestaoClientes()
        {
            InitializeComponent();

            // 1. Configurações Visuais para ficar igual ao seu desenho
            dgvClientes.RowsDefaultCellStyle.BackColor = Color.White;
            dgvClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245); // Cinza clarinho
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.RowHeadersVisible = false; // Tira a setinha da esquerda

            // 2. Adicionando dados "fakes" para teste de layout
            dgvClientes.Rows.Add("CL084", "João Silva", "123.456.789-00", "(11) 98564-8871", "joaosilva12@gmail.com");
            dgvClientes.Rows.Add("CL077", "Maria Souza", "987.654.321-00", "(11) 92715-8941", "mariasouza15@gmail.com");
            dgvClientes.Rows.Add("CL035", "Carlos Lima", "456.123.789-01", "(11) 98080-9437", "limascarlos@gmail.com");

        }
    }
}
