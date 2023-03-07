using AppFoodV2.br.com.projects.view;
using MySql.Data.MySqlClient;

namespace AppFoodV2
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormCliente clientes = new FormCliente();
            clientes.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormProduto produtos = new FormProduto();
            produtos.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FormVenda vendas = new FormVenda();
            vendas.ShowDialog();
        }
    }
}