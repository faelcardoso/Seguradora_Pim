using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Diagnostics;

namespace Seguradora_Pim {
    public class Funcionario {
        private string str_conn { get; set; } = "Host=localhost;Username=postgres;Password=postgres;Database=db_seguradora";

        //Cadastrar informações do funcionario
        public string cadastrar_funcionario(string nome, string cpf_cnpj, string cnh, string genero, string data_nascimento, string cep, string estado, string cidade, string bairro, string rua, int numero, string complemento, string celular, string email, string senha_funcionario) {
            
            //Variavel de retorno
            string mensagem_resposta = "Funcionário cadastrado com sucesso!";
            //String query inserir Pessoa
            string str_cmd_cadastrar_pessoa =
            "INSERT INTO " +
            "tb_pessoa " +
            "(nome, " +
            "cpf_cnpj, " +
            "cnh, " +
            "genero, " +
            "data_nascimento, " +
            "cep, " +
            "estado, " +
            "cidade, " +
            "bairro, " +
            "rua, " +
            "numero, " +
            "complemento, " +
            "celular, " +
            "email) VALUES (@nome, @cpf_cnpj, @cnh, '"+genero+"', '"+data_nascimento+"', @cep, @estado, @cidade, @bairro, @rua,@numero, @complemento, @celular, @email);";

            //Conexao banco de dados
            NpgsqlConnection conn = new NpgsqlConnection(str_conn);
            conn.Open();

            //Comando de cadastro
            NpgsqlCommand cmd_cadastrar_pessoa = new NpgsqlCommand(str_cmd_cadastrar_pessoa, conn);
            cmd_cadastrar_pessoa.Parameters.AddWithValue("nome", nome);
            cmd_cadastrar_pessoa.Parameters.AddWithValue("cpf_cnpj", cpf_cnpj);
            cmd_cadastrar_pessoa.Parameters.AddWithValue("cnh", cnh);
            cmd_cadastrar_pessoa.Parameters.AddWithValue("genero", genero.ToString());
            cmd_cadastrar_pessoa.Parameters.AddWithValue("data_nascimento", data_nascimento);
            cmd_cadastrar_pessoa.Parameters.AddWithValue("cep", cep);
            cmd_cadastrar_pessoa.Parameters.AddWithValue("estado", estado);
            cmd_cadastrar_pessoa.Parameters.AddWithValue("cidade", cidade);
            cmd_cadastrar_pessoa.Parameters.AddWithValue("bairro", bairro);
            cmd_cadastrar_pessoa.Parameters.AddWithValue("rua", rua);
            cmd_cadastrar_pessoa.Parameters.AddWithValue("numero", numero);
            cmd_cadastrar_pessoa.Parameters.AddWithValue("complemento", complemento);
            cmd_cadastrar_pessoa.Parameters.AddWithValue("celular", celular);
            cmd_cadastrar_pessoa.Parameters.AddWithValue("email", email);

            //Executando query
            int cmd_cadastrar_pessoa_res = cmd_cadastrar_pessoa.ExecuteNonQuery();

            conn.Close();

            if  (cmd_cadastrar_pessoa_res == 1) {

                conn.Open();

                //Verificando a pessoa cadastrada e recuperando seu id para usar na foreign key na hora de inserir os dados de funcionario
                string str_cmd_info_pessoa =
                "SELECT id " +
                "FROM " +
                "tb_pessoa " +
                "where tb_pessoa.cpf_cnpj = @cpf_cnpj";

                //Comando
                NpgsqlCommand cmd_info_pessoa = new NpgsqlCommand(str_cmd_info_pessoa, conn);
                cmd_info_pessoa.Parameters.AddWithValue("cpf_cnpj", cpf_cnpj);

                //Executar leitura
                NpgsqlDataReader cmd_info_pessoa_reader = cmd_info_pessoa.ExecuteReader();
                cmd_info_pessoa_reader.Read();
                int cmd_info_pessoa_res_id = cmd_info_pessoa_reader.GetInt32(0);

                conn.Close();

                conn.Open();

                //Query string Inserir Funcionario
                Debug.WriteLine(cmd_info_pessoa_res_id);

                string str_cmd_cadastrar_funcionario =
                "INSERT INTO " +
                "tb_funcionario " +
                "(id_pessoa, " +
                "senha_funcionario) VALUES ('" + cmd_info_pessoa_res_id + "', @senha_funcionario)";

                //Comando
                NpgsqlCommand cmd_cadastrar_funcionario = new NpgsqlCommand(str_cmd_cadastrar_funcionario, conn);
                cmd_cadastrar_funcionario.Parameters.AddWithValue("id_pessoa", cmd_info_pessoa_res_id);
                cmd_cadastrar_funcionario.Parameters.AddWithValue("senha_funcionario", senha_funcionario);

                int cmd_cadastrar_funcionario_res = cmd_cadastrar_funcionario.ExecuteNonQuery();

                conn.Close();

            } else {
                //Nao cadastrou
                mensagem_resposta = "Falha ao cadastrar o Funcionário.";
                conn.Close();
                return mensagem_resposta;
            }

            //Cadastrou o funcionario
            conn.Close();
            return mensagem_resposta;
        }
        //Listar informacoes do funcionario
        public Dictionary<string, string> listar_funcionario(string Cpf) {
            //Variavel de retorno do Dicionario com os Valores
            Dictionary<string, string> dict_dados_funcionario = new Dictionary<string, string>();
            //Strings de query
            string str_cmd_listar_funcionario =
            "SELECT " +
            "id," +
            "nome," +
            "cpf_cnpj," +
            "cnh," +
            "genero," +
            "data_nascimento," +
            "cep," +
            "estado," +
            "cidade," +
            "bairro," +
            "rua," +
            "numero," +
            "complemento," +
            "celular," +
            "email " +
            "FROM tb_pessoa WHERE cpf_cnpj = @Cpf";

            //Conectando
            NpgsqlConnection conn = new NpgsqlConnection(str_conn);
            conn.Open();

            //Efetuando Query
            NpgsqlCommand cmd_listar_funcionario = new NpgsqlCommand(str_cmd_listar_funcionario, conn);
            cmd_listar_funcionario.Parameters.AddWithValue("Cpf", Cpf);
            NpgsqlDataReader cmd_listar_funcionario_reader = cmd_listar_funcionario.ExecuteReader();

            //Lendo dados retorno
            while (cmd_listar_funcionario_reader.Read()) {
                var linhas = cmd_listar_funcionario_reader.FieldCount;
                for (int i = 0; i < linhas; i++) {
                    dict_dados_funcionario.Add(cmd_listar_funcionario_reader.GetName(i).ToString(), cmd_listar_funcionario_reader.GetValue(i).ToString());
                }
            }

            conn.Close();
            return dict_dados_funcionario;

        }

