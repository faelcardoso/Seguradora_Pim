using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Seguradora_Pim {
    public class Enum_Type {

        public Array Carregar_Genero() {
            //Abrindo conexao
            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=db_seguradora");
            conn.Open();
            //Executando query
            string genero_npsql = "SELECT unnest(enum_range(NULL::genero))::text AS genero order by genero asc";
            NpgsqlCommand genero_npsql_comm = new NpgsqlCommand(genero_npsql, conn);
            //Recuperando dados
            NpgsqlDataReader genero_npgsql_execHead = genero_npsql_comm.ExecuteReader();
            //Variavel de retorno
            List<string> lista_genero = new List<string>();

            while (genero_npgsql_execHead.Read()) {
                object valor_genero = genero_npgsql_execHead.GetValue(0);
                lista_genero.Add(valor_genero.ToString());
            }

            Array array_genero = lista_genero.ToArray();

            conn.Close();

            return array_genero;
        }



    }
}
