using System;
using System.Collections.Generic;
using MySqlConnector;

namespace Atv_4.Models
{
    public class TrabalheConoscoRepository : Repository
    {
        //----------------- BUSCAR COLABORADOR POR ID ------------------
        public TrabalheConosco BuscarPorId(int Id)
        {
            //1 abrir a conecão
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //2 criar um Usuário vazio
            TrabalheConosco CoaboraorEncontrado = new TrabalheConosco();
            //3 preparar o query
            string Query = "SELECT * FROM TrabalheConosco WHERE Id=@Id";

            //4 preparar o comando e executa
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //5 tratar o SQL INJECTION
            Comando.Parameters.AddWithValue("@Id", Id);

            //6 recupera os registros do comando
            MySqlDataReader Reader = Comando.ExecuteReader();

            //7 percurso
            if (Reader.Read())
            {
                CoaboraorEncontrado.Id = Reader.GetInt32("Id");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    CoaboraorEncontrado.Nome = Reader.GetString("Nome");
                }
                CoaboraorEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Telefone")))
                {
                    CoaboraorEncontrado.Telefone = Reader.GetString("Telefone");
                }
                if (!Reader.IsDBNull(Reader.GetOrdinal("Email")))
                {
                    CoaboraorEncontrado.Email = Reader.GetString("Email");
                }
                if (!Reader.IsDBNull(Reader.GetOrdinal("Experiencia")))
                {
                    CoaboraorEncontrado.Experiencia = Reader.GetString("Experiencia");
                }
            }
            //8 fechar a conexão
            Conexao.Close();

            //9 retornar o usuário encontrado
            return CoaboraorEncontrado;
        }

        //----------------- INSERIR -------------------
        public void Inserir(TrabalheConosco novoColab)
        {
            //Abrindo a conexao
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //passando a query
            string Query = "INSERT INTO TrabalheConosco (Nome,DataNascimento,Telefone,Email,Experiencia) VALUES (@Nome,@DataNascimento,@Telefone,@Email,@Experiencia)";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //Tratar o SQL INJECTION
            Comando.Parameters.AddWithValue("@Nome", novoColab.Nome);
            Comando.Parameters.AddWithValue("@DataNascimento", novoColab.DataNascimento);
            Comando.Parameters.AddWithValue("@Telefone", novoColab.Telefone);
            Comando.Parameters.AddWithValue("@Email", novoColab.Email);
            Comando.Parameters.AddWithValue("@Experiencia", novoColab.Experiencia);

            //Executar no banco
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }

        //----------------- ATUALIZAR COLABORADOR ------------------
        public void Atualizar(TrabalheConosco colab)
        {
            //1 abrir a conecão
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //2 preparar o query
            string Query = "UPDATE TrabalheConosco SET Nome=@Nome,DataNascimento=@DataNascimento,Telefone=@Telefone,Email=@Email,Experiencia=@Experiencia WHERE Id=@Id";

            //3 preparar o comando
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //4 tratar o SQL INJECTION
            Comando.Parameters.AddWithValue("@Id", colab.Id);
            Comando.Parameters.AddWithValue("@Nome", colab.Nome);
            Comando.Parameters.AddWithValue("@DataNascimento", colab.DataNascimento);
            Comando.Parameters.AddWithValue("@Telefone", colab.Telefone);
            Comando.Parameters.AddWithValue("@Email", colab.Email);
            Comando.Parameters.AddWithValue("@Experiencia", colab.Experiencia);

            //5 executar no banco
            Comando.ExecuteNonQuery();

            //6 fechar a conexão
            Conexao.Close();
        }

        //-------------- REMOVER COLABORADOR ------------
        public void Remover(TrabalheConosco colab)
        {
            // 1 - abrir a conexão
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            // 2 - criar a query
            string Query = "DELETE FROM TrabalheConosco WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            // 3 - SQL INJECTON
            //substituir o valor informado pela @Id, evitando que seja passado código mal intencionado
            Comando.Parameters.AddWithValue("@Id", colab.Id);
            Comando.ExecuteNonQuery(); //executa a query no banco

            // 4 - fechar a  conexão
            Conexao.Close();
        }
        
        //------------------ LISTAR  ------------------------
        public List<TrabalheConosco> Listar()
        {
           
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            List<TrabalheConosco> ListaDeColaboradores = new List<TrabalheConosco>();

            //passando a query
            string Query = "SELECT * FROM TrabalheConosco";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //aqui o select é executado e guardao no objeto Read
            MySqlDataReader Reader = Comando.ExecuteReader();

            //percorrer o objeto Read com os dados retornados
            while (Reader.Read())
            {
                TrabalheConosco ColaboradorEncontrado = new TrabalheConosco();

                ColaboradorEncontrado.Id = Reader.GetInt32("Id");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    //tratativa para não permitir nulos
                    ColaboradorEncontrado.Nome = Reader.GetString("Nome");
                }
                ColaboradorEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Telefone")))
                {
                    ColaboradorEncontrado.Telefone = Reader.GetString("Telefone");
                }
                if (!Reader.IsDBNull(Reader.GetOrdinal("Email")))
                {
                    ColaboradorEncontrado.Email = Reader.GetString("Email");
                }
                if (!Reader.IsDBNull(Reader.GetOrdinal("Experiencia")))
                {
                    ColaboradorEncontrado.Experiencia = Reader.GetString("Experiencia");
                }
                ListaDeColaboradores.Add(ColaboradorEncontrado);
            }
            Conexao.Close();
            return ListaDeColaboradores;
        }
    }
}