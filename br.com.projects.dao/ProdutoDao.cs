using AppFoodV2.br.com.projects.connection;
using AppFoodV2.br.com.projects.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFoodV2.br.com.projects.dao
{
    public class ProdutoDao
    {
        private MySqlConnection connection;

        public ProdutoDao()
        {
            connection = new ConnectionFactory().mysqlonnnection();
        }

        #region ListarProdutos
        public DataTable ListarProdutos()
        {
            try
            {
                DataTable produtos = new DataTable();
                string query = "select idproduto, nome, descricao, preco" +
                    " from produtos";
                MySqlCommand execquery = new MySqlCommand(query, connection);
                execquery.ExecuteNonQuery();

                MySqlDataAdapter dtadapter = new MySqlDataAdapter(execquery);
                dtadapter.Fill(produtos);

                return produtos;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
                return null;
            }
        }

        #endregion

        #region CadastrarProduto
        public void CadastrarProduto(Produto produto)
        {
            try
            {
                string query = "insert into produtos (nome, descricao, preco)" +
                    "values (@nome, @descricao, @preco)";
                MySqlCommand execquery = new MySqlCommand(query, connection);
                execquery.Parameters.AddWithValue("@nome", produto.Nome);
                execquery.Parameters.AddWithValue("@descricao", produto.Descricao);
                execquery.Parameters.AddWithValue("@preco", produto.Preco);

                execquery.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }
        #endregion

        #region EditarProduto
        public void EditarProduto(Produto produto)
        {
            try
            {
                string query = "update produtos set nome = @nome, descricao = @descricao, preco = @preco" +
                    " where idproduto = @idproduto";
                MySqlCommand execquery = new MySqlCommand(query, connection);
                execquery.Parameters.AddWithValue("@nome", produto.Nome);
                execquery.Parameters.AddWithValue("@descricao", produto.Descricao);
                execquery.Parameters.AddWithValue("@preco", produto.Preco);

                execquery.Parameters.AddWithValue("@idproduto", produto.IdProduto);

                execquery.ExecuteNonQuery();
                MessageBox.Show("Cadastro alterado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }
        #endregion

        #region DeletarProduto
        public void DeletarProduto(Produto produto)
        {
            try
            {
                string query = "delete from produtos where idproduto = @idproduto";
                MySqlCommand execquery = new MySqlCommand(query, connection);
                execquery.Parameters.AddWithValue("@idproduto", produto.IdProduto);

                execquery.ExecuteNonQuery();
                MessageBox.Show("Cadastro deletado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }
        #endregion

        #region BuscarProdutoPorNome
        public DataTable BuscarProdutoPorNome(String nome)
        {
            try
            {
                DataTable produtos = new DataTable();
                string query = "select idproduto, nome, descricao, preco" +
                    " from produtos where nome = @nome";
                MySqlCommand execquery = new MySqlCommand(query, connection);
                execquery.Parameters.AddWithValue("@nome", nome);
                execquery.ExecuteNonQuery();

                MySqlDataAdapter dtadapter = new MySqlDataAdapter(execquery);
                dtadapter.Fill(produtos);

                return produtos;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
                return null;
            }
        }
        #endregion

        #region BuscarProdutoPorNomeAproximado
        public DataTable BuscarProdutoPorNomeAproximado(String nome)
        {
            try
            {
                DataTable produtos = new DataTable();
                string query = "select idproduto, nome, descricao, preco" +
                    " from produtos where nome like @nome";
                MySqlCommand execquery = new MySqlCommand(query, connection);
                execquery.Parameters.AddWithValue("@nome", nome);
                execquery.ExecuteNonQuery();

                MySqlDataAdapter dtadapter = new MySqlDataAdapter(execquery);
                dtadapter.Fill(produtos);

                return produtos;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
                return null;
            }
        }
        #endregion
    }
}
