using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tela_principal
{
    class Validacao
   
        //teste do guizinho monstrao melhoor do mundo
    {
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
