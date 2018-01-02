using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tela_principal
{
    public partial class FormConfigpro : Form
    {
        public FormConfigpro()
        {
            InitializeComponent();
        }

        private void btnAlterarPro_Click(object sender, EventArgs e)
        {
            if ((txtCodigoPro.Text == "") || (txtNomePro.Text == "") || (comCategoriaPro.Text == "") || (txtFornecedorPro.Text == "") || (txtPreForPro.Text == "") || (txtPreRevPro.Text == "") || (txtQuantPro.Text == ""))
            {
                MessageBox.Show("Selecione um item na tela de pesquisa para alterar!");
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
                mo.QuantidadePro = Convert.ToString(txtQuantPro.Text);

                if (MessageBox.Show("Você realmente deseja ALTERAR este item?", "Sim", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    da.Alterar(mo);
                    txtCodigoPro.Text = "";
                    txtNomePro.Text = "";
                    comCategoriaPro.Text = "";
                    txtFornecedorPro.Text = "";
                    txtPreForPro.Text = "";
                    txtPreRevPro.Text = "";
                    txtQuantPro.Text = "";
                    MessageBox.Show("Produto alterado com sucesso");
                }
            }
        }

        private void btnPesqPro_Click(object sender, EventArgs e)
        {
            string caminhodb = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Market_bdo;Integrated Security=True;";
            SqlConnection con = new SqlConnection(caminhodb);
            con.Open();//abrir banco
            String op = (String)comPesqPro.SelectedItem;
            switch (op)
            {
                case "Todos":
                    string selecione = "SELECT * from Produtos where NomePro like @valortodostexto";
                    SqlDataAdapter ads = new SqlDataAdapter(selecione, con);
                    ads.SelectCommand.Parameters.AddWithValue("valortodostexto", txtPesqPro.Text + "%");
                    DataTable tables = new DataTable();
                    ads.Fill(tables);
                    dataGridView1.DataSource = tables;
                    con.Close();
                    break;
                case "Açougue":
                    string pesquisa = "SELECT idProdutos,NomePro,CategoriaPro,FornecedorPro,PrecoFornPro,PrecoRevPro,QuantidadePro from Produtos where CategoriaPro like @valoraçougue and NomePro like @valoraçouguetexto";
                    SqlDataAdapter ad = new SqlDataAdapter(pesquisa, con);
                    ad.SelectCommand.Parameters.AddWithValue("valoraçougue", comPesqPro.Text + "%");
                    ad.SelectCommand.Parameters.AddWithValue("valoraçouguetexto", txtPesqPro.Text + "%");
                    DataTable table = new DataTable();
                    ad.Fill(table);
                    dataGridView1.DataSource = table;
                    con.Close();
                    break;
                case "Congelados":
                    string pesquisa2 = "SELECT idProdutos,NomePro,CategoriaPro,FornecedorPro,PrecoFornPro,PrecoRevPro,QuantidadePro from Produtos where CategoriaPro like @valorcongelados and NomePro like @valorcongeladostxt";
                    SqlDataAdapter ad1 = new SqlDataAdapter(pesquisa2, con);
                    ad1.SelectCommand.Parameters.AddWithValue("valorcongelados", comPesqPro.Text + "%");
                    ad1.SelectCommand.Parameters.AddWithValue("valorcongeladostxt", txtPesqPro.Text + "%");
                    DataTable table1 = new DataTable();
                    ad1.Fill(table1);
                    dataGridView1.DataSource = table1;
                    con.Close();
                    break;
                case "Mercearia":
                    string pesquisa3 = "SELECT idProdutos,NomePro,CategoriaPro,FornecedorPro,PrecoFornPro,PrecoRevPro,QuantidadePro from Produtos where CategoriaPro like @valormercearia and NomePro like @valormerceariatxt";
                    SqlDataAdapter ad2 = new SqlDataAdapter(pesquisa3, con);
                    ad2.SelectCommand.Parameters.AddWithValue("valormercearia", comPesqPro.Text + "%");
                    ad2.SelectCommand.Parameters.AddWithValue("valormerceariatxt", txtPesqPro.Text + "%");
                    DataTable table2 = new DataTable();
                    ad2.Fill(table2);
                    dataGridView1.DataSource = table2;
                    con.Close();
                    break;
                case "Bebidas":
                    string pesquisa4 = "SELECT idProdutos,NomePro,CategoriaPro,FornecedorPro,PrecoFornPro,PrecoRevPro,QuantidadePro from Produtos where CategoriaPro like @valorbebidas and NomePro like @valorbebidastxt";
                    SqlDataAdapter ad3 = new SqlDataAdapter(pesquisa4, con);
                    ad3.SelectCommand.Parameters.AddWithValue("valorbebidas", comPesqPro.Text + "%");
                    ad3.SelectCommand.Parameters.AddWithValue("valorbebidastxt", txtPesqPro.Text + "%");
                    DataTable table3 = new DataTable();
                    ad3.Fill(table3);
                    dataGridView1.DataSource = table3;
                    con.Close();
                    break;
                case "Hortifruti":
                    string pesquisa5 = "SELECT idProdutos,NomePro,CategoriaPro,FornecedorPro,PrecoFornPro,PrecoRevPro,QuantidadePro from Produtos where CategoriaPro like @valorhorti and NomePro like @valorhortitxt";
                    SqlDataAdapter ad4 = new SqlDataAdapter(pesquisa5, con);
                    ad4.SelectCommand.Parameters.AddWithValue("valorhorti", comPesqPro.Text + txtPesqPro.Text + "%");
                    ad4.SelectCommand.Parameters.AddWithValue("valorhortitxt", txtPesqPro.Text + "%");
                    DataTable table4 = new DataTable();
                    ad4.Fill(table4);
                    dataGridView1.DataSource = table4;
                    con.Close();
                    break;
                case "Limpeza":
                    string pesquisa6 = "SELECT idProdutos,NomePro,CategoriaPro,FornecedorPro,PrecoFornPro,PrecoRevPro,QuantidadePro from Produtos where CategoriaPro like @valorlimpeza and NomePro like @valorlimpezatxt";
                    SqlDataAdapter ad5 = new SqlDataAdapter(pesquisa6, con);
                    ad5.SelectCommand.Parameters.AddWithValue("valorlimpeza", comPesqPro.Text + "%");
                    ad5.SelectCommand.Parameters.AddWithValue("valorlimpezatxt", txtPesqPro.Text + "%");
                    DataTable table5 = new DataTable();
                    ad5.Fill(table5);
                    dataGridView1.DataSource = table5;
                    con.Close();
                    break;
            }
            dataGridView1.ReadOnly = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Produto principal = new Produto();
            principal.Show();
            this.Hide();
        }

        private void comPesqPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoPro.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNomePro.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comCategoriaPro.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtFornecedorPro.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPreForPro.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPreRevPro.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtQuantPro.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tabControl1.SelectedIndex = 1;
            txtNomePro.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto principal = new Produto();
            principal.Show();
            this.Hide();
        }

        private void btnExcluirPro_Click(object sender, EventArgs e)
        {
            if ((txtCodigoPro.Text == "") || (txtNomePro.Text == "") || (comCategoriaPro.Text == "") || (txtFornecedorPro.Text == "") || (txtPreForPro.Text == "") || (txtPreRevPro.Text == "") || (txtQuantPro.Text == ""))
            {
                MessageBox.Show("Selecione um item na tela de pesquisa para excluir!");
            }
            else
            {
                Construtor mo = new Construtor();
                DAL da = new DAL();
                mo.idProduto = Convert.ToInt16(txtCodigoPro.Text);
                mo.NomePro = txtNomePro.Text;
                mo.CategoriaPro = comCategoriaPro.Text;
                mo.FornecedorPro = txtFornecedorPro.Text;
                mo.PrecoFornPro = txtPreForPro.Text;
                mo.PrecoRevPro = txtPreRevPro.Text;
                mo.QuantidadePro = txtQuantPro.Text;

                if (MessageBox.Show("Você realmente deseja EXCLUIR este item?", "Sim", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    da.Excluir(mo);
                    txtCodigoPro.Text = "";
                    txtNomePro.Text = "";
                    comCategoriaPro.Text = "";
                    txtFornecedorPro.Text = "";
                    txtPreForPro.Text = "";
                    txtPreRevPro.Text = "";
                    txtQuantPro.Text = "";
                    MessageBox.Show("Excluido com sucesso!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((txtCodigoPro.Text == "") || (txtNomePro.Text == "") || (comCategoriaPro.Text == "") || (txtFornecedorPro.Text == "") || (txtPreForPro.Text == "") || (txtPreRevPro.Text == "") || (txtQuantPro.Text == ""))
            {
                MessageBox.Show("Selecione um item na tela de pesquisa para alterar!");
            }
            else
            {
                txtNomePro.Enabled = true;
                txtFornecedorPro.Enabled = true;
                comCategoriaPro.Enabled = true;
                txtPreRevPro.Enabled = true;
                txtPreForPro.Enabled = true;
                txtQuantPro.Enabled = true;
            }

        }

        private void txtPreForPro_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bloquear();
        }
        private void Bloquear()
        {
            txtNomePro.Enabled = false;
            txtFornecedorPro.Enabled = false;
            comCategoriaPro.Enabled = false;
            txtPreRevPro.Enabled = false;
            txtPreForPro.Enabled = false;
            txtQuantPro.Enabled = false;
        }

        private void txtQuantPro_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesqPro_TextChanged(object sender, EventArgs e)
        {

        }

        private void comPesqPro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormConfigpro_Load(object sender, EventArgs e)
        {

        }
    }
}
