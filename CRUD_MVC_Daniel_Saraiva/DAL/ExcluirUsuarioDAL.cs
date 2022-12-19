using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_Daniel_Saraiva.DAL
{
    internal class ExcluirUsuarioDAL
    {
        public int ExcluirUsuario(DataGridView dgvListar)
        {
            //Recupera os dados.
            if(dgvListar.CurrentRow != null)
            {
                var id = dgvListar.CurrentRow.Cells[0].Value.ToString();
                var nome = dgvListar.CurrentRow.Cells[1].Value.ToString();

                //Excluir.
                try
                {
                    //Conecta ao banco de dados.
                    var conn = UtilsDAL.GetConnection();

                    //Verifica se a conexão esta Ok.
                    if(conn.State == System.Data.ConnectionState.Open)
                    {
                        DialogResult dr = MessageBox.Show(
                                                "Excluir",
                                                $"Confirma exclusão do usuário... {nome}",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

                        if (dr == DialogResult.Yes)
                        {
                            //A exclusão é feita por padrão usando o id do usuário no banco de dados.
                            var sql = $"DELETE FROM usuarios WHERE id_usuario = '{id}'";
                            var comando = new MySqlCommand(sql, conn);
                            comando.ExecuteNonQuery();          //Usado para deletar.
                            conn.Close();
                            return 1;                           //Usuário excluido com sucesso.
                        }
                        else
                        {
                            return 2;                           //Ação cancelada pelo usuário.
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
            return 0;                                           //Usuário não selecionado.
        }
    }
}
