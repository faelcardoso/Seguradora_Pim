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
    public partial class Tela_Modificar_Funcionario : Form {
        public Tela_Modificar_Funcionario() {
            InitializeComponent();
        }

        public Form Tela_Anterior {
            get;
            set;
        }

        private void Titulo_Tela_Click(object sender, EventArgs e) {

        }

        private void Tela_Modificar_Funcionario_Load(object sender, EventArgs e) {

        }

        private void Botao_Voltar_Click(object sender, EventArgs e) {
            this.Close();
            this.Tela_Anterior.Show();
        }
    }
}
