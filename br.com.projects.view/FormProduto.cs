using AppFoodV2.br.com.projects.dao;
using AppFoodV2.br.com.projects.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFoodV2.br.com.projects.view
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Nome = txtNome.Text;
            produto.Descricao = txtDescricao.Text;
            produto.Preco = float.Parse(txtPreco.Text);

            ProdutoDao produtoDao = new ProdutoDao();
            produtoDao.CadastrarProduto(produto);
            tabelaProdutos.DataSource = produtoDao.ListarProdutos();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Nome = txtNome.Text;
            produto.Descricao = txtDescricao.Text;
            produto.Preco = float.Parse(txtPreco.Text);

            ProdutoDao produtoDao = new ProdutoDao();
            produtoDao.EditarProduto(produto);
            tabelaProdutos.DataSource = produtoDao.ListarProdutos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.IdProduto = int.Parse(txtId.Text);
            ProdutoDao produtoDao = new ProdutoDao();
            produtoDao.DeletarProduto(produto);
            tabelaProdutos.DataSource = produtoDao.ListarProdutos();
        }

        private void tabelaProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = tabelaProdutos.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = tabelaProdutos.CurrentRow.Cells[2].Value.ToString();
            txtPreco.Text = tabelaProdutos.CurrentRow.Cells[3].Value.ToString();
            txtId.Text = tabelaProdutos.CurrentRow.Cells[0].Value.ToString();

            tabProduto.SelectedTab = tabPage1;
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            ProdutoDao produtoDao = new ProdutoDao();
            tabelaProdutos.DataSource = produtoDao.ListarProdutos();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string nome = txtSearchProduto.Text;
            ProdutoDao produto = new ProdutoDao();
            tabelaProdutos.DataSource = produto.BuscarProdutoPorNome(nome);

            if (tabelaProdutos.Rows.Count == 0)
            {
                tabelaProdutos.DataSource = produto.ListarProdutos();
            }
        }

        private void txtSearchProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtSearchProduto.Text + "%";
            ProdutoDao produto = new ProdutoDao();
            tabelaProdutos.DataSource = produto.BuscarProdutoPorNomeAproximado(nome);
        }
    }
}
