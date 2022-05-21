using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguradora_Pim {
    public partial class Tela_Informacoes_Funcionario : Form {
        public Tela_Informacoes_Funcionario() {
            InitializeComponent();
        }

        public Form Tela_Anterior {
            get;
            set;
        }

        public string Cpf_Funcionario {
            get;
            set;
        }

        private void Tela_Informacoes_Funcionario_Load(object sender, EventArgs e) {
            Funcionario obj_funcionario = new Funcionario();
            Dictionary<string, string> dados_funcionario = obj_funcionario.listar_funcionario(this.Cpf_Funcionario);
            List<string> valores_dados_funcionario = dados_funcionario.Values.ToList();
            DataGridViewRow linha_data_grid = (DataGridViewRow) DataGrid_Info_Funcionario.Rows[0].Clone();
            //Variavel para iteração
            int i = 0;
            //Iteraçao
            foreach (var valor in valores_dados_funcionario) {
                linha_data_grid.Cells[i].Value = valor.ToString();
                if (i <= valores_dados_funcionario.Count) {
                    i++;
                }
            }
            DataGrid_Info_Funcionario.Rows.Add(linha_data_grid);
        }

        private void Botao_Voltar_Click(object sender, EventArgs e) {
            this.Close();
            this.Tela_Anterior.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
