using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula05
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoOK_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtSenha.Text =="123")
            {
                MessageBox.Show("Seja bem vindo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválida", "Erro", MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            }
        }
    }
}
