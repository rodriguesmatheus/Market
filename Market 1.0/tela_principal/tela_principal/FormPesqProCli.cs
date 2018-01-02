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
    public partial class FormPesqProCli : Form
    {
        public FormPesqProCli()
        {
            InitializeComponent();
        }

        private void tabPesquisa_Click(object sender, EventArgs e)
        {

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
                    string pesquisa = "SELECT idProdutos,NomePro,CategoriaPro,FornecedorPro,PrecoRevPro from Produtos where CategoriaPro like @valoraçougue and NomePro like @valoraçouguetexto";
                    SqlDataAdapter ad = new SqlDataAdapter(pesquisa, con);
                    ad.SelectCommand.Parameters.AddWithValue("valoraçougue", comPesqPro.Text + "%");
                    ad.SelectCommand.Parameters.AddWithValue("valoraçouguetexto", txtPesqPro.Text + "%");
                    DataTable table = new DataTable();
                    ad.Fill(table);
                    dataGridView1.DataSource = table;
                    con.Close();
                    break;
                case "Congelados":
                    string pesquisa2 = "SELECT idProdutos,NomePro,CategoriaPro,FornecedorPro,PrecoRevPro from Produtos where CategoriaPro like @valorcongelados and NomePro like @valorcongeladostxt";
                    SqlDataAdapter ad1 = new SqlDataAdapter(pesquisa2, con);
                    ad1.SelectCommand.Parameters.AddWithValue("valorcongelados", comPesqPro.Text + "%");
                    ad1.SelectCommand.Parameters.AddWithValue("valorcongeladostxt", txtPesqPro.Text + "%");
                    DataTable table1 = new DataTable();
                    ad1.Fill(table1);
                    dataGridView1.DataSource = table1;
                    con.Close();
                    break;
                case "Mercearia":
                    string pesquisa3 = "SELECT idProdutos,NomePro,CategoriaPro,FornecedorPro,PrecoRevPro from Produtos where CategoriaPro like @valormercearia and NomePro like @valormerceariatxt";
                    SqlDataAdapter ad2 = new SqlDataAdapter(pesquisa3, con);
                    ad2.SelectCommand.Parameters.AddWithValue("valormercearia", comPesqPro.Text + "%");
                    ad2.SelectCommand.Parameters.AddWithValue("valormerceariatxt", txtPesqPro.Text + "%");
                    DataTable table2 = new DataTable();
                    ad2.Fill(table2);
                    dataGridView1.DataSource = table2;
                    con.Close();
                    break;
                case "Bebidas":
                    string pesquisa4 = "SELECT idProdutos,NomePro,CategoriaPro,FornecedorPro,PrecoRevPro from Produtos where CategoriaPro like @valorbebidas and NomePro like @valorbebidastxt";
                    SqlDataAdapter ad3 = new SqlDataAdapter(pesquisa4, con);
                    ad3.SelectCommand.Parameters.AddWithValue("valorbebidas", comPesqPro.Text + "%");
                    ad3.SelectCommand.Parameters.AddWithValue("valorbebidastxt", txtPesqPro.Text + "%");
                    DataTable table3 = new DataTable();
                    ad3.Fill(table3);
                    dataGridView1.DataSource = table3;
                    con.Close();
                    break;
                case "Hortifruti":
                    string pesquisa5 = "SELECT idProdutos,NomePro,CategoriaPro,FornecedorPro,PrecoRevPro from Produtos where CategoriaPro like @valorhorti and NomePro like @valorhortitxt";
                    SqlDataAdapter ad4 = new SqlDataAdapter(pesquisa5, con);
                    ad4.SelectCommand.Parameters.AddWithValue("valorhorti", comPesqPro.Text + txtPesqPro.Text + "%");
                    ad4.SelectCommand.Parameters.AddWithValue("valorhortitxt", txtPesqPro.Text + "%");
                    DataTable table4 = new DataTable();
                    ad4.Fill(table4);
                    dataGridView1.DataSource = table4;
                    con.Close();
                    break;
                case "Limpeza":
                    string pesquisa6 = "SELECT idProdutos,NomePro,CategoriaPro,FornecedorPro,PrecoRevPro from Produtos where CategoriaPro like @valorlimpeza and NomePro like @valorlimpezatxt";
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
            usuario principal = new usuario();
            principal.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoPro.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNomePro.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comCategoriaPro.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtFornecedorPro.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPreRevPro.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tabPesq.SelectedIndex = 1;
            txtNomePro.Focus();
        }

        private void btnAdicionarCar_Click(object sender, EventArgs e)
        {
            if ((txtCodigoPro.Text == "") || (txtNomePro.Text == "") || (comCategoriaPro.Text == "") || (txtFornecedorPro.Text == "") || (txtPreRevPro.Text == ""))
            {
                MessageBox.Show("Selecione um item na tela de pesquisa para adicionar ao carrinho!");
            }
            else
            {
                MessageBox.Show("Item adicionado ao carrinho!");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            usuario tab1 = new usuario();
            tab1.Show();
            this.Hide();
        }

        private void FormPesqProCli_FormClosed(object sender, FormClosedEventArgs e)
        {
            usuario pro = new usuario();
            pro.Show();
            this.Hide();
        }
    }
}