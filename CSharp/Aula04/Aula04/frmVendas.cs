namespace Aula04
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        float valorUnit; float qtde; float total;

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboValor.SelectedIndex = cboProduto.SelectedIndex;
        }

        private void btoCredito_Click(object sender, EventArgs e)
        {
            if (cboProduto.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, produto deve ser preenchido");
                return;
            }
            if (!float.TryParse(txtQtde.Text, out qtde))
            {
                MessageBox.Show("Erro, qtde deve ser numérico");
                return;
            }

            valorUnit = float.Parse(cboValor.Text.Replace("R$ ", ""));

            total = qtde * valorUnit * 1.15F;

            lblResult.Text = total.ToString("C");
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            cboProduto.SelectedIndex = -1;
            cboValor.SelectedIndex = -1;
            txtQtde.Text = "";
            lblResult.Text = "R$ 0,00";
            cboProduto.Focus();
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btoPIX_Click(object sender, EventArgs e)
        {
            if (cboProduto.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, produto deve ser preenchido");
                return;
            }
            if (!float.TryParse(txtQtde.Text, out qtde))
            {
                MessageBox.Show("Erro, qtde deve ser numérico");
                return;
            }

            valorUnit = float.Parse(cboValor.Text.Replace("R$ ", ""));

            total = qtde * valorUnit * 0.95F;

            lblResult.Text = total.ToString("C");
        }

        private void btoCartao_Click(object sender, EventArgs e)
        {
            if (cboProduto.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, produto deve ser preenchido");
                return;
            }
            if (!float.TryParse(txtQtde.Text, out qtde))
            {
                MessageBox.Show("Erro, qtde deve ser numérico");
                return ;
            }

            valorUnit = float.Parse(cboValor.Text.Replace("R$ ",""));

            total = qtde * valorUnit;

            lblResult.Text = total.ToString("C");
        }
    }
}