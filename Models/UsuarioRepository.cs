using System;
using System.Collections.Generic;
using MySqlConnector;

namespace Atv_4.Models
{
    public class UsuarioRepository : Repository
    {
        //métodos, informações
        //testar a conexao com o banco de dados
    
        public void TestarConexao()
        {
            //Aqui eu testo a conexão com o banco de dados

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);

            Conexao.Open(); //abre a conexão com o banco
            Console.WriteLine("Banco de Dados funcionando");
            Conexao.Close(); //fecha a conexão com o banco
        }

        //------------- VALIDAR LOGIN -----------------
        public Usuario ValidarLogin(Usuario user)
        {
            //1 abrir a conecão
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //2 criar um Usuário vazio
            Usuario UsuarioEncontrado = null;
            //3 preparar o query
            string Query="SELECT * FROM Usuario WHERE Login=@Login And Senha=@Senha";

            //4 preparar o comando e executa
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //5 tratar o SQL INJECTION
            Comando.Parameters.AddWithValue("@Login", user.Login);
            Comando.Parameters.AddWithValue("@Senha", user.Senha);

            //6 recupera os registros do comando
            MySqlDataReader Reader = Comando.ExecuteReader();

            //7 percurso
            if (Reader.Read())
            {
                UsuarioEncontrado= new Usuario();
                UsuarioEncontrado.Id=Reader.GetInt32("Id");
                
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    UsuarioEncontrado.Nome=Reader.GetString("Nome");
                }
                
                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                {
                    UsuarioEncontrado.Login=Reader.GetString("Login");
                }
                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                {
                    UsuarioEncontrado.Senha=Reader.GetString("Senha");
                }
            }
            Conexao.Close();
            //retornar o usuário encontrado
            return UsuarioEncontrado;
        }
        //----------------- BUSCAR POR ID ------------------
        public Usuario BuscarPorId(int Id)
        {
            //1 abrir a conecão
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //2 criar um Usuário vazio
            Usuario UsuarioEncontrado = new Usuario();
            //3 preparar o query
            string Query="SELECT * FROM Usuario WHERE Id=@Id";

            //4 preparar o comando e executa
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //5 tratar o SQL INJECTION
            Comando.Parameters.AddWithValue("@Id", Id);

            //6 recupera os registros do comando
            MySqlDataReader Reader = Comando.ExecuteReader();

            //7 percurso
            if (Reader.Read())
            {
                UsuarioEncontrado.Id=Reader.GetInt32("Id");
                
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    UsuarioEncontrado.Nome=Reader.GetString("Nome");
                }
                
                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                {
                    UsuarioEncontrado.Login=Reader.GetString("Login");
                }
                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                {
                    UsuarioEncontrado.Senha=Reader.GetString("Senha");
                }
            }
            Conexao.Close();

            //retornar o usuário encontrado
            return UsuarioEncontrado;
        }
       //----------------- INSERIR ------------------
        public void Inserir(Usuario novoUser)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            string Query = "INSERT INTO Usuario (Nome,Login,Senha) VALUES (@Nome,@Login,@Senha)";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //SQL INJECTION
            Comando.Parameters.AddWithValue("@Nome", novoUser.Nome);
            Comando.Parameters.AddWithValue("@Login", novoUser.Login);
            Comando.Parameters.AddWithValue("@Senha", novoUser.Senha);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        //----------------- ATUALIZAR ------------------
        public void Atualizar(Usuario user)
        {
            //1 abrir a conecão
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //2 preparar o query
            string Query = "UPDATE Usuario SET Nome=@Nome,Login=@Login,Senha=@Senha WHERE Id=@Id";


            //3 preparar o comando
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //4 tratar o SQL INJECTION
            Comando.Parameters.AddWithValue("@Id", user.Id);
            Comando.Parameters.AddWithValue("@Nome", user.Nome);
            Comando.Parameters.AddWithValue("@Login", user.Login);
            Comando.Parameters.AddWithValue("@Senha", user.Senha);
            
            //5 executar no banco
            Comando.ExecuteNonQuery();

            //6 fechar a conexão
            Conexao.Close();
        }

        //-------------- REMOVER USUÁRIO ------------
        public void Remover(Usuario user)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
           
            string Query = "DELETE FROM Usuario WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //SQL INJECTON
            //substituir o valor informado pela @Id, evitando que seja passado código mal intencionado
            Comando.Parameters.AddWithValue("@Id", user.Id);
            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        //------------ LISTAR USUÁRIO -----------------
        public List<Usuario> Lista()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            List<Usuario> ListaDeUsuarios = new List<Usuario>(); //criando a lista

            string Query = "SELECT * FROM Usuario";
            //passando a query
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //aqui o select é executado e guardao no objeto Read
            MySqlDataReader Reader = Comando.ExecuteReader();

            //percorrer o objeto Read com os dados retornados
            while (Reader.Read())
            {
                Usuario UsuarioEncontrado = new Usuario();

                UsuarioEncontrado.Id = Reader.GetInt32("Id");
                
                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                {
                    //tratativa para não permitir nulos
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                }
                
                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                {
                    UsuarioEncontrado.Login = Reader.GetString("Login");
                }

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                {
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");
                }
                ListaDeUsuarios.Add(UsuarioEncontrado);
            }
            Conexao.Close();
            return ListaDeUsuarios;
        }
    }
}