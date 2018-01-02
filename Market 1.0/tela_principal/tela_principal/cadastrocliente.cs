using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tela_principal
{
    public partial class cadastrocliente : Form
    {
        
            public cadastrocliente()
            {
                InitializeComponent();
            }

            private void btnCancelar_Click(object sender, EventArgs e)
            {
                if ((MessageBox.Show("Deseja cancelar o cadastro ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
                {
                    this.Close();
                }
            }


            private void btnSalvar_Click(object sender, EventArgs e)
            {

                Validacao val = new Validacao();
                Login log = new Login();
                Clientes1 cliente = new Clientes1();
                DAO dao = new DAO();
                try
                {
                    if (val.ValidarSenha(txtSenha.Text, txtConfirmarSenha.Text))
                    {
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

                        dao.INSERT(cliente);
                        MessageBox.Show("Cliente cadastrado com sucesso !");
                        log.Show();
                        this.Hide();
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

            private void Limpar()
            {
                txtNome.Clear();
                txtSobrenome.Clear();
                txtEmail.Clear();
                txtSenha.Clear();
                txtCPF.Clear();
                txtDataNascimento.Text = "DD/MM/AAAA";
                txtTelefone.Clear();
                txtEndereco.Clear();
                txtNumero.Clear();
                txtComplemento.Clear();
                txtBairro.Clear();
                txtCEP.Clear();
                txtEstado.SelectedIndex = 0;
                txtCidade.Clear();
                txtConfirmarSenha.Clear();
                txtNome.Focus();
            }

            private void sairToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if ((MessageBox.Show("Realmente deseja sair ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
                {
                    this.Close();
                }
            }

            private void cToolStripMenuItem_Click(object sender, EventArgs e)
            {
                cadastrocliente form1 = new cadastrocliente();
                this.Hide();
                form1.Show();
            }

            private void btnLimpar_Click(object sender, EventArgs e)
            {
                Limpar();
            }

            private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
            {
                formAlterarCliente formAlterarClientes = new formAlterarCliente();
                this.Hide();
                formAlterarClientes.Show();
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

            private void txtDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '/'))
                {
                    e.Handled = true;
                }
            }

            private void Form1_FormClosed(object sender, FormClosedEventArgs e)
            {
                Login log = new Login();
                log.Show();
                this.Hide();
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            public bool ValidarCampos()
            {
                if (txtNome.Text == "")
                    return false;
                if (txtSobrenome.Text == "")
                    return false;
                if (txtEmail.Text == "")
                    return false;
                if (txtSenha.Text == "")
                    return false;
                if (txtCPF.Text == "")
                    return false;
                if (txtDataNascimento.Text == "")
                    return false;
                if (txtEndereco.Text == "")
                    return false;
                if (txtNumero.Text == "")
                    return false;
                if (txtBairro.Text == "")
                    return false;
                if (txtCEP.Text == "")
                    return false;
                if (txtEstado.Text == "")
                    return false;
                if (txtCidade.Text == "")
                    return false;
                else
                    return true;
            }
    }
}

