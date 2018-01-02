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
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
        }

        private void btnAdicionarPro_Click(object sender, EventArgs e)
        {
            FormCadastroPro cadastropro = new FormCadastroPro();
            cadastropro.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
                Home hom = new Home();
                hom.Show();
                this.Hide();
        }

        private void btnPesqPro_Click(object sender, EventArgs e)
        {
            
            FormConfigpro config = new FormConfigpro();
            config.Show();
            this.Hide();
        }

        private void btnPesqProCli_Click(object sender, EventArgs e)
        {
            
            FormPesqProCli pesqcli = new FormPesqProCli();
            pesqcli.Show();
            this.Hide();
        }

        private void FormMarketPrincipal_Load(object sender, EventArgs e)
        {

        }

       
    }
}