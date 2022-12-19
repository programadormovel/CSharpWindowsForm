using CRUD_MVC_Daniel_Saraiva.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_Daniel_Saraiva.BLL
{
    internal class AtualizarUsuarioBLL
    {
        public int AtualizarUsuario(DataGridView dgvListar)
        {
            //Cria o objeto.
            AtualizarUsuarioDAL alt = new AtualizarUsuarioDAL();

            //Variável que recebe o retorno do atualizar usuário(DAL).
            var retorno = alt.AtualizarUsuario(dgvListar);

            //Retorna o status da atualização do usuário conforme definido em (DAL).
            return retorno;
        }
    }
}
