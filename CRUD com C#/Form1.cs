namespace CRUD_com_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!txtCnpj.Text.Equals("") && !txtComplemento.Text.Equals("") && !txtCep.Text.Equals("") &&
                    !txtBairro.Text.Equals("") && !txtCidade.Text.Equals("") && !txtEnd.Text.Equals("") &&
                    !txtInscricao.Text.Equals("") && !txtNumero.Text.Equals("") && !txtResp.Text.Equals("") &&
                    !txtTelefone.Text.Equals("")&& boxCnae.SelectedItem != null && boxUf.SelectedItem != null)
                {
                    cadastroFuncionarios cadEmpresa = new cadastroFuncionarios();
                    cadEmpresa.Cnpj = txtCnpj.Text;
                    cadEmpresa.Bairro = txtBairro.Text;
                    cadEmpresa.Complemento = txtComplemento.Text;
                    cadEmpresa.Cidade = txtCidade.Text;
                    cadEmpresa.Cep = txtCep.Text;
                    cadEmpresa.Endereco = txtEnd.Text;
                    cadEmpresa.Inscricao_estadual = txtInscricao.Text;
                    cadEmpresa.Numero = txtNumero.Text;
                    cadEmpresa.Resp_imediato = txtResp.Text;
                    cadEmpresa.Telefone = txtTelefone.Text;
                    cadEmpresa.Uf = boxUf.SelectedItem.ToString();

                    cadEmpresa.Matriz = matrizR.Checked ? 1 : 0;
                    cadEmpresa.Filial = filialR.Checked ? 1 : 0;

                    cadEmpresa.Vendas = checkVendas.Checked ? 1 : 0;
                    cadEmpresa.Recrutamento_selecao = checkRecrutamento.Checked ? 1 : 0;
                    cadEmpresa.Fornecimentos = checkFornecimento.Checked ? 1 : 0;
                    cadEmpresa.Promocoes = checkPromo.Checked ? 1 : 0;
                    cadEmpresa.News_letter = checkNews.Checked ? 1 : 0;
                    cadEmpresa.Novos_produtos = checkNovos.Checked ? 1 : 0;
                    cadEmpresa.Garantia = checkGarantia.Checked ? 1 : 0;
                    cadEmpresa.Eventos = checkEventos.Checked ? 1 : 0;

                    cadEmpresa.Cnae = boxCnae.SelectedItem != null ? boxCnae.SelectedItem.ToString() : string.Empty;

                    if (cadEmpresa.cadastrarDados())
                    {
                        MessageBox.Show($"Cadastro realizado com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Nao foi possivel realizar o cadastro");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos!");
                    txtBairro.Clear();
                    txtCep.Clear();
                    txtCidade.Clear();
                    txtCnpj.Clear();
                    txtComplemento.Clear();
                    txtEnd.Clear();
                    txtInscricao.Clear();
                    txtNumero.Clear();
                    txtResp.Clear();
                    txtTelefone.Clear();
                    txtCnpj.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }
    }
}
