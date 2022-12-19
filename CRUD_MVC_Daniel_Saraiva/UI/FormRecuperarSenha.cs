using CRUD_MVC_Daniel_Saraiva.BLL;
using CRUD_MVC_Daniel_Saraiva.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_Daniel_Saraiva.UI
{
    public partial class FormRecuperarSenha : Form
    {
        public FormRecuperarSenha()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //Código para encerrar a pagina antecessora.
            this.Hide();
            var FormRecuperarSenha = new FormLogin();
            FormRecuperarSenha.Closed += (s, args) => this.Close();
            FormRecuperarSenha.Show();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            //Captura os dados e encaminha para a BLL.
            RecuperarSenhaDTO senhaDTO = new RecuperarSenhaDTO
            {
                Email = txtEmail.Text
            };

            //Chama o método BLL e retorna uma mensagem para o usuário.
            RecuperarSenhaBLL senhaBLL = new RecuperarSenhaBLL();
            int retorno = senhaBLL.GetRecuperarSenhaBLL(senhaDTO);

            switch(retorno)
            {
                case 0:
                    MessageBox.Show("E-mail não cadastrado, digite novamente !!");
                    break;

                case 1:
                    MessageBox.Show("Confira sua caixa de e-mail, e acesse o link enviado !!");
                    break;
            }
        }
    }
}
