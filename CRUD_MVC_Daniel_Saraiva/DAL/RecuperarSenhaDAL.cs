using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_MVC_Daniel_Saraiva.DTO;
using MySql.Data.MySqlClient;

namespace CRUD_MVC_Daniel_Saraiva.DAL
{
    internal class RecuperarSenhaDAL
    {
        public bool GetRecuperarSenhaDAL(RecuperarSenhaDTO recuperarSenhaDTO)
        {
            try
            {
                //Chama o método para conectar ao banco de dados.
                MySqlConnection conn = UtilsDAL.GetConnection();

                //Verifica se a conexão esta OK.
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    //Variável com a query para seleciona o email.
                    string sql = $"SELECT email FROM usuarios" +
                                    $" WHERE " +
                                    $"email = '{recuperarSenhaDTO.Email}'";

                    MySqlCommand retorno = new MySqlCommand(sql, conn);

                    //Executa a query.
                    MySqlDataReader reader = retorno.ExecuteReader();

                    //Se houver sucesso retorna true
                    if (reader.Read())
                    {
                        return true;
                    }
                }
            }catch(System.Exception erro)
            {
                //Apresenta uma mensagem de erro ao usuário
                MessageBox.Show(erro.Message);
            }
            return false;
        }
    }
}
