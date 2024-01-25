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
    public partial class frmUsuarioTeste : Form
    {
        public frmUsuarioTeste()
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

        private void frmUsuarioTeste_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarUsuario();
        }

        private void CarregarUsuario()
        {
            string sql = "select id_usuario, login_usuario from usuario";
            SqlConnection conn = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;

            DataTable tabela = new DataTable();
            conn.Open();

            try
            {
                leitura = cmd.ExecuteReader();

                tabela.Load(leitura);

                cboNomeUsuario.DisplayMember = "login_usuario";
                cboNomeUsuario.DataSource = tabela;

                cboIDUsuario.DisplayMember = "id_usuario";
                cboIDUsuario.DataSource = tabela;
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
    }
}
