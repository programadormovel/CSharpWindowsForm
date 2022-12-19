using CRUD_MVC_Daniel_Saraiva.DTO;
using CRUD_MVC_Daniel_Saraiva.BLL;
using CRUD_MVC_Daniel_Saraiva.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_Daniel_Saraiva
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnMostarSenha_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                btnMostarSenha.BringToFront();
                txtSenha.PasswordChar = '\0';
            }
        }

        private void btnMostarSenha_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtSenha.PasswordChar == '\0')
            {
                btnMostarSenha.BringToFront();
                txtSenha.PasswordChar = '*';
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Captura os dados do formulário e encaminha a camada BLL e tranforma em um objeto.
            LoginDTO loginDTO = new LoginDTO
            {
                Email = txtEmail.Text,
                Senha = txtSenha.Text            
            };

            //Realiza a chamada do método de pesquisa.
            LoginBLL login = new LoginBLL();
            int retorno = login.GetLoginBLL(loginDTO);

            //Retorna mensagem para o usuário;
            switch(retorno)
            {
                case 0:
                    MessageBox.Show("Login inválido, digite novamente !!");
                    break;

                case 1:
                    MessageBox.Show("Login realizado com sucesso !!");

                    //Código para encerrar a pagina de Login após abrir a tela de Menu.
                    this.Hide();
                    var FormMenu = new FormMenu();
                    FormMenu.Closed += (s, args) => this.Close();
                    FormMenu.Show();
                    break;

                case 2:
                    MessageBox.Show("Digite sua senha !!");
                    break;

                case 3:
                    MessageBox.Show("Digite seu e-mail !!");
                    break;
            }
        }

        private void lnkEsqueceuSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Código para encerrar a pagina antecessora.
            this.Hide();
            var FormLogin = new FormRecuperarSenha();
            FormLogin.Closed += (s, args) => this.Close();
            FormLogin.Show();
        }
    }
}
