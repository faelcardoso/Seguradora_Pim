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
    public partial class Tela_Modificar_Funcionario : Form {
        public Tela_Modificar_Funcionario() {
            InitializeComponent();
            //Criando o objeto Para Genero
            Enum_Type genero = new Enum_Type();
            Array array_genero = genero.Carregar_Genero();
            //Armazenando os valores na combobox
            foreach (var item in array_genero) {
                Combobox_Genero.Items.Add(item);
            }
        }

        public Form Tela_Anterior {
            get;
            set;
        }

        public string Cpf_Funcionario {
            get;
            set;
        }

        private void Titulo_Tela_Click(object sender, EventArgs e) {

        }

        private void Tela_Modificar_Funcionario_Load(object sender, EventArgs e) {
            Funcionario obj_funcionario = new Funcionario();
            Dictionary<string, string> dados_funcionario = obj_funcionario.listar_funcionario(this.Cpf_Funcionario);
            //Preenchendo campos com os valores do banco
            Textbox_Nome.Text = dados_funcionario["nome"].ToString();
            DTPicker_Data_Nascimento.Text = dados_funcionario["data_nascimento"].ToString();
            MaskedTextBox_Cpf.Text = dados_funcionario["cpf_cnpj"].ToString();
            MaskedTextBox_Cnh.Text = dados_funcionario["cnh"].ToString();
            Combobox_Genero.SelectedItem = dados_funcionario["genero"].ToString();
            MaskedTextBox_Cep.Text = dados_funcionario["cep"].ToString();
            Textbox_Cidade.Text = dados_funcionario["cidade"].ToString();
            MaskedTextBox_Estado.Text = dados_funcionario["estado"].ToString();
            Textbox_Bairro.Text = dados_funcionario["bairro"].ToString();
            Textbox_Rua.Text = dados_funcionario["rua"].ToString();
            MaskedTextBox_Numero.Text = dados_funcionario["numero"].ToString();
            Textbox_Complemento.Text = dados_funcionario["complemento"].ToString();
            MaskedTextBox_Celular.Text = dados_funcionario["celular"].ToString();
            Textbox_Email.Text = dados_funcionario["email"].ToString();
        }

        private void Botao_Voltar_Click(object sender, EventArgs e) {
            this.Close();
            this.Tela_Anterior.Show();
        }
    }
}
