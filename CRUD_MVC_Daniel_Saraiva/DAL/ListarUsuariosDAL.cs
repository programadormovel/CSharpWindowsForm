using CRUD_MVC_Daniel_Saraiva.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_Daniel_Saraiva.DAL
{
    internal class ListarUsuariosDAL
    {
        //Criar lista com objeto usuario.
        public List<ListarUsuariosDTO> usuariosLista = new List<ListarUsuariosDTO>();

        //Mostrar a ListarTodos.
        public List<ListarUsuariosDTO> ListarTodos()
        {
            try
            {
                //Conecta ao banco de dados.
                var conn = UtilsDAL.GetConnection();

                //Verifica se a conexão esta Ok.
                if(conn.State == System.Data.ConnectionState.Open)
                {
                    var sql = "SELECT * FROM usuarios";

                    var retorno = new SqlCommand(sql, conn);

                    var reader = retorno.ExecuteReader();

                    //Estrutura de repetição.
                    while (reader.Read())
                    {
                        //Aqui esta sendo feita a adição de usuarios a lista.
                        usuariosLista.Add(new ListarUsuariosDTO()
                        {
                            Id = reader[0].ToString(), //Primeira coluna da tabela usuarios.
                            Nome = reader[1].ToString(),
                            Email = reader[2].ToString(),
                            Senha = reader[3].ToString(),
                            Nivel = reader[4].ToString(),
                            Data = reader[5].ToString()
                        });
                    }

                    conn.Close();
                }
            }
            catch(System.Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            //Retorna a lista de usuarios pesquisada.
            return usuariosLista;
        }

        //Método listar usuários personalizados.
        public List<ListarUsuariosDTO> ListarPersonalizado(string field, string value)
        {
            try
            {
                //Conectar ao banco de dados.
                var conn = UtilsDAL.GetConnection();

                //Verifica se a conexão esta ok.
                if(conn.State == System.Data.ConnectionState.Open)
                {
                    var sql = $"SELECT * FROM usuarios WHERE {field} LIKE '%{value}%'";

                    var retorno = new SqlCommand(sql,conn);

                    var reader = retorno.ExecuteReader();

                    while (reader.Read())
                    {
                        usuariosLista.Add(new ListarUsuariosDTO()
                        {
                            Id = reader[0].ToString(),
                            Nome = reader[1].ToString(),
                            Email = reader[2].ToString(),
                            Senha = reader[3].ToString(),
                            Nivel = reader[4].ToString(),
                            Data = reader[5].ToString()
                        });
                    }
                    conn.Close();
                }
            }
            catch(System.Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return usuariosLista;
        }
    }
}
