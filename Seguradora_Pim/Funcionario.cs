using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Diagnostics;

namespace Seguradora_Pim {
    public class Funcionario {


        public Dictionary<string, string> listar_funcionario(string Cpf) {
            //Variavel de retorno do Dicionario com os Valores
            Dictionary<string, string> dict_dados_funcionario = new Dictionary<string, string>();
            //Strings de query e conexao
            string str_cmd_listar_funcionario =
            "SELECT " +
            "id," +
            "nome, " +
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
            "email " +
            "FROM tb_pessoa WHERE cpf_cnpj = @Cpf";

            string str_conn = "Host=localhost;Username=postgres;Password=postgres;Database=db_seguradora";
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
            Debug.WriteLine(dict_dados_funcionario);
            return dict_dados_funcionario;

        }
    }
}
