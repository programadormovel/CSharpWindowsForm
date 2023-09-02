using CRUD_MVC_Daniel_Saraiva.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MVC_Daniel_Saraiva.DAL
{
    internal class CadastrarUsuarioDAL
    {
        //Método para cadastrar o usuário.
        public bool CadastrarUsuario(CadastrarUsuarioDTO usuario)
        {
            try
            {
                //Chama o método para conectar ao banco de dados.
                var conn = UtilsDAL.GetConnection();

                //Verifica se a conexão esta OK.
                if(conn.State == ConnectionState.Open)
                {
                    //Método para salvar somente a chave primaria no cadastro do usuário.
                    UtilsDAL cp = new UtilsDAL();
                    int nivel = cp.PrimaryKey("id_nivel", "nivel", "nome", usuario.Nivel);

                    //Variável com query de inserção de dados.
                    string sql = $"INSERT INTO usuarios " +
                                    $"(nome, email, senha, nivel) " +
                                    $"VALUES " +
                                    $"('{usuario.Nome}', '{usuario.Email}', '{usuario.Senha}', '{nivel}')";

                    //O objeto comando possui a conexão e a query a ser executada.
                    SqlCommand comando = new SqlCommand(sql, conn);

                    //Excecutamos a inserção de dados.
                    comando.ExecuteNonQuery();

                    //Boas práticas encerrar conexão.
                    conn.Close();
                }
            }
            //Em caso de erro na inserção de dados.
            catch (System.Exception)
            {
                return false;   //Caso não salve.
            }
            return true;        //Caso salve.
        }
    }
}
