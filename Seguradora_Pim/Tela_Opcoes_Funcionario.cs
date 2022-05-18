using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguradora_Pim {
    public partial class Tela_Opcoes_Funcionario : Form {
        public Tela_Opcoes_Funcionario() {
            InitializeComponent();
        }

        private void Container_Principal_Paint(object sender, PaintEventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void Botao_Cadastrar_Funcionario_Click(object sender, EventArgs e) {
            var tela = new Tela_Cadastro_Funcionario();
            tela.Show();
        }

        private void Botao_Modificar_Funcionario_Click(object sender, EventArgs e) {

        }

        private void Botao_Informacoes_Funcionario_Click(object sender, EventArgs e) {

        }

        private void Botao_Deletar_Funcionario_Click(object sender, EventArgs e) {

        }
    }
}
