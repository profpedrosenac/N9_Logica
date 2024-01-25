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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        /*string conexao = "" +
            "Data Source=localhost;" +
            "Initial Catalog=N9_miniprojeto;" +
            "User ID=sa;" +
            "Password=123456";*/

        string conexao = MDIPrincipal.conexao;

        bool logado = false;

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

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!logado)
            {
                Application.Exit();
            }            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            TestarConexao();
        }

        private void btoOK_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Erro, login deve ser preenchido");
                txtLogin.Text = "";
                txtLogin.Focus();
                return;
            }
            if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Erro, senha deve ser preenchido");
                txtSenha.Text = "";
                txtSenha.Focus();
                return;
            }

            string sql = "select * from usuario where " +
                "login_usuario = '" + txtLogin.Text + "' and senha_usuario = '" + txtSenha.Text + "'" ;

            SqlConnection conn = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conn.Open();

            try
            {
                leitura = cmd.ExecuteReader();

                if (leitura.Read())
                {
                    MDIPrincipal.idUsuarioLogin = leitura[0].ToString();
                    MDIPrincipal.nomeUsuarioLogin = leitura[1].ToString();
                    MDIPrincipal.loginUsuarioLogin = leitura[2].ToString();
                    MessageBox.Show("seja bem vindo");
                    logado = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro, usuário ou senha inválidas");
                }

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
