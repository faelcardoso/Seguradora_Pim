namespace Seguradora_Pim {
    partial class Tela_Cadastro_Funcionario {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Cabecalho = new System.Windows.Forms.Panel();
            this.Titulo_Cabecalho = new System.Windows.Forms.Label();
            this.Container_Principal = new System.Windows.Forms.Panel();
            this.Titulo_Pagina = new System.Windows.Forms.Label();
            this.Cabecalho.SuspendLayout();
            this.Container_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cabecalho
            // 
            this.Cabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Cabecalho.Controls.Add(this.Titulo_Cabecalho);
            this.Cabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cabecalho.Location = new System.Drawing.Point(0, 0);
            this.Cabecalho.Margin = new System.Windows.Forms.Padding(2);
            this.Cabecalho.Name = "Cabecalho";
            this.Cabecalho.Size = new System.Drawing.Size(800, 58);
            this.Cabecalho.TabIndex = 1;
            // 
            // Titulo_Cabecalho
            // 
            this.Titulo_Cabecalho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Titulo_Cabecalho.AutoSize = true;
            this.Titulo_Cabecalho.BackColor = System.Drawing.Color.Transparent;
            this.Titulo_Cabecalho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Cabecalho.ForeColor = System.Drawing.Color.White;
            this.Titulo_Cabecalho.Location = new System.Drawing.Point(285, 20);
            this.Titulo_Cabecalho.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo_Cabecalho.Name = "Titulo_Cabecalho";
            this.Titulo_Cabecalho.Size = new System.Drawing.Size(245, 19);
            this.Titulo_Cabecalho.TabIndex = 1;
            this.Titulo_Cabecalho.Text = "Sistema de Gerenciamento de Apólices";
            // 
            // Container_Principal
            // 
            this.Container_Principal.AutoSize = true;
            this.Container_Principal.CausesValidation = false;
            this.Container_Principal.Controls.Add(this.Titulo_Pagina);
            this.Container_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container_Principal.Location = new System.Drawing.Point(0, 58);
            this.Container_Principal.Name = "Container_Principal";
            this.Container_Principal.Size = new System.Drawing.Size(800, 392);
            this.Container_Principal.TabIndex = 2;
            this.Container_Principal.Paint += new System.Windows.Forms.PaintEventHandler(this.Container_Principal_Paint);
            // 
            // Titulo_Pagina
            // 
            this.Titulo_Pagina.AutoSize = true;
            this.Titulo_Pagina.BackColor = System.Drawing.Color.Transparent;
            this.Titulo_Pagina.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Pagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Titulo_Pagina.Location = new System.Drawing.Point(332, 18);
            this.Titulo_Pagina.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.Titulo_Pagina.Name = "Titulo_Pagina";
            this.Titulo_Pagina.Size = new System.Drawing.Size(136, 17);
            this.Titulo_Pagina.TabIndex = 0;
            this.Titulo_Pagina.Text = "Cadastrar Funcionário";
            this.Titulo_Pagina.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tela_Cadastro_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Container_Principal);
            this.Controls.Add(this.Cabecalho);
            this.Name = "Tela_Cadastro_Funcionario";
            this.Text = "Tela_Cadastro_Funcionario";
            this.Cabecalho.ResumeLayout(false);
            this.Cabecalho.PerformLayout();
            this.Container_Principal.ResumeLayout(false);
            this.Container_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Cabecalho;
        private System.Windows.Forms.Label Titulo_Cabecalho;
        private System.Windows.Forms.Panel Container_Principal;
        private System.Windows.Forms.Label Titulo_Pagina;
    }
}