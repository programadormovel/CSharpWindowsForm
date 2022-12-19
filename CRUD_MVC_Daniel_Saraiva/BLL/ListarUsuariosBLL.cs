using CRUD_MVC_Daniel_Saraiva.DTO;
using CRUD_MVC_Daniel_Saraiva.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MVC_Daniel_Saraiva.BLL
{
    internal class ListarUsuariosBLL
    {
        //Método apenas chama a DAL e retorna a lista.
        public List<ListarUsuariosDTO> ListarUsuarios()
        {
            //Cria um objeto de classe ListarUsuariosDAL.
            ListarUsuariosDAL lista = new ListarUsuariosDAL();

            //Fazer a chamada do método ListarTodos().
            return lista.ListarTodos();
        }

        //Método para pesquisar usuário com filtro.
        public List<ListarUsuariosDTO> ListarPersonalizado(string field, string value)
        {
            //Cria um objeto.
            ListarUsuariosDAL lista = new ListarUsuariosDAL();

            //Faz a chamada do método.
            return lista.ListarPersonalizado(field, value);
        }
    }
}
