namespace Login
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLoginLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLoginLogin.BackColor = Color.FromArgb(36, 100, 46);
        }

        private void btnLoginLogin_MouseLeave(object sender, EventArgs e)
        {
           btnLoginLogin.BackColor = Color.FromArgb(14,46,19);
        }
    
    }
}
