using System;
using System.Collections.Generic;
using MySqlConnector;

namespace Atv_4.Models
{
    public class ServicoRepository : Repository
    {
          //----------------- BUSCAR SERVIÇO POR ID ------------------
        public Servico BuscarPorId(int Id)
        {
            //1 abrir a conecão
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //2 criar um Usuário vazio
            Servico ServicoEncontrado = new Servico();
            //3 preparar o query
            string Query = "SELECT * FROM Servico WHERE IdServico=@IdServico";

            //4 preparar o comando e executa
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //5 tratar o SQL INJECTION
            Comando.Parameters.AddWithValue("@IdServico", Id);

            //6 recupera os registros do comando
            MySqlDataReader Reader = Comando.ExecuteReader();

            //7 percurso
            if (Reader.Read())
            {
                ServicoEncontrado.IdServico = Reader.GetInt32("IdServico");
                if (!Reader.IsDBNull(Reader.GetOrdinal("NomeServico")))
                {
                    ServicoEncontrado.NomeServico = Reader.GetString("NomeServico");
                }
                ServicoEncontrado.PrecoServico = Reader.GetDouble("PrecoServico");
            }
            //8 fechar a conexão
            Conexao.Close();

            //9 retornar o usuário encontrado
            return ServicoEncontrado;
        }
         //--------------------------- CADASTRAR SERVIÇO ------------------------
        public void Inserir(Servico novoServ)
        {
            //Abrindo a conexao
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            //passando a query
            string Query = "INSERT INTO Servico (NomeServico,PrecoServico) VALUES (@NomeServico,@PrecoServico)";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //Tratar o SQL INJECTION
            Comando.Parameters.AddWithValue("@NomeServico", novoServ.NomeServico);
            Comando.Parameters.AddWithValue("@PrecoServico", novoServ.PrecoServico);

            //Executar no banco
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }
        //--------------------------- LISTAR SERVIÇO ------------------------
        public List<Servico> Listar()
        {
            //Abrindo a conexao
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            List<Servico> ListaDeServicos = new List<Servico>(); //criando a lista

            //passando a query
            string Query = "SELECT * FROM Servico";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //aqui o select é executado e guardao no objeto Read
            MySqlDataReader Reader = Comando.ExecuteReader();

            //percorrer o objeto Read com os dados retornados
            while (Reader.Read())
            {
                Servico ServicoEncontrado = new Servico();

                ServicoEncontrado.IdServico = Reader.GetInt32("IdServico");
                if (!Reader.IsDBNull(Reader.GetOrdinal("NomeServico")))
                {
                    //tratativa para não permitir nulos
                    ServicoEncontrado.NomeServico = Reader.GetString("NomeServico");
                }
                ServicoEncontrado.PrecoServico = Reader.GetDouble("PrecoServico");
                ListaDeServicos.Add(ServicoEncontrado);
            }
            Conexao.Close();
            return ListaDeServicos;
        }
        //----------------- ATUALIZAR ------------------
        public void Atualizar(Servico serv)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            string Query = "UPDATE Servico SET NomeServico=@NomeServico,PrecoServico=@PrecoServico WHERE IdServico=@IdServico";

            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@IdServico", serv.IdServico);
            Comando.Parameters.AddWithValue("@NomeServico", serv.NomeServico);
            Comando.Parameters.AddWithValue("@PrecoServico", serv.PrecoServico);
            
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }
        //-------------- REMOVER SERVIÇO ------------
        public void Remover(Servico Serv)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
           
            string Query = "DELETE FROM Servico WHERE IdServico=@IdServico";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            Comando.Parameters.AddWithValue("@IdServico", Serv.IdServico);
            Comando.ExecuteNonQuery(); 
            Conexao.Close();
        }
    }
}