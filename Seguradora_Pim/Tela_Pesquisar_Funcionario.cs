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
        public object Responsavel_Chamada {
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
        private void Tela_Pesquisar_Funcionario_Load(object sender, EventArgs e) {
            string quem_Chamou = this.Responsavel_Chamada.ToString();
            Debug.WriteLine(quem_Chamou);
        }
    }
}
