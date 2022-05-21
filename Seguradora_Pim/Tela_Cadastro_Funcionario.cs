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
            System.Windows.Forms.MessageBox.Show("Funcionário Cadastrado com Sucesso!");
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
