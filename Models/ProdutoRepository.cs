using System;
using System.Collections.Generic;
using MySqlConnector;

namespace Atv_4.Models
{
    public class ProdutoRepository : Repository
    {
        //----------------- BUSCAR PRODUTO POR ID ------------------
        public Produto BuscarPorId(int Id)
        {
            //1 abrir a conecão
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //2 criar um Usuário vazio
            Produto ProdutoEncontrado = new Produto();
            //3 preparar o query
            string Query = "SELECT * FROM Produto WHERE IdProduto=@IdProduto";

            //4 preparar o comando e executa
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //5 tratar o SQL INJECTION
            Comando.Parameters.AddWithValue("@IdProduto", Id);

            //6 recupera os registros do comando
            MySqlDataReader Reader = Comando.ExecuteReader();

            //7 percurso
            if (Reader.Read())
            {
                ProdutoEncontrado.IdProduto = Reader.GetInt32("IdProduto");
                if (!Reader.IsDBNull(Reader.GetOrdinal("NomeProduto")))
                {
                    ProdutoEncontrado.NomeProduto = Reader.GetString("NomeProduto");
                }
                if (!Reader.IsDBNull(Reader.GetOrdinal("Unidade")))
                {
                    ProdutoEncontrado.Unidade = Reader.GetString("Unidade");
                }
                ProdutoEncontrado.Quantidade = Reader.GetInt32("Quantidade");
                ProdutoEncontrado.PrecoProduto = Reader.GetDouble("PrecoProduto");
            }
            //8 fechar a conexão
            Conexao.Close();

            //9 retornar o usuário encontrado
            return ProdutoEncontrado;
        }

        //--------------------------- CADASTRAR PRODUTO ------------------------
        public void Inserir(Produto novoProd)
        {
            //Abrindo a conexao
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //passando a query
            string Query = "INSERT INTO Produto (NomeProduto,Unidade,Quantidade,PrecoProduto) VALUES (@NomeProduto,@Unidade,@Quantidade,@PrecoProduto)";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //Tratar o SQL INJECTION
            Comando.Parameters.AddWithValue("@NomeProduto", novoProd.NomeProduto);
            Comando.Parameters.AddWithValue("@Unidade", novoProd.Unidade);
            Comando.Parameters.AddWithValue("@Quantidade", novoProd.Quantidade);
            Comando.Parameters.AddWithValue("@PrecoProduto", novoProd.PrecoProduto);

            //Executar no banco
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }

        //------------------LISTAR PRODUTO ---------------------
        public List<Produto> ListaProduto()
        {
            //Abrindo a conexao
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            List<Produto> ListaDeProdutos = new List<Produto>(); //criando a lista

            //Passando a query
            string Query = "SELECT * FROM Produto";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //aqui o select é executado e guardao no objeto Read
            MySqlDataReader Reader = Comando.ExecuteReader();

            //percorrer o objeto Read com os dados retornados
            while (Reader.Read())
            {
                Produto ProdutoEncontrado = new Produto();

                ProdutoEncontrado.IdProduto = Reader.GetInt32("IdProduto");
                if (!Reader.IsDBNull(Reader.GetOrdinal("NomeProduto")))
                {
                    //tratativa para não permitir nulos
                    ProdutoEncontrado.NomeProduto = Reader.GetString("NomeProduto");
                }
                if (!Reader.IsDBNull(Reader.GetOrdinal("Unidade")))
                {
                    //tratativa para não permitir nulos
                    ProdutoEncontrado.Unidade = Reader.GetString("Unidade");
                }
                ProdutoEncontrado.Quantidade = Reader.GetInt32("Quantidade");
                ProdutoEncontrado.PrecoProduto = Reader.GetDouble("PrecoProduto");
                ListaDeProdutos.Add(ProdutoEncontrado);
            }
            Conexao.Close();
            return ListaDeProdutos;
        }
        //----------------- ATUALIZAR ------------------
        public void Atualizar(Produto prod)
        {
            //1 abrir a conecão
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //2 preparar o query
            string Query = "UPDATE Produto SET NomeProduto=@NomeProduto,Unidade=@Unidade,Quantidade=@Quantidade,PrecoProduto=@PrecoProduto WHERE IdProduto=@IdProduto";

            //3 preparar o comando
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //4 tratar o SQL INJECTION
            Comando.Parameters.AddWithValue("@IdProduto", prod.IdProduto);
            Comando.Parameters.AddWithValue("@NomeProduto", prod.NomeProduto);
            Comando.Parameters.AddWithValue("@Unidade", prod.Unidade);
            Comando.Parameters.AddWithValue("@Quantidade", prod.Quantidade);
            Comando.Parameters.AddWithValue("@PrecoProduto", prod.PrecoProduto);

            //5 executar no banco
            Comando.ExecuteNonQuery();

            //6 fechar a conexão
            Conexao.Close();
        }
        //-------------- REMOVER PRODUTO ------------
        public void Remover(Produto Prod)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
           
            string Query = "DELETE FROM Produto WHERE IdProduto=@IdProduto";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@IdProduto", Prod.IdProduto);
            Comando.ExecuteNonQuery(); //executa a query no banco
            Conexao.Close();
        }
    }
}