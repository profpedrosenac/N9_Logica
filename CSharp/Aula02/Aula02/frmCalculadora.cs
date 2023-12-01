namespace Aula02
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
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
            lblResult.Text = "0";
            txtN1.Focus();
        }

        float n1;
        float n2;
        float total;

        private void btoMais_Click(object sender, EventArgs e)
        {

            if (txtN1.Text == "")
            {
                MessageBox.Show("Erro, N1 deve ser preenchido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN1.Text = "";
                txtN1.Focus();
                return;
            }

            if (float.TryParse(txtN1.Text, out n1) == false)
            {
                MessageBox.Show("Erro, N1 deve ser numérico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN1.Text = "";
                txtN1.Focus();
                return;
            }

            if (txtN2.Text == "")
            {
                MessageBox.Show("Erro, N2 deve ser preenchido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN2.Text = "";
                txtN2.Focus();
                return;
            }

            if (float.TryParse(txtN2.Text, out n2) == false)
            {
                MessageBox.Show("Erro, N2 deve ser numérico","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                txtN2.Text = "";
                txtN2.Focus();
                return;
            }

            total = n1 + n2;

            lblResult.Text = total.ToString();

        }

        private void btoMenos_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(txtN1.Text);
            n2 = float.Parse(txtN2.Text);

            total = n1 - n2;

            lblResult.Text = total.ToString();
        }

        private void btoMult_Click(object sender, EventArgs e)
        {

            n1 = float.Parse(txtN1.Text);
            n2 = float.Parse(txtN2.Text);

            total = n1 * n2;

            lblResult.Text = total.ToString();
        }

        private void btoDivisao_Click(object sender, EventArgs e)
        {

            n1 = float.Parse(txtN1.Text);
            n2 = float.Parse(txtN2.Text);

            total = n1 / n2;

            lblResult.Text = total.ToString();
        }
    }
}