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
    internal class LoginDAL
    {
        //Cria um método para consultar o banco e retorna se o usuário existe.
        //Este objeto contém atributos e métodos pertecentes ao objeto criado
        //que será criado na UI na classe do formulário.
        //Vamos chamar de GetLoginDAL para podermos diferenciar facilmente o método e sua camada.
        public bool GetLoginDAL(LoginDTO loginDTO)
        {
            //Conectar ao banco de dados.
            try
            {
                //Cria uma conexão.
                SqlConnection conn = UtilsDAL.GetConnection();

                //Verifica se a conexão esta OK.
                //Verificamos a propriedade STATE do objeto conn com a propriedade OPEN de ConnectionState.
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    string sql = $"SELECT * FROM usuarios" +
                                    $" WHERE " +
                                    $"email = '{loginDTO.Email}'" +
                                    $" AND " +
                                    $"senha = '{loginDTO.Senha}'";

                    SqlCommand retorno = new SqlCommand(sql, conn);
                    //Executa a query.
                    SqlDataReader reader = retorno.ExecuteReader();
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
