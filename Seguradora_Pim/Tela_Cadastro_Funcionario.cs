using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Npgsql;

namespace Seguradora_Pim {
    public partial class Tela_Cadastro_Funcionario : Form {
        public Tela_Cadastro_Funcionario() {
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

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Container_Principal_Paint(object sender, PaintEventArgs e) {

        }

        private void Label_Nome_Click(object sender, EventArgs e) {

        }

        private void Titulo_Cabecalho_Click(object sender, EventArgs e) {

        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void Cabecalho_Paint(object sender, PaintEventArgs e) {

        }

        private void Container_Principal_Paint_1(object sender, PaintEventArgs e) {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e) {

        }

        private void Botao_Cadastrar_Click(object sender, EventArgs e) {
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
            string valor_senha_funcionario = MaskedTextBox_Senha.Text;
            string confirmar_senha = MaskedTextBox_Confirmar_Senha.Text;

            Debug.WriteLine(valor_senha_funcionario);
            Debug.WriteLine(confirmar_senha);

            if (confirmar_senha == valor_senha_funcionario) {

                Funcionario obj_funcionario = new Funcionario();
                
                string resultado_cadastro_funcionario = obj_funcionario.cadastrar_funcionario(valor_nome, valor_cpf_cnpj, valor_cnh, valor_genero, valor_data_nascimento, valor_cep, valor_estado, valor_cidade, valor_bairro, valor_rua, valor_numero, valor_complemento, valor_celular, valor_email, valor_senha_funcionario);

                System.Windows.Forms.MessageBox.Show(resultado_cadastro_funcionario);

                this.Close();
                this.Tela_Anterior.Show();

            } else {
                System.Windows.Forms.MessageBox.Show("As senhas não coincidem, por favor, tente novamente.");
            }
        }

        private void Botao_Voltar_Click(object sender, EventArgs e) {
            this.Close();
            this.Tela_Anterior.Show();
        }

        private void Tela_Cadastro_Funcionario_Load(object sender, EventArgs e) {

        }

        private void label1_Click_1(object sender, EventArgs e) {

        }
    }
}
