using System;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Deserializers;
namespace BrunSkerLocacaoImoveis
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do progama ?", "BrunSker Locacao Imoveis", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Application.Exit();
            }
        }

        private void txtDadosCEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDadosLogradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
          
            if (mskTxtCEP.TextLength == 9) 
            {
                try
                {

                    RestClient restClient = new RestClient(string.Format("https://viacep.com.br/ws/{0}/json/", mskTxtCEP.Text));

                    RestRequest restRequest = new RestRequest(Method.GET);

                    IRestResponse restResponse = restClient.Execute(restRequest);

                    if (restResponse.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        MessageBox.Show("Não foi possível completar sua requisição: " + restResponse.Content, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                        RetornarDados retornarDados = new JsonDeserializer().Deserialize<RetornarDados>(restResponse);

                        if (retornarDados.cep is null) 
                        {
                            MessageBox.Show("CEP informado não encontrado " + restResponse.Content, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        txtDadosCEP.Text = retornarDados.cep;
                        txtDadosLogradouro.Text = retornarDados.logradouro;
                        txtDadosComplemento.Text = retornarDados.complemento;
                        txtDadosBairro.Text = retornarDados.bairro;
                        txtDadosLocalidade.Text = retornarDados.localidade;
                        txtDadosUF.Text = retornarDados.uf;
                        txtDadosUnidade.Text = retornarDados.unidade;
                        txtDadosIBGE.Text = retornarDados.ibge;
                        txtDadosGIA.Text = retornarDados.gia;
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao consultar a API ViaCEP: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }
    }

    class RetornarDados
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string unidade { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }



    }
}
