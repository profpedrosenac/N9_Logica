namespace Aula03
{
    public partial class frmMediaEscolar : Form
    {
        public frmMediaEscolar()
        {
            InitializeComponent();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";
            txtN4.Text = "";
            lblMedia.Text = "";
            lblResult.Text = "";
            txtN1.Focus();
        }

        private void btoOK_Click(object sender, EventArgs e)
        {
            float n1; float n2; float n3; float n4; float media;

            if (!float.TryParse(txtN1.Text, out n1))
            {
                MessageBox.Show("Erro, n1 deve ser numérico","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtN1.Text = "";
                txtN1.Focus();
                return;
            }
            if (!float.TryParse(txtN2.Text, out n2))
            {
                MessageBox.Show("Erro, n2 deve ser numérico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN2.Text = "";
                txtN2.Focus();
                return;
            }
            if (!float.TryParse(txtN3.Text, out n3))
            {
                MessageBox.Show("Erro, n3 deve ser numérico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN3.Text = "";
                txtN3.Focus();
                return;
            }
            if (!float.TryParse(txtN4.Text, out n4))
            {
                MessageBox.Show("Erro, n4 deve ser numérico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN4.Text = "";
                txtN4.Focus();
                return;
            }

            if (n1 < 0 || n1 > 10)
            {
                MessageBox.Show("Erro, n1 deve ser numérico entre 0 e 10", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN1.Text = "";
                txtN1.Focus();
                return;
            }
            if (n2 < 0 || n2 > 10)
            {
                MessageBox.Show("Erro, n2 deve ser numérico entre 0 e 10", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN2.Text = "";
                txtN2.Focus();
                return;
            }
            if (n3 < 0 || n3 > 10)
            {
                MessageBox.Show("Erro, n3 deve ser numérico entre 0 e 10", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN3.Text = "";
                txtN3.Focus();
                return;
            }
            if (n4 < 0 || n4 > 10)
            {
                MessageBox.Show("Erro, n4 deve ser numérico entre 0 e 10", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN4.Text = "";
                txtN4.Focus();
                return;
            }

            media = (n1 + n2 + n3 + n4) / 4;
            
            if (media > 7)
            {
                lblMedia.Text = media.ToString();
                lblResult.Text = "APROVADO";
            }
            else if (media < 5)
            {
                lblMedia.Text = media.ToString();
                lblResult.Text = "REPROVADO";
            }
            else
            {
                lblMedia.Text = media.ToString();
                lblResult.Text = "EXAME";
            }
        }
    }
}