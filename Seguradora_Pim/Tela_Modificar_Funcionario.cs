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
            //Verificando se existe a coluna nome, se nao existir é por que nao encontrou o CPF digitado
            if (dados_funcionario.ContainsKey("nome")) {
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
            } else {
                //Nao encontrou volta a tela...
                MessageBox.Show("Funcionário não encontrado, tente novamente.", "Ops...");
                this.Close();
                this.Tela_Anterior.Show();
            }
            
        }

        private void Botao_Voltar_Click(object sender, EventArgs e) {
            this.Close();
            this.Tela_Anterior.Show();
        }

        private void Botao_Modificar_Click(object sender, EventArgs e) {
            //Recuperando valores dos textbox
            string valor_nome = Textbox_Nome.Text;
            string valor_data_nascimento = DTPicker_Data_Nascimento.Text;

            MaskedTextBox_Cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string valor_cpf_cnpj = MaskedTextBox_Cpf.Text;

            MaskedTextBox_Cnh.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string valor_cnh = MaskedTextBox_Cnh.Text;

            string valor_genero = Combobox_Genero.SelectedItem.ToString();

            MaskedTextBox_Cep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string valor_cep = MaskedTextBox_Cep.Text;

            string valor_estado = MaskedTextBox_Estado.Text;
            string valor_cidade = Textbox_Cidade.Text;
            string valor_bairro = Textbox_Bairro.Text;
            string valor_rua = Textbox_Rua.Text;
            int valor_numero = Int32.Parse(MaskedTextBox_Numero.Text);
            string valor_complemento = Textbox_Complemento.Text;

            MaskedTextBox_Celular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string valor_celular = MaskedTextBox_Celular.Text;

            string valor_email = Textbox_Email.Text;

            Funcionario obj_funcionario = new Funcionario();
            string resultado_modificar_funcionario = obj_funcionario.modificar_funcionario(valor_nome, valor_cpf_cnpj, valor_cnh, valor_genero, valor_data_nascimento, valor_cep, valor_estado, valor_cidade, valor_bairro, valor_rua, valor_numero, valor_complemento, valor_celular, valor_email);

            MessageBox.Show(resultado_modificar_funcionario, "Ok!");

            this.Close();
            this.Tela_Anterior.Show();

        }

        //instrucoes para evitar que ao entrar na text box, o cursor va para o fim
        private void MaskedTextBox_Cpf_Enter(object sender, EventArgs e) {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                MaskedTextBox_Cpf.Select(0, 0);
            });
        }

        private void MaskedTextBox_Cnh_Enter(object sender, EventArgs e) {
            this.BeginInvoke((MethodInvoker)delegate () {
                MaskedTextBox_Cnh.Select(0, 0);
            });
        }

        private void MaskedTextBox_Cep_Enter(object sender, EventArgs e) {
            this.BeginInvoke((MethodInvoker)delegate () {
                MaskedTextBox_Cep.Select(0, 0);
            });
        }

        private void MaskedTextBox_Estado_Enter(object sender, EventArgs e) {
            this.BeginInvoke((MethodInvoker)delegate () {
                MaskedTextBox_Estado.Select(0, 0);
            });
        }

        private void MaskedTextBox_Numero_Enter(object sender, EventArgs e) {
            this.BeginInvoke((MethodInvoker)delegate () {
                MaskedTextBox_Numero.Select(0, 0);
            });
        }

        private void MaskedTextBox_Celular_Enter(object sender, EventArgs e) {
            this.BeginInvoke((MethodInvoker)delegate () {
                MaskedTextBox_Celular.Select(0, 0);
            });
        }
    }
}
