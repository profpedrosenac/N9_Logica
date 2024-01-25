using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjeto
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        public static string idUsuarioLogin;
        public static string nomeUsuarioLogin;
        public static string loginUsuarioLogin;
        
        public static string conexao = "" +
            "Data Source=localhost;" +
            "Initial Catalog=N9_miniprojeto;" +
            "User ID=sa;" +
            "Password=123456";

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void testarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarioTeste frm = new frmUsuarioTeste();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
