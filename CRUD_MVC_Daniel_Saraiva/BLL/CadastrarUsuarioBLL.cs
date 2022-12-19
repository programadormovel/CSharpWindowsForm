using CRUD_MVC_Daniel_Saraiva.DAL;
using CRUD_MVC_Daniel_Saraiva.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MVC_Daniel_Saraiva.BLL
{
    internal class CadastrarUsuarioBLL
    {
        //O método de controle deve validar os dados e chamar o método.
        public int CadastrarUsuario(CadastrarUsuarioDTO usuario)
        {
            if (usuario.Nome != "")
            {
                if (usuario.Email != "")
                {
                    if (usuario.Senha != "")
                    {
                        if (usuario.ConfirmarSenha != "")
                        {
                            if (usuario.Senha == usuario.ConfirmarSenha)
                            {
                                CadastrarUsuarioDAL cadUserDal = new CadastrarUsuarioDAL();

                                //Estando tudo ok, grava os dados.
                                bool retorno = cadUserDal.CadastrarUsuario(usuario);
                                if (retorno)
                                    return 1;   //Retorna usuario cadastrado !.

                                return 0;       //Retorna erro ao cadastrar usuário.
                            }
                            return 2;           //Retorna Senha diferente.
                        }
                        return 3;               //Digite Confirmar Senha.
                    }
                    return 4;                   //Digite senha.               
                }
                return 5;                       //Digite E-mail.
            }
            return 6;                           //Digite Nome.
        }
    }
}
