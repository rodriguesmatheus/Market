using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tela_principal
{
    class Validacao   
    {

        cadastrocliente formCadastroCliente = new cadastrocliente();
        formAlterarCliente formAlterarCliente = new formAlterarCliente();

        public string ValidarCamposPessoais(string nome, string sobrenome, string email, string cpf, string dataNascimento, string senha1, string senha2) //recebe senha e confirmação de senha para validar se estão iguais
        {
            if (nome != "")
                if(sobrenome != "")
                    if(email != "")
                        if(cpf != "")
                            if(dataNascimento != "" && dataNascimento != "DD/MM/AAAA")
                                if(senha1 != "")
                                    if(senha1 == senha2)
                                    {
                                        return "";
                                    }
                                    else
                                        return "Por favor, os campos 'Senha' e 'Confirmar Senha' não coincidem.";
                                else
                                    return "Por favor, preencha o campo 'Senha'.";
                            else
                                return "Por favor, preencha o campo 'Data de Nascimento' corretamente.";
                        else
                            return "Por favor, preencha o campo 'CPF'.";
                    else
                        return "Por favor, preencha o campo 'E-mail'.";
                else
                    return "Por favor, preencha o campo 'Sobrenome'.";
            else
                return "Por favor, preencha o campo 'Nome'.";
        }

        public string ValidarCamposEndereco(string endereco, string numero, string bairro, string cep, string estado, string cidade)
        {
            if (endereco != "")
                if (numero != "")
                    if (bairro != "")
                        if (cep != "")
                            if (estado != "")
                                if (cidade != "")
                                    {
                                        return "";
                                    }
                                else
                                    return "Por favor, preencha o campo 'Cidade'.";
                            else
                                return "Por favor, preencha o campo 'Estado'.";
                        else
                            return "Por favor, preencha o campo 'CEP'.";
                    else
                        return "Por favor, preencha o campo 'Bairro'.";
                else
                    return "Por favor, preencha o campo 'Número'.";
            else
                return "Por favor, preencha o campo 'Endereço'.";
        }
    }
}
