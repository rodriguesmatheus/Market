using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tela_principal
{
    class DAL
    {
        internal void Add(Construtor mo)
        {
            throw new NotImplementedException();
        }
        public void Adicionar(Construtor mo)
        {
            String caminhobd = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Market;Integrated Security=True;";
            try
            {
                SqlConnection con = new SqlConnection(caminhobd);
                con.Open();

                string Adicionar = "insert into Produtos(NomePro,CategoriaPro,FornecedorPro,PrecoFornPro,PrecoRevPro,QuantidadePro)" + "values ('" + mo.NomePro + "','" + mo.CategoriaPro + "','" + mo.FornecedorPro + "','" + mo.PrecoFornPro + "','" + mo.PrecoRevPro + "','" + mo.QuantidadePro + "')";
                SqlCommand command = new SqlCommand(Adicionar, con);
                SqlDataReader myreader;
                myreader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos " + ex.Message);
            }
        }

        internal void Altera(Construtor mo)
        {
            throw new NotImplementedException();
        }

        public void Alterar(Construtor mo)
        {
            String caminhobd = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Market;Integrated Security=True;";
            try
            {
                SqlConnection con = new SqlConnection(caminhobd);
                con.Open();

                string altera = "update Produtos set NomePro='" + mo.NomePro + "' ,CategoriaPro='" + mo.CategoriaPro + "',FornecedorPro='" + mo.FornecedorPro + "',PrecoFornPro='" + mo.PrecoFornPro + "',PrecoRevPro='" + mo.PrecoRevPro + "',QuantidadePro='" + mo.QuantidadePro + "' WHERE idProdutos='" + mo.idProduto + "';";
                SqlCommand command = new SqlCommand(altera, con);
                SqlDataReader myreader;
                myreader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos " + ex.Message);
            }
        }
        public void Excluir(Construtor mo)
        {
            String caminhobd = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Market;Integrated Security=True;";
            try
            {
                SqlConnection con = new SqlConnection(caminhobd);
                con.Open();

                string exclui = "DELETE FROM Produtos WHERE idProdutos='" + mo.idProduto + "';";
                SqlCommand command = new SqlCommand(exclui, con);
                SqlDataReader myreader;
                myreader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro de comandos " + ex.Message);
            }
        }

    }
}
