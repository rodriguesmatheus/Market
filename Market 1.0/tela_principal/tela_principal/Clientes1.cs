using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tela_principal;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using tela_principal;

namespace tela_principal
{
    class Clientes1
    {
        private int id;
        private string nome;
        private string sobrenome;
        private string email;
        private string senha;
        private string cpf;
        private string dataNascimento;
        private string telefone;
        private string endereco;
        private int numero;
        private string complemento;
        private string bairro;
        private string cep;
        private string estado;
        private string cidade;

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string CPF { get; set; }
        public string DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }

    }
}