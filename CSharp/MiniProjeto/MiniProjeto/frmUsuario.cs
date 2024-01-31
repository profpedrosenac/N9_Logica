using System.Data;
using System.Data.SqlClient;

namespace MiniProjeto
{
    public partial class frmUsuario : Form
    {

        /*string conexao = "" +
            "Data Source=localhost;" +
            "Initial Catalog=N9_miniprojeto;" +
            "User ID=sa;" +
            "Password=123456";*/

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
                MessageBox.Show("Erro "+ ex.ToString());
                Application.Exit();
            }
        }

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();

        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
            txtObs.Text = "";
            cboStatus.SelectedIndex = -1;
            txtCodigo.Focus();
        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Erro, nome deve ser informado", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Erro, login deve ser informado", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Text = "";
                txtLogin.Focus();
                return;
            }
            if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Erro, senha deve ser informado", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Text = "";
                txtSenha.Focus();
                return;
            }

            string sql = "insert into usuario" +
                "(Nome_Usuario, Login_Usuario, Senha_Usuario,Obs_Usuario)" +
                "values" +
                "('" + txtNome.Text + "','" + txtLogin.Text + "','" + txtSenha.Text + "','" + txtObs.Text + "')" +
                "select scope_identity()";

            SqlConnection conn = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conn.Open();

            try
            {
                //int i = cmd.ExecuteNonQuery();
                //if (i > 0)
                //{
                //    MessageBox.Show("Dados cadastrados com sucesso!");
                //}

                leitura = cmd.ExecuteReader();

                if (leitura.Read())
                {
                    btoLimpar.PerformClick();
                    MessageBox.Show("Dados cadastrados com sucesso!");
                    txtCodigo.Text = leitura[0].ToString();
                    btoPesquisar.PerformClick();
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

            CarregarGridUsuario();

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            TestarConexao();
            CarregarGridUsuario();
        }

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(txtCodigo.Text,out n))
            {
                MessageBox.Show("Erro, código deve ser informado");
                btoLimpar.PerformClick();
                txtCodigo.Focus();
                return;
            }

            string sql = "delete from usuario where id_usuario = " + n.ToString();

            SqlConnection conn = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Dados excluidos com sucesso!");
                    btoLimpar.PerformClick();
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

            CarregarGridUsuario();

        }

        private void btoAlterar_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(txtCodigo.Text, out n))
            {
                MessageBox.Show("Erro, código deve ser informado");
                btoLimpar.PerformClick();
                txtCodigo.Focus();
                return;
            }
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Erro, nome deve ser informado", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Erro, login deve ser informado", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Text = "";
                txtLogin.Focus();
                return;
            }
            if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Erro, senha deve ser informado", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Text = "";
                txtSenha.Focus();
                return;
            }
            if (cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, status deve ser preenchido", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboStatus.SelectedIndex = -1;
                cboStatus.Focus();
                return;
            }

            string sql = "update usuario set " +
                "Nome_Usuario = '"+txtNome.Text+"'," +
                "Login_Usuario = '"+txtLogin.Text+"'," +
                "Senha_Usuario = '"+txtSenha.Text+"'," +
                "Status_Usuario = '"+cboStatus.Text+"'," +
                "Obs_Usuario = '"+txtObs.Text+"' " +
                "where id_Usuario = " + n.ToString();

            SqlConnection conn = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Dados alterados com sucesso!");
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

            CarregarGridUsuario();
        }

        private void btoPesquisar_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(txtCodigo.Text,out n))
            {
                MessageBox.Show("Erro, código deve ser informado");
                btoLimpar.PerformClick();
                txtCodigo.Focus();
                return;
            }

            string sql = "select * from usuario where id_usuario = " + n.ToString();

            SqlConnection conn = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader leitura;
            conn.Open();

            try
            {
                leitura = cmd.ExecuteReader();
                if (leitura.Read())
                {
                    txtCodigo.Text = leitura[0].ToString();
                    txtNome.Text = leitura[1].ToString();
                    txtLogin.Text = leitura[2].ToString();
                    txtSenha.Text = leitura[3].ToString();
                    txtObs.Text = leitura[4].ToString();
                    cboStatus.Text = leitura[5].ToString();
                }
                else
                {
                    MessageBox.Show("Erro, código não encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, " + ex.ToString());
                btoLimpar.PerformClick();
            }
            finally
            {
                conn.Close();
            }
        }

        private void CarregarGridUsuario()
        {
            string sql = "select " +
                "id_usuario as 'ID'," +
                "nome_usuario as 'Nome'," +
                "Login_Usuario as 'Usuário'," +
                "Status_Usuario as 'Status' " +
                " from usuario where nome_usuario like '%" + txtPesquisaNome.Text + "%'";

            SqlConnection conn = new SqlConnection(conexao);
            SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();
            conn.Open();

            try
            {
                adapter.Fill(ds);
                dataGridUsuario.DataSource = ds.Tables[0];
                dataGridUsuario.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridUsuario.AutoResizeRow(0,DataGridViewAutoSizeRowMode.AllCellsExceptHeader);
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

        private void dataGridUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dataGridUsuario.CurrentRow.Cells[0].Value.ToString();
            btoPesquisar.PerformClick();
        }

        private void txtPesquisaNome_TextChanged(object sender, EventArgs e)
        {
            CarregarGridUsuario();
        }
    }
}