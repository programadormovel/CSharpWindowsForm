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
    public partial class FormAjuda : Form
    {
        public FormAjuda()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //Código para encerrar a pagina antecessora.
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/dannsaraiva");
        }
    }
}
