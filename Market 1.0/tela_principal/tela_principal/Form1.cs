using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tela_principal;


namespace tela_principal

{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Produto_Click(object sender, EventArgs e)
        {
            Produto Pro = new Produto();
            Pro.Show();
            this.Hide();
            
            
        }

        private void Cliente_Click(object sender, EventArgs e)
        {
             formAlterarCliente Cli = new formAlterarCliente();
            Cli.Show();
                       
            this.Hide();
            
         
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadastrofornecedor cf = new cadastrofornecedor();
            cf.Show();
            this.Hide();
        }
    }
}
