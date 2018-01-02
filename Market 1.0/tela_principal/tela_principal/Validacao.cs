using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tela_principal
{
    class Validacao   
    {
<<<<<<< HEAD
        // é o ultimo teste que vou fazer
        //teste
        //testnovo
=======
>>>>>>> 942a3a98aa2e5200f9fbcfdd663e740686b54602
        cadastrocliente formCadastroCliente = new cadastrocliente();
        formAlterarCliente formAlterarCliente = new formAlterarCliente();

        public bool ValidarSenha(string senha1, string senha2) //recebe senha e confirmação de senha para validar se estão iguais
        {
            if (senha1 == senha2)
                return true;
            else
                return false;
        }
    }
}
