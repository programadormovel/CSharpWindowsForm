using CRUD_MVC_Daniel_Saraiva.DTO;
using CRUD_MVC_Daniel_Saraiva.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_Daniel_Saraiva.UI
{
    public partial class FormListarUsuarios : Form
    {
        public FormListarUsuarios()
        {
            InitializeComponent();
        }

        private void FormListarUsuarios_Load(object sender, EventArgs e)
        {
            //Configurar objetos ao iniciar o formulário.
            rbtnNome.Checked = true;

            //Configuração inicial dos botões.
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string field;
            //Criar um objeto que representa a camada BLL.
            ListarUsuariosBLL listar = new ListarUsuariosBLL();

            if(rbtnEmail.Checked)
            {
                field = "email";
            }
            else
            {
                field = "nome";
            }

            //Comando do controller e obtendo retorno.
            var retorno = listar.ListarPersonalizado(field,txtPesquisar.Text);

            //Montar o DataGridView
            dgvListar.Rows.Clear();     //Limpa todas as linhas.
            dgvListar.Columns.Clear();  //Limpa todas as colunas.
            dgvListar.Refresh();        //Atualiza o DataGridView.

            //Cria as colunas do DataGridView que serão preenchidos.
            dgvListar.Columns.Add("Id", "ID");
            dgvListar.Columns.Add("Nome", "Nome");
            dgvListar.Columns.Add("Email", "Email");
            dgvListar.Columns.Add("Senha", "Senha");
            dgvListar.Columns.Add("Nivel", "Nivel");
            dgvListar.Columns.Add("Data", "Data");

            //Percorrer a lista(retorno) e monta o DataGridView.
            foreach (var i in retorno)
            {
                dgvListar.Rows.Add(i.Id, i.Nome, i.Email, i.Senha, i.Nivel, i.Data);
            }

            //Ajusta automaticamente o tamanho das colunas.
            dgvListar.AutoResizeColumn(1);           //Coluna indice 1.
            dgvListar.AutoResizeColumn(2);
            dgvListar.AutoResizeColumn(5);

            //Não permite que as colunas do DataGridView sejam  editadas manualmente.
            dgvListar.ReadOnly = true;

            //Controlar os botões do formulário.
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void dgvListar_DoubleClick(object sender, EventArgs e)
        {
            //Habilitar o botão atualizar e excluir.
            btnAtualizar.Enabled = true;
            btnExcluir.Enabled = true;

            //Desabilitar o modo "readOnly", para que seja possivel editar os campos.
            dgvListar.ReadOnly = false;

            //Obter o id da linha selecionada.
            var id = dgvListar.CurrentRow.Cells[0].Value.ToString();

            //Listar usuário por id.
            ListarUsuariosBLL listar= new ListarUsuariosBLL();
            var retorno = listar.ListarPersonalizado("id_usuario", id);

            dgvListar.Rows.Clear();
            dgvListar.Columns.Clear();
            dgvListar.Refresh();

            dgvListar.Columns.Add("Id", "Id");
            dgvListar.Columns.Add("Nome", "Nome");
            dgvListar.Columns.Add("Email", "Email");
            dgvListar.Columns.Add("Senha", "Senha");
            dgvListar.Columns.Add("Nivel", "Nível");

            foreach (var i in retorno)
            {
                dgvListar.Rows.Add(i.Id, i.Nome, i.Email, i.Senha, i.Nivel);
            }

            //Ajustar automaticamente o tamanho das colunas.
            dgvListar.AutoResizeColumn(0);
            dgvListar.AutoResizeColumn(1);
            dgvListar.Columns["Id"].Visible = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Cria o objeto.
            AtualizarUsuarioBLL atualizar = new AtualizarUsuarioBLL();

            //A variável "resultado" recebe o retorno da chamada da (BLL).
            var resultado = atualizar.AtualizarUsuario(dgvListar);

            //Trata os resultados recebidos.
            if(resultado == 1)
            {
                MessageBox.Show("Usuário alterado com sucesso !");
                //Chamando o evento click do botão sem a necessidade de interação do usuário.
                btnPesquisar.PerformClick();
            }
            else if(resultado == 2)
            {
                MessageBox.Show("Ação cancelada !");
            }
            else
            {
                MessageBox.Show("Usuário não foi cadastrado !");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Cria o objeto que representa (BLL).
            ExcluirUsuarioBLL excluir =  new ExcluirUsuarioBLL();

            var resultado = excluir.ExcluirUsuario(dgvListar);

            if (resultado == 1)
            {
                MessageBox.Show("Usuário excluido com sucesso !");
                btnPesquisar.PerformClick();    
            }
            else if (resultado == 2)
            {
                MessageBox.Show("Ação foi cancelada !");
            }
            else
            {
                MessageBox.Show("Usuário não foi cadastrado !");
            }
        }
    }
}
