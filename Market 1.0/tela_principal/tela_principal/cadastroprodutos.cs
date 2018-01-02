using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace tela_principal
{
    public partial class FormCadastroPro : Form
    {
        public FormCadastroPro()
        {
            InitializeComponent();
        }

        private void btnLimparPro_Click(object sender, EventArgs e)
        {
            txtNomePro.Clear();
            comCategoriaPro.Text = "Selecione";
            txtFornecedorPro.Clear();
            txtPreForPro.Text = "00.00";
            txtPreRevPro.Text = "00.00";
            txtQuantPro.Clear();
        }

        private void btnAdicionarPro_Click(object sender, EventArgs e)
        {
            if ((txtNomePro.Text == "") || (comCategoriaPro.Text == "") || (txtFornecedorPro.Text == "") || (txtPreForPro.Text == "") || (txtPreRevPro.Text == "") || (txtQuantPro.Text == ""))
            {
                MessageBox.Show("Preencha TODOS os campos!");
            }
            else
            {
                Construtor mo = new Construtor();
                DAL da = new DAL();
                mo.NomePro = Convert.ToString(txtNomePro.Text);
                mo.CategoriaPro = Convert.ToString(comCategoriaPro.Text);
                mo.FornecedorPro = Convert.ToString(txtFornecedorPro.Text);
                Decimal.Parse(mo.PrecoFornPro = Convert.ToString(txtPreForPro.Text));
                Decimal.Parse(mo.PrecoRevPro = Convert.ToString(txtPreRevPro.Text));
                Convert.ToInt16(mo.QuantidadePro = Convert.ToString(txtQuantPro.Text));

                da.Adicionar(mo);
                MessageBox.Show("Produto cadastrado com sucesso");
            }
        }

        private void btnVoltarPro_Click(object sender, EventArgs e)
        {
            Produto principal = new Produto();
            principal.Show();
            this.Hide();
        }

        private void txtQuantPro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comCategoriaPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FormCadastroPro_Load(object sender, EventArgs e)
        {

        }

        private void comCategoriaPro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastroPro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Produto pro = new Produto();
            pro.Show();
            this.Hide();
        }
    }
}


