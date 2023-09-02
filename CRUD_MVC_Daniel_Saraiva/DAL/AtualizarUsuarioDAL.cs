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
    internal class AtualizarUsuarioDAL
    {
        //Método para alterar dados do usuários.
        public int AtualizarUsuario(DataGridView dgvListar)
        {
            //Verifica se o objeto da lista tem dados.
            if(dgvListar.CurrentRow != null)
            {
                //Montar a tabela.
                var id = dgvListar.CurrentRow.Cells[0].Value.ToString();
                var nome = dgvListar.CurrentRow.Cells[1].Value.ToString();
                var email = dgvListar.CurrentRow.Cells[2].Value.ToString();
                var senha = dgvListar.CurrentRow.Cells[3].Value.ToString();
                var nivel = dgvListar.CurrentRow.Cells[4].Value.ToString();

                try
                {
                    //Conectar no banco de dados.
                    var conn = UtilsDAL.GetConnection();

                    //Verifica se a conexão esta ok.

                    if(conn.State == System.Data.ConnectionState.Open)
                    {
                        //Cria um objeto onde ira receber a informação e alterar.
                        DialogResult dr = MessageBox.Show(
                            "Alterar",
                            $"Confirma alteração do usuário... {nome}",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        //Se o usuário seleciona yes.
                        if(dr == DialogResult.Yes)
                        {
                            var sql = $"UPDATE usuario SET " +
                                            $"nome = '{nome}', " +
                                            $"email = '{email}', " +
                                            $"senha = '{senha}', " +
                                            $"nivel = '{nivel}' " +
                                            $" WHERE id_usuario = '{id}'";

                            var comando = new SqlCommand(sql, conn);
                            comando.ExecuteNonQuery();      //Usado para update segundo a documentação.
                            conn.Close();
                            return 1;                       //Usuário alterado com sucesso.
                        }
                        else
                        {
                            return 2;                       //Acão cancelada pelo usuário.
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
            return 0;                                       //Usuário nao foi selecionado.
        }
    }
}
