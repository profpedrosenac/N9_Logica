using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MiniProjeto
{
    public partial class frmUsuarioPesquisa : Form
    {
        public frmUsuarioPesquisa()
        {
            InitializeComponent();
        }

        string conexao = MDIPrincipal.conexao;

        private void TestarConexao()
        {
            SqlConnection conn = new SqlConnection(conexao);

            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.ToString());
                Application.Exit();
            }
        }

        private void CarregarPesquisa()
        {
            string sql = "select " +
                "id_usuario as 'ID'," +
                "nome_usuario as 'Nome'," +
                "Login_Usuario as 'Usuário'," +
                "Status_Usuario as 'Status' " +
                " from usuario where nome_usuario like '%" + txtPesquisaNome.Text + "%'";

            SqlConnection conn = new SqlConnection(conexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();

            try
            {
                adapter.Fill(ds);
                dataGridUsuario.DataSource = ds.Tables[0];
                dataGridUsuario.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridUsuario.AutoResizeRow(0, DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void frmUsuarioPesquisa_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarPesquisa();
        }

        private void txtPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            CarregarPesquisa();
        }

        public string idUsuario;

        private void dataGridUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idUsuario = dataGridUsuario.CurrentRow.Cells[0].Value.ToString();
            //MessageBox.Show(idUsuario);
            this.Close();
        }
    }
}
