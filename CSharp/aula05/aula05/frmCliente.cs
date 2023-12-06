namespace aula05
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btoPesquisar_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(txtCodigo.Text, out n))
            {
                MessageBox.Show("Erro, Código deve ser preenchido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Text = "";
                txtCodigo.Focus();
                return;
            }
            MessageBox.Show("Dados validados com sucesso para o PESQUISAR","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btoExcluir_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(txtCodigo.Text, out n))
            {
                MessageBox.Show("Erro, Código deve ser preenchido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Text = "";
                txtCodigo.Focus();
                return;
            }
            MessageBox.Show("Dados validados com sucesso para o EXCLUIR", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private bool ValidarDados()
        {

            if (txtNome.Text == "")
            {
                MessageBox.Show("Erro, Nome deve ser preenchido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Text = "";
                txtNome.Focus();
                return false;
            }
            if (txtDataNascimento.Value > DataHoje)
            {
                MessageBox.Show("Erro, Data deve menor do que a data de hoje", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataNascimento.Value = DataHoje;
                txtDataNascimento.Focus();
                return false;
            }
            if (cboSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, Sexo/Genero deve ser preenchido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSexo.Focus();
                return false;
            }
            if (txtCPF.MaskFull == false)
            {
                MessageBox.Show("Erro, CPF deve ser preenchido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPF.Text = "";
                txtCPF.Focus();
                return false;
            }
            if (txtLogradouro.Text == "")
            {
                MessageBox.Show("Erro, Logradouro deve ser preenchido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogradouro.Text = "";
                txtLogradouro.Focus();
                return false;
            }
            if (txtNumero.Value <= 0)
            {
                MessageBox.Show("Erro, Número deve ser preenchido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Value = 0;
                txtNumero.Focus();
                return false;
            }
            if (txtCEP.MaskFull == false)
            {
                MessageBox.Show("Erro, CEP deve ser preenchido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCEP.Text = "";
                txtCEP.Focus();
                return false;
            }
            if (txtBairoo.Text == "")
            {
                MessageBox.Show("Erro, Bairro deve ser preenchido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairoo.Text = "";
                txtBairoo.Focus();
                return false;
            }
            if (txtCidade.Text == "")
            {
                MessageBox.Show("Erro, Cidade deve ser preenchido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Text = "";
                txtCidade.Focus();
                return false;
            }
            if (cboUF.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, UF deve ser preenchido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboUF.Focus();
                return false;
            }
            if (cboEstadoCivil.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, Estado Civil deve ser preenchido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboEstadoCivil.Focus();
                return false;
            }
            if (cboStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Erro, Status deve ser preenchido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboStatus.Focus();
                return false;
            }

            return true;
        }

        private void btoCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarDados())
            {
                MessageBox.Show("Dados validados com sucesso para o CADASTRAR", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        DateTime DataHoje;

        private void frmCliente_Load(object sender, EventArgs e)
        {
            DataHoje = DateTime.Now;
            txtDataCadastro.Text = DataHoje.ToString();
        }

        private void btoAlterar_Click(object sender, EventArgs e)
        {

            int n;
            if (!int.TryParse(txtCodigo.Text, out n))
            {
                MessageBox.Show("Erro, Código deve ser preenchido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Text = "";
                txtCodigo.Focus();
                return;
            }
            if (ValidarDados())
            {
                MessageBox.Show("Dados validados com sucesso para o CADASTRAR", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btoLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtDataNascimento.Value = DataHoje;
            cboSexo.SelectedIndex = -1;
            txtCPF.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Value = 0;
            txtComplemento.Text = "";
            txtCEP.Text = "";
            txtBairoo.Text = "";
            txtCidade.Text = "";
            cboUF.SelectedIndex = -1;
            cboEstadoCivil.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            txtObs.Text = "";
            txtDataCadastro.Text = DataHoje.ToString();
        }
    }
}