        public string modificar_funcionario(string nome, string cpf_cnpj, string cnh, string genero, string data_nascimento, string cep, string estado, string cidade, string bairro, string rua, int numero, string complemento, string celular, string email) {
            //Variavel de retorno
            string mensagem_resposta = "Funcionário modificado com sucesso!";
            //String query inserir Pessoa
            string str_cmd_modificar_pessoa =
            "UPDATE " +
            "tb_pessoa " +
            "SET " +
            "nome = @nome, " +
            "cpf_cnpj = @cpf_cnpj, " +
            "cnh = @cnh, " +
            "genero = '"+genero+"', " +
            "data_nascimento = '"+data_nascimento+"', " +
            "cep = @cep, " +
            "estado = @estado, " +
            "cidade = @cidade, " +
            "bairro = @bairro, " +
            "rua = @rua, " +
            "numero = @numero, " +
            "complemento = @complemento, " +
            "celular = @celular, " +
            "email = @email " +
            "WHERE tb_pessoa.cpf_cnpj = @cpf_cnpj";

            //Conexao
            NpgsqlConnection conn = new NpgsqlConnection(str_conn);
            conn.Open();

            //Comando
            NpgsqlCommand cmd_modificar_pessoa = new NpgsqlCommand(str_cmd_modificar_pessoa, conn);
            cmd_modificar_pessoa.Parameters.AddWithValue("nome", nome);
            cmd_modificar_pessoa.Parameters.AddWithValue("cpf_cnpj", cpf_cnpj);
            cmd_modificar_pessoa.Parameters.AddWithValue("cnh", cnh);
            cmd_modificar_pessoa.Parameters.AddWithValue("cep", cep);
            cmd_modificar_pessoa.Parameters.AddWithValue("estado", estado);
            cmd_modificar_pessoa.Parameters.AddWithValue("cidade", cidade);
            cmd_modificar_pessoa.Parameters.AddWithValue("bairro", bairro);
            cmd_modificar_pessoa.Parameters.AddWithValue("rua", rua);
            cmd_modificar_pessoa.Parameters.AddWithValue("numero", numero);
            cmd_modificar_pessoa.Parameters.AddWithValue("complemento", complemento);
            cmd_modificar_pessoa.Parameters.AddWithValue("celular", celular);
            cmd_modificar_pessoa.Parameters.AddWithValue("email", email);

            //Executando
            int cmd_modificar_pessoa_res = cmd_modificar_pessoa.ExecuteNonQuery();

            if (cmd_modificar_pessoa_res != 1) {
                mensagem_resposta = "Usuário não foi modificado.";
                return mensagem_resposta;
            }

            conn.Close();
            return mensagem_resposta;

        }

        public string deletar_funcionario (string cpf_cnpj) {
            //Variavel de retorno
            string mensagem_resposta = "Funcionário deletado com sucesso!";
            //String query inserir Pessoa
            string str_cmd_modificar_pessoa =
            "DELETE FROM " +
            "tb_pessoa " +
            "WHERE tb_pessoa.cpf_cnpj = @cpf_cnpj";

            //Conexao
            NpgsqlConnection conn = new NpgsqlConnection(str_conn);
            conn.Open();

            //Comando
            NpgsqlCommand cmd_deletar_funcionario = new NpgsqlCommand(str_cmd_modificar_pessoa, conn);
            cmd_deletar_funcionario.Parameters.AddWithValue("cpf_cnpj", cpf_cnpj);
            int cmd_deletar_funcionario_res = cmd_deletar_funcionario.ExecuteNonQuery();

            //Verificando se alteração foi feita em somente UMA linha
            if (cmd_deletar_funcionario_res != 1) {
                mensagem_resposta = "Usuário não foi deletado.";
                conn.Close();
                return mensagem_resposta;
            }

            conn.Close();
            return mensagem_resposta;
        }
    }
}
