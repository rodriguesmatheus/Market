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
using System.Data.SqlTypes;
using tela_principal;




namespace tela_principal
{
    public  partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //botao de login com o if e else basico pra teste
        {
            string caminhodb = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog= Market_bdo;Integrated Security=True;";
            SqlConnection cn = new SqlConnection(caminhodb);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Clientes WHERE CPF =@CPF and Senha = @Senha", cn);
            cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = textBox2.Text;
           
            cn.Open();
            SqlDataReader my;
            my = cmd.ExecuteReader();
            if (my.Read())
            {
                usuario usu= new usuario();
                usu.Show();
                this.Hide();
            }
            else if ((textBox1.Text == "admin") && (textBox2.Text == "admin"))
            {
                Home hom = new Home();
                hom.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Senha ou Usuario incorretos, tente novamente", "Erro!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                       
        }
          
    



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //quando clicar no cadastrar vai levar pra janela de cadastro
        {
            cadastrocliente cli = new cadastrocliente();
            cli.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
