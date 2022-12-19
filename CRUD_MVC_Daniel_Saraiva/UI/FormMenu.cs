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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void tsmCadastrarUsuario_Click(object sender, EventArgs e)
        {
            var FormCadastroUsuario = new FormCadastroUsuario();
            FormCadastroUsuario.Show();
        }

        private void tsmListarUsuarios_Click(object sender, EventArgs e)
        {
            var FormListarUsuarios = new FormListarUsuarios();
            FormListarUsuarios.Show();
        }

        private void tsmAjuda_Click(object sender, EventArgs e)
        {
            var FormAjuda = new FormAjuda();
            FormAjuda.Show();
        }
    }
}
