using CRUD_MVC_Daniel_Saraiva.DAL;
using CRUD_MVC_Daniel_Saraiva.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MVC_Daniel_Saraiva.BLL
{
    internal class RecuperarSenhaBLL
    {
        public int GetRecuperarSenhaBLL(RecuperarSenhaDTO senhaDTO)
        {
            //Valida os dados e retorna para UI.
            RecuperarSenhaDAL recuperarSenha = new RecuperarSenhaDAL();

            bool retorno = recuperarSenha.GetRecuperarSenhaDAL(senhaDTO);
            if (retorno)
                return 1;

            return 0;
        }
    }
}
