using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_Daniel_Saraiva.DAL
{
    internal class UtilsDAL
    {
        public static MySqlConnection GetConnection()
        {
            //Objeto builder com as configuração de acesso ao banco de dados.
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                Database = "cad_usuarios",
                UserID = "root",
                Password = ""
            };

            //Criando conexão.
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
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
                MySqlConnection conn = UtilsDAL.GetConnection();

                //Verifica se a conexão esta OK.
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    //Pesquisa no banco se o usuario existe.
                    string sql = $"SELECT {returnField} FROM {table} " +
                                    $"WHERE " +
                                    $"{field} =  '{textKey}'";

                    MySqlCommand retorno = new MySqlCommand(sql, conn);

                    //Executa a query.
                    MySqlDataReader reader = retorno.ExecuteReader();
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
