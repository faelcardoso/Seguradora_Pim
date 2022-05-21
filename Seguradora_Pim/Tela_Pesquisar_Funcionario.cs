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

namespace Seguradora_Pim {
    public partial class Tela_Pesquisar_Funcionario : Form {
        public Tela_Pesquisar_Funcionario() {
            InitializeComponent();
        }
        //Variavel usada para voltar a tela
        public Form Tela_Anterior {
            get;
            set;
        }
        //Variavel usada para Verificar quem chamou essa tela.
        public string Responsavel_Chamada {
            get;
            set;

        }
        private void Cabecalho_Paint(object sender, PaintEventArgs e) {

        }

        private void Botao_Cancelar_Click(object sender, EventArgs e) {
            this.Close();
            this.Tela_Anterior.Show();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }
        //TODO - Verificar qual botão enviou a chamada, assim será possível fazer um redirecionamento dinamico entre Forms...
        private void Botao_Pesquisar_Click(object sender, EventArgs e) {
            string responsavel_chamada = this.Responsavel_Chamada;

            switch (responsavel_chamada) {
                case "Botao_Informacoes_Funcionario":

                    Tela_Informacoes_Funcionario tela_informacoes_funcionario = new Tela_Informacoes_Funcionario();

                    //Removendo mascara de caixa de texto
                    MaskedTextBox_Cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    //Atribuindo Cpf digitado para fazer a lógica da tela de info.
                    tela_informacoes_funcionario.Cpf_Funcionario = MaskedTextBox_Cpf.Text;
                    //Salvando tela para fazer a lógica de "Voltar"
                    tela_informacoes_funcionario.Tela_Anterior = this;
                    this.Hide();
                    tela_informacoes_funcionario.Show();

                break;

                case "Botao_Modificar_Funcionario":
                    //Mesma logica seguida ali em cima
                    Tela_Modificar_Funcionario tela_modificar_funcionario = new Tela_Modificar_Funcionario();
                    MaskedTextBox_Cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    tela_modificar_funcionario.Tela_Anterior = this;
                    tela_modificar_funcionario.Cpf_Funcionario = MaskedTextBox_Cpf.Text;
                    this.Hide();
                    tela_modificar_funcionario.Show();

                break;

                case "Botao_Deletar_Funcionario":
                    System.Windows.Forms.MessageBox.Show("Deletou!");
                    break;
                default:
                    break;
            }
        }

        private void Tela_Pesquisar_Funcionario_Load(object sender, EventArgs e) {

        }
    }
}
