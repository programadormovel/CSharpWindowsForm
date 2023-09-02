using CRUD_MVC_Daniel_Saraiva.BLL;
using CRUD_MVC_Daniel_Saraiva.DAL;
using CRUD_MVC_Daniel_Saraiva.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_Daniel_Saraiva.UI
{
    public partial class FormCadastroUsuario : Form
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Receber todos os dados do formulário.
            CadastrarUsuarioDTO usuario = new CadastrarUsuarioDTO
            {
                Nome = txtNomeCompleto.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                ConfirmarSenha = txtConfirmarSenha.Text,
                Nivel = cmbNivel.Text
            };

            //Chamar o método cadastrarBLL.
            CadastrarUsuarioBLL cadUserBLL = new CadastrarUsuarioBLL();
            int retorno = cadUserBLL.CadastrarUsuario(usuario);

            switch (retorno)
            {
                case 0:
                    MessageBox.Show("Erro ao cadastrar Usuário !!");
                    break;

                case 1:
                    MessageBox.Show("Usuário cadastrado com sucesso !!");
                    break;

                case 2:
                    MessageBox.Show("Senhas diferentes, digite uma senha igual !!");
                    txtSenha.ForeColor = Color.Red;
                    txtConfirmarSenha.ForeColor = Color.Red;
                    break;

                case 3:
                    MessageBox.Show("Digite a mesma senha, no Confirmar senha !!");
                    break;

                case 4:
                    MessageBox.Show("Digite a senha !!");
                    break;

                case 5:
                    MessageBox.Show("Digite o e-mail !!");
                    break;

                case 6:
                    MessageBox.Show("Digite o nome !!");
                    break;
            }
        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                //Chama o método de conexão com o banco de dados.
                var conn = UtilsDAL.GetConnection();

                //Verifica se a conexão esta OK.
                if(conn.State == ConnectionState.Open)
                {
                    //Variável com a query.
                    string sql = $"SELECT * FROM nivel";

                    SqlCommand comando = new SqlCommand(sql, conn);

                    //Carrega a DataReader.
                    SqlDataReader data = comando.ExecuteReader();

                    //Cria uma tabela de dados.
                    DataTable table = new DataTable();

                    //Carrega a tabela.
                    table.Load(data);

                    //Informa qual o tipo de dado será exibido.
                    cmbNivel.DisplayMember = "nome";

                    //Carrega os dados no combBox.
                    cmbNivel.DataSource = table;

                    conn.Close();

                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Erro ao conectar com  banco de dados !!");
            }
        }

        private void btnMostarSenha_MouseDown(object sender, MouseEventArgs e)
        {
            if(txtSenha.PasswordChar == '*')
            {
                btnMostarSenha.BringToFront();
                txtSenha.PasswordChar = '\0';
            }
        }

        private void btnMostarSenha_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtSenha.PasswordChar == '\0')
            {
                btnMostarSenha.BringToFront();
                txtSenha.PasswordChar = '*';
            }

        }

        private void btnMostrarConfirmarSenha_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtConfirmarSenha.PasswordChar == '*')
            {
                btnMostrarConfirmarSenha.BringToFront();
                txtConfirmarSenha.PasswordChar = '\0';
            }
        }

        private void btnMostrarConfirmarSenha_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtConfirmarSenha.PasswordChar == '\0')
            {
                btnMostrarConfirmarSenha.BringToFront();
                txtConfirmarSenha.PasswordChar = '*';
            }
        }

		private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
