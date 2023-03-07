using AppFoodV2.br.com.projects.dao;
using AppFoodV2.br.com.projects.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppFoodV2.br.com.projects.view
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.RG = mtbRg.Text;
            cliente.CPF = mtbCpf.Text;
            cliente.Email = txtEmail.Text;
            cliente.Celular = mtbCelular.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.CEP = mtbCep.Text;
            cliente.Numero = int.Parse(txtNumero.Text);
            cliente.Estado = cbEstado.Text;
            cliente.Cidade = txtCidade.Text;

            ClienteDao clienteDao = new ClienteDao();
            clienteDao.CadastrarCliente(cliente);
            tabelaClientes.DataSource = clienteDao.ListarClientes();
        }

        private void IdTxt_Click(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            ClienteDao cliente = new ClienteDao();
            tabelaClientes.DataSource = cliente.ListarClientes();
        }

        private void tabelaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = tabelaClientes.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = tabelaClientes.CurrentRow.Cells[4].Value.ToString();
            mtbRg.Text = tabelaClientes.CurrentRow.Cells[2].Value.ToString();
            mtbCpf.Text = tabelaClientes.CurrentRow.Cells[3].Value.ToString();
            mtbCelular.Text = tabelaClientes.CurrentRow.Cells[5].Value.ToString();
            txtEndereco.Text = tabelaClientes.CurrentRow.Cells[6].Value.ToString();
            txtBairro.Text = tabelaClientes.CurrentRow.Cells[7].Value.ToString();
            txtComplemento.Text = tabelaClientes.CurrentRow.Cells[8].Value.ToString();
            mtbCep.Text = tabelaClientes.CurrentRow.Cells[9].Value.ToString();
            txtNumero.Text = tabelaClientes.CurrentRow.Cells[10].Value.ToString();
            cbEstado.Text = tabelaClientes.CurrentRow.Cells[12].Value.ToString();
            txtId.Text = tabelaClientes.CurrentRow.Cells[0].Value.ToString();
            txtCidade.Text = tabelaClientes.CurrentRow.Cells[11].Value.ToString();

            tabCliente.SelectedTab = tabPage1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.IdCliente = int.Parse(txtId.Text);
            ClienteDao clienteDao = new ClienteDao();
            clienteDao.DeletarCliente(cliente);
            tabelaClientes.DataSource = clienteDao.ListarClientes();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.RG = mtbRg.Text.Replace(",", "."); ;
            cliente.CPF = mtbCpf.Text;
            cliente.Email = txtEmail.Text;
            cliente.Celular = mtbCelular.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.CEP = mtbCep.Text;
            cliente.Numero = int.Parse(txtNumero.Text);
            cliente.Estado = cbEstado.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.IdCliente = int.Parse(txtId.Text);

            ClienteDao clienteDao = new ClienteDao();
            clienteDao.EditarCliente(cliente);
            tabelaClientes.DataSource = clienteDao.ListarClientes();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string nome = txtSearchCliente.Text;
            ClienteDao cliente = new ClienteDao();
            tabelaClientes.DataSource = cliente.BuscarClientePorNome(nome);

            if (tabelaClientes.Rows.Count == 0)
            {
                tabelaClientes.DataSource = cliente.ListarClientes();
            }
        }

        private void txtSearchCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtSearchCliente.Text + "%";
            ClienteDao cliente = new ClienteDao();
            tabelaClientes.DataSource = cliente.BuscarClientePorNomeAproximado(nome);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
