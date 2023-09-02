using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_Daniel_Saraiva.DAL
{
    internal class UtilsDAL
    {
        public static SqlConnection GetConnection()
        {
            //Objeto builder com as configuração de acesso ao banco de dados.
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                ConnectionString = "Server=localhost;Database=cad_usuarios;Trusted_Connection=True;MultipleActiveResultSets=true;Integrated Security=false;User ID=sa;Password=Ad#1an01;Encrypt=False"
			};

            //Criando conexão.
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            connection.Open();

            return connection;
        }

        //Retorna a chave primaria da tabela do banco de dados.
        public int PrimaryKey(string returnField, string table, string field, string textKey)
        {
            //Conecta ao banco.
            try
            {
                //Cria conexão.
                SqlConnection conn = UtilsDAL.GetConnection();

                //Verifica se a conexão esta OK.
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    //Pesquisa no banco se o usuario existe.
                    string sql = $"SELECT {returnField} FROM {table} " +
                                    $"WHERE " +
                                    $"{field} =  '{textKey}'";

                    SqlCommand retorno = new SqlCommand(sql, conn);

                    //Executa a query.
                    SqlDataReader reader = retorno.ExecuteReader();
                    if (reader.Read())
                    {
                        return (int)reader[0];
                    }
                }
            }
            catch (System.Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            return -1;
        }
    }
}
