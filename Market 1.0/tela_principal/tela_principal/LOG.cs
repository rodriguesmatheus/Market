using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace tela_principal
{
    class LOG
    {
        public void SELECT(Clientes1 cliente)
        {
            try
            {
                string caminhobd = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog= Market_bdo;Integrated Security=True;";
                SqlConnection conexao = new SqlConnection(caminhobd);
                string SELECT = "select CPF, Senha from Clientes where CPF =@CPF and Senha =@Senha";
                                    
                conexao.Open();
                var cmd = new SqlCommand(SELECT, conexao);

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
