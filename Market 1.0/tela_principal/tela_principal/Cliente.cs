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
    public partial class formAlterarCliente : Form
    {
        public formAlterarCliente()
        {
            InitializeComponent();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrocliente form1 = new cadastrocliente();
            this.Hide();
            form1.Show();
        }



        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string caminhobd = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Market_bdo;Integrated Security=True;"; //salva na variável os dados do BD

            SqlConnection conexao = new SqlConnection(caminhobd); //Cria uma variável de conexão com o BD

            conexao.Open(); //Abre a conexão 

            string op = Convert.ToString(cbFiltro.SelectedItem);  // Cria a variável OP para armazenar o Filtro selecionado na tela

            switch (op)      // Feito um switch com um select pra cada filtro
            {
                case "Nome": // caso o filtro selecionado seja por nome

                    string SELECT = "select" +
                                        " Id," +
                                        " Nome," +
                                        " Sobrenome," +
                                        " Email," +
                                        " Senha," +
                                        " CPF," +
                                        " DataNascimento," +
                                        " Telefone," +
                                        " Endereco," +
                                        " Numero," +
                                        " Complemento," +
                                        " Bairro," +
                                        " CEP," +
                                        " Estado," +
                                        " Cidade" +
                        " from Clientes where Nome like @valor";

                    SqlDataAdapter ad = new SqlDataAdapter(SELECT, conexao); //executa o select
                    ad.SelectCommand.Parameters.AddWithValue("valor", txtPesquisar.Text + "%"); //passa o valor do campo para o select
                    DataTable table = new DataTable(); //cria uma table
                    ad.Fill(table); // preenche a table com os dados do SELECT
                    dataGridView1.DataSource = table; // preenche o Grid View com a table que esta com os dados do select salvo
                    conexao.Close(); //fecha a conexão com o banco de dados
                    break;

                case "Código": // caso o filtro selecionado seja por código
                    string SELECT2 = "select" +
                                        " Id," +
                                        " Nome," +
                                        " Sobrenome," +
                                        " Email," +
                                        " Senha," +
                                        " CPF," +
                                        " DataNascimento," +
                                        " Telefone," +
                                        " Endereco," +
                                        " Numero," +
                                        " Complemento," +
                                        " Bairro," +
                                        " CEP," +
                                        " Estado," +
                                        " Cidade" +
                        " from Clientes where Id like @valor";

                    SqlDataAdapter ad2 = new SqlDataAdapter(SELECT2, conexao); //executa o select
                    ad2.SelectCommand.Parameters.AddWithValue("valor", txtPesquisar.Text + "%"); //passa o valor do campo para o select
                    DataTable table2 = new DataTable(); //cria uma table
                    ad2.Fill(table2); // preenche a table com os dados do SELECT
                    dataGridView1.DataSource = table2; // preenche o Grid View com a table que esta com os dados do select salvo
                    conexao.Close(); //fecha a conexão com o banco de dados
                    break;

                case "Todos": // caso o filtro selecionado seja por Todos

                    string SELECT3 = "select * from Clientes";
                    SqlDataAdapter ad3 = new SqlDataAdapter(SELECT3, conexao); //executa o select

                    DataTable table3 = new DataTable(); //cria uma table
                    ad3.Fill(table3); // preenche a table com os dados do SELECT
                    dataGridView1.DataSource = table3; // preenche o Grid View com a table que esta com os dados do select salvo
                    conexao.Close(); //fecha a conexão com o banco de dados
                    break;
            }
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSobrenome.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSenha.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtConfirmarSenha.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtCPF.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtDataNascimento.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtTelefone.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtEndereco.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtNumero.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtComplemento.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtBairro.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtCEP.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtEstado.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtCidade.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            tabControl1.SelectedIndex = 1;
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validacao val = new Validacao();
            Clientes1 cliente = new Clientes1();
            DAO dao = new DAO();
            try
            {
                if (val.ValidarSenha(txtSenha.Text, txtConfirmarSenha.Text))
                {
                    cliente.Id = Convert.ToInt16(txtCodigo.Text);
                    cliente.Nome = txtNome.Text;
                    cliente.Sobrenome = txtSobrenome.Text;
                    cliente.Email = txtEmail.Text;
                    cliente.Senha = txtSenha.Text;
                    cliente.CPF = txtCPF.Text;
                    cliente.DataNascimento = txtDataNascimento.Text;
                    cliente.Telefone = txtTelefone.Text;
                    cliente.Endereco = txtEndereco.Text;
                    cliente.Numero = Convert.ToInt32(txtNumero.Text);
                    cliente.Complemento = txtComplemento.Text;
                    cliente.Bairro = txtBairro.Text;
                    cliente.CEP = txtCEP.Text;
                    cliente.Estado = txtEstado.Text;
                    cliente.Cidade = txtCidade.Text;


                    dao.UPDATE(cliente);

                    MessageBox.Show("Cliente alterado com sucesso !");

                    Limpar();
                    tabControl1.SelectedIndex = 0;
                    btnPesquisar.PerformClick();
                }
                else
                {
                    MessageBox.Show("Por favor, certifique-se que suas senhas coincidem.");
                    txtSenha.Clear();
                    txtConfirmarSenha.Clear();
                    txtSenha.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Todos os dados deste cliente serão excluidos, deseja realmente continuar ? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Clientes1 cliente = new Clientes1();
                DAO dao = new DAO();

                cliente.Id = Convert.ToInt16(txtCodigo.Text);

                dao.DELETE(cliente);

                MessageBox.Show("Cliente excluido com sucesso !");

                Limpar();

                tabControl1.SelectedIndex = 0;

                btnPesquisar.PerformClick();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();

            tabControl1.SelectedIndex = 0;
        }

        private void Limpar()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtSobrenome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtCPF.Clear();
            txtDataNascimento.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCEP.Clear();
            txtEstado.SelectedIndex = 0;
            txtCidade.Clear();
            txtConfirmarSenha.Clear();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Desbloquear();
        }

        private void Bloquear()
        {
            txtNome.ReadOnly = true;
            txtSobrenome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtSenha.ReadOnly = true;
            txtCPF.ReadOnly = true;
            txtDataNascimento.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtNumero.ReadOnly = true;
            txtComplemento.ReadOnly = true;
            txtBairro.ReadOnly = true;
            txtCEP.ReadOnly = true;
            txtEstado.Enabled = false;
            txtCidade.ReadOnly = true;
            txtConfirmarSenha.ReadOnly = true;
        }

        private void Desbloquear()
        {
            txtNome.ReadOnly = false;
            txtSobrenome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtSenha.ReadOnly = false;
            txtCPF.ReadOnly = false;
            txtDataNascimento.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtComplemento.ReadOnly = false;
            txtBairro.ReadOnly = false;
            txtCEP.ReadOnly = false;
            txtEstado.Enabled = true;
            txtCidade.ReadOnly = false;
            txtConfirmarSenha.ReadOnly = false;
        }

        private void txtDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '/'))
            {
                e.Handled = true;
            }
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bloquear();
        }

        private void formAlterarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home hom = new Home();
            hom.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void formAlterarCliente_Load(object sender, EventArgs e)
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