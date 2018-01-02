
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace tela_principal
{
    class DAO
    {
        string caminhobd = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Market_bdo;Integrated Security=True;"; //salva na variável os dados do BD

        public void INSERT(Clientes1 cliente)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(caminhobd);

                string INSERT = "insert into Clientes (Nome, " +
                                                   "Sobrenome, " +
                                                   "Email, " +
                                                   "Senha, " +
                                                   "CPF, " +
                                                   "DataNascimento, " +
                                                   "Telefone, " +
                                                   "Endereco, " +
                                                   "Numero, " +
                                                   "Complemento, " +
                                                   "Bairro, " +
                                                   "CEP, " +
                                                   "Estado, " +
                                                   "Cidade) " +
                                            "values ('" + cliente.Nome +
                                            "','" + cliente.Sobrenome +
                                            "','" + cliente.Email +
                                            "','" + cliente.Senha +
                                            "','" + cliente.CPF +
                                            "','" + cliente.DataNascimento +
                                            "','" + cliente.Telefone +
                                            "','" + cliente.Endereco +
                                            "','" + cliente.Numero +
                                            "','" + cliente.Complemento +
                                            "','" + cliente.Bairro +
                                            "','" + cliente.CEP +
                                            "','" + cliente.Estado +
                                            "','" + cliente.Cidade +
                                            "')";

                conexao.Open();

                var cmd = new SqlCommand(INSERT, conexao);

                SqlDataReader myreader;

                myreader = cmd.ExecuteReader();

                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos " + ex.Message);
            }
        }

        public void UPDATE(Clientes1 cliente)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(caminhobd); //Cria uma variável de conexão com o BD

                conexao.Open(); //Abre a conexão 

                string UPDATE = "update Clientes set Nome = '" + cliente.Nome +
                                                "', Sobrenome = '" + cliente.Sobrenome +
                                                "', Email = '" + cliente.Email +
                                                "', Senha = '" + cliente.Senha +
                                                "', CPF = '" + cliente.CPF +
                                                "', DataNascimento = '" + cliente.DataNascimento +
                                                "', Telefone = '" + cliente.Telefone +
                                                "', Endereco = '" + cliente.Endereco +
                                                "', Numero = '" + cliente.Numero +
                                                "', Complemento ='" + cliente.Complemento +
                                                "', Bairro = '" + cliente.Bairro +
                                                "', CEP = '" + cliente.CEP +
                                                "', Estado = '" + cliente.Estado +
                                                "', Cidade = '" + cliente.Cidade +
                                                "' where Id = '" + cliente.Id + "';";

                SqlCommand cmd = new SqlCommand(UPDATE, conexao);
                SqlDataReader myreader;
                myreader = cmd.ExecuteReader();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos " + ex.Message);
            }
        }

        public void DELETE(Clientes1 cliente)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(caminhobd); //Cria uma variável de conexão com o BD

                conexao.Open(); //Abre a conexão 

                string DELETE = "delete from Clientes where Id = '" + cliente.Id + "';";

                SqlCommand cmd = new SqlCommand(DELETE, conexao);
                SqlDataReader myreader;
                myreader = cmd.ExecuteReader();
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos " + ex.Message);
            }
        }

    }
}