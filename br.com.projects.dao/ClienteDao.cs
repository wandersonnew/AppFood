using AppFoodV2.br.com.projects.connection;
using AppFoodV2.br.com.projects.model;
using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFoodV2.br.com.projects.dao
{
    public class ClienteDao
    {
        private MySqlConnection connection;

        public ClienteDao()
        {
            connection = new ConnectionFactory().mysqlonnnection();
        }

        #region ListarClientes
        public DataTable ListarClientes()
        {
            try
            {
                DataTable clientes = new DataTable();
                string query = "select idcliente, nome, cpf, rg, email, celular, endereco, bairro, complemento, cep, numero, cidade, estado" +
                    " from clientes";
                MySqlCommand execquery = new MySqlCommand(query, connection);
                execquery.ExecuteNonQuery();
                
                MySqlDataAdapter dtadapter = new MySqlDataAdapter(execquery);
                dtadapter.Fill(clientes);

                return clientes;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
                return null;
            }
        }

        #endregion

        #region CadastrarCliente
        public void CadastrarCliente(Cliente cliente)
        {
            try
            {
                string query = "insert into clientes (nome, cpf, rg, email, celular, endereco, bairro, complemento, cep, numero, cidade, estado)" +
                    "values (@nome, @cpf, @rg, @email, @celular, @endereco, @bairro, @complemento, @cep, @numero, @cidade, @estado)";
                MySqlCommand execquery = new MySqlCommand(query, connection);
                execquery.Parameters.AddWithValue("@nome", cliente.Nome);
                execquery.Parameters.AddWithValue("@cpf", cliente.CPF);
                execquery.Parameters.AddWithValue("@rg", cliente.RG);
                execquery.Parameters.AddWithValue("@email", cliente.Email);
                execquery.Parameters.AddWithValue("@celular", cliente.Celular);
                execquery.Parameters.AddWithValue("@endereco", cliente.Endereco);
                execquery.Parameters.AddWithValue("@bairro", cliente.Bairro);
                execquery.Parameters.AddWithValue("@complemento", cliente.Complemento);
                execquery.Parameters.AddWithValue("@cep", cliente.CEP);
                execquery.Parameters.AddWithValue("@numero", cliente.Numero);
                execquery.Parameters.AddWithValue("@cidade", cliente.Cidade);
                execquery.Parameters.AddWithValue("@estado", cliente.Estado);

                execquery.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }
        #endregion

        #region EditarCliente
        public void EditarCliente(Cliente cliente)
        {
            try
            {
                string query = "update clientes set nome = @nome, cpf = @cpf, rg = @rg, email = @email, celular = @celular, endereco = @endereco, bairro = @bairro, complemento = @complemento, cep = @cep, numero = @numero, cidade = @cidade, estado = @estado" +
                    " where idcliente = @idcliente";
                MySqlCommand execquery = new MySqlCommand(query, connection);
                execquery.Parameters.AddWithValue("@nome", cliente.Nome);
                execquery.Parameters.AddWithValue("@cpf", cliente.CPF);
                execquery.Parameters.AddWithValue("@rg", cliente.RG);
                execquery.Parameters.AddWithValue("@email", cliente.Email);
                execquery.Parameters.AddWithValue("@celular", cliente.Celular);
                execquery.Parameters.AddWithValue("@endereco", cliente.Endereco);
                execquery.Parameters.AddWithValue("@bairro", cliente.Bairro);
                execquery.Parameters.AddWithValue("@complemento", cliente.Complemento);
                execquery.Parameters.AddWithValue("@cep", cliente.CEP);
                execquery.Parameters.AddWithValue("@numero", cliente.Numero);
                execquery.Parameters.AddWithValue("@cidade", cliente.Cidade);
                execquery.Parameters.AddWithValue("@estado", cliente.Estado);

                execquery.Parameters.AddWithValue("@idcliente", cliente.IdCliente);

                execquery.ExecuteNonQuery();
                MessageBox.Show("Cadastro alterado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }
        #endregion

        #region DeletarCliente
        public void DeletarCliente(Cliente cliente)
        {
            try
            {
                string query = "delete from clientes where idcliente = @idcliente";
                MySqlCommand execquery = new MySqlCommand(query, connection);
                execquery.Parameters.AddWithValue("@idcliente", cliente.IdCliente);

                execquery.ExecuteNonQuery();
                MessageBox.Show("Cadastro deletado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }
        }
        #endregion

        #region BuscarClientePorNome
        public DataTable BuscarClientePorNome(String nome)
        {
            try
            {
                DataTable clientes = new DataTable();
                string query = "select idcliente, nome, cpf, rg, email, celular, endereco, bairro, complemento, cep, numero, cidade, estado" +
                    " from clientes where nome = @nome";
                MySqlCommand execquery = new MySqlCommand(query, connection);
                execquery.Parameters.AddWithValue("@nome", nome);
                execquery.ExecuteNonQuery();

                MySqlDataAdapter dtadapter = new MySqlDataAdapter(execquery);
                dtadapter.Fill(clientes);

                return clientes;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
                return null;
            }
        }
        #endregion

        #region BuscarClientePorNomeAproximado
        public DataTable BuscarClientePorNomeAproximado(String nome)
        {
            try
            {
                DataTable clientes = new DataTable();
                string query = "select idcliente, nome, cpf, rg, email, celular, endereco, bairro, complemento, cep, numero, cidade, estado" +
                    " from clientes where nome like @nome";
                MySqlCommand execquery = new MySqlCommand(query, connection);
                execquery.Parameters.AddWithValue("@nome", nome);
                execquery.ExecuteNonQuery();

                MySqlDataAdapter dtadapter = new MySqlDataAdapter(execquery);
                dtadapter.Fill(clientes);

                return clientes;
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
