using CRUD_MVC_Daniel_Saraiva.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_Daniel_Saraiva.BLL
{
    internal class ExcluirUsuarioBLL
    {
        public int ExcluirUsuario(DataGridView dgvListar)
        {
            //Cria o objeto que representa (DAL).
            ExcluirUsuarioDAL excluir = new ExcluirUsuarioDAL();

            //Variável que recebe o retorno do excluir usuario (DAL).
            var retorno = excluir.ExcluirUsuario(dgvListar);

            //Retorna o resultado.
            return retorno;
        }
    }
}
