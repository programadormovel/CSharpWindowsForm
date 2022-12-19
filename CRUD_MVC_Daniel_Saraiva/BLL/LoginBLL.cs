using CRUD_MVC_Daniel_Saraiva.DAL;
using CRUD_MVC_Daniel_Saraiva.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MVC_Daniel_Saraiva.BLL
{
    internal class LoginBLL
    {
        public int GetLoginBLL(LoginDTO loginDTO)
        {
            if (loginDTO.Email != "")
            {
                if (loginDTO.Senha != "")
                {
                    //valida o usuário.
                    //Realiza a chamada pesquisa na camada LoginDAL.
                    LoginDAL login = new LoginDAL();
                    bool retorno = login.GetLoginDAL(loginDTO);

                    //Se o retorno do método for verdadeiro volta true.
                    if (retorno)
                    {
                        return 1;
                    }
                    return 0;
                }
                return 2;
            }
            return 3;
        }
    }
}
