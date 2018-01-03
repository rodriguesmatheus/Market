using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tela_principal
{
    public partial class cadastrofornecedor : Form
    {
        public cadastrofornecedor()
        {
            InitializeComponent();
        }

        private void cadastrofornecedor_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home hom = new Home();
            hom.Show();
            this.Hide();
        }
    }
}
