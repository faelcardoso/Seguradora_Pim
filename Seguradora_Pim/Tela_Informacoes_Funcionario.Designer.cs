namespace Seguradora_Pim {
    partial class Tela_Informacoes_Funcionario {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Container_Principal = new System.Windows.Forms.Panel();
            this.DataGrid_Info_Funcionario = new System.Windows.Forms.DataGridView();
            this.Botao_Voltar = new System.Windows.Forms.Button();
            this.Titulo_Tela = new System.Windows.Forms.Label();
            this.Cabecalho = new System.Windows.Forms.Panel();
            this.Titulo_Cabecalho = new System.Windows.Forms.Label();
            this.Coluna_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Cpf_Cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Cnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Data_Nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Container_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Info_Funcionario)).BeginInit();
            this.Cabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container_Principal
            // 
            this.Container_Principal.AutoScroll = true;
            this.Container_Principal.AutoSize = true;
            this.Container_Principal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Container_Principal.Controls.Add(this.DataGrid_Info_Funcionario);
            this.Container_Principal.Controls.Add(this.Botao_Voltar);
            this.Container_Principal.Controls.Add(this.Titulo_Tela);
            this.Container_Principal.Controls.Add(this.Cabecalho);
            this.Container_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container_Principal.Location = new System.Drawing.Point(0, 0);
            this.Container_Principal.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.Container_Principal.Name = "Container_Principal";
            this.Container_Principal.Size = new System.Drawing.Size(1712, 698);
            this.Container_Principal.TabIndex = 2;
            // 
            // DataGrid_Info_Funcionario
            // 
            this.DataGrid_Info_Funcionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid_Info_Funcionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGrid_Info_Funcionario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGrid_Info_Funcionario.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid_Info_Funcionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid_Info_Funcionario.ColumnHeadersHeight = 54;
            this.DataGrid_Info_Funcionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coluna_Id,
            this.Coluna_Nome,
            this.Coluna_Cpf_Cnpj,
            this.Coluna_Cnh,
            this.Coluna_Genero,
            this.Coluna_Data_Nascimento,
            this.Coluna_Cep,
            this.Coluna_Estado,
            this.Coluna_Cidade,
            this.Coluna_Bairro,
            this.Coluna_Rua,
            this.Coluna_Numero,
            this.Coluna_Complemento,
            this.Coluna_Celular,
            this.Coluna_Email});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid_Info_Funcionario.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid_Info_Funcionario.Location = new System.Drawing.Point(62, 162);
            this.DataGrid_Info_Funcionario.Name = "DataGrid_Info_Funcionario";
            this.DataGrid_Info_Funcionario.RowHeadersWidth = 64;
            this.DataGrid_Info_Funcionario.RowTemplate.Height = 24;
            this.DataGrid_Info_Funcionario.Size = new System.Drawing.Size(1588, 92);
            this.DataGrid_Info_Funcionario.TabIndex = 12;
            this.DataGrid_Info_Funcionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Botao_Voltar
            // 
            this.Botao_Voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Botao_Voltar.AutoEllipsis = true;
            this.Botao_Voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Botao_Voltar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Botao_Voltar.FlatAppearance.BorderSize = 0;
            this.Botao_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Voltar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Voltar.ForeColor = System.Drawing.Color.White;
            this.Botao_Voltar.Location = new System.Drawing.Point(17, 632);
            this.Botao_Voltar.Margin = new System.Windows.Forms.Padding(8, 16, 1133, 0);
            this.Botao_Voltar.Name = "Botao_Voltar";
            this.Botao_Voltar.Size = new System.Drawing.Size(200, 48);
            this.Botao_Voltar.TabIndex = 11;
            this.Botao_Voltar.Text = "Voltar";
            this.Botao_Voltar.UseVisualStyleBackColor = false;
            this.Botao_Voltar.Click += new System.EventHandler(this.Botao_Voltar_Click);
            // 
            // Titulo_Tela
            // 
            this.Titulo_Tela.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Titulo_Tela.AutoSize = true;
            this.Titulo_Tela.BackColor = System.Drawing.Color.Transparent;
            this.Titulo_Tela.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Tela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Titulo_Tela.Location = new System.Drawing.Point(746, 120);
            this.Titulo_Tela.Margin = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.Titulo_Tela.Name = "Titulo_Tela";
            this.Titulo_Tela.Size = new System.Drawing.Size(220, 23);
            this.Titulo_Tela.TabIndex = 3;
            this.Titulo_Tela.Text = "Informações do funcionário";
            // 
            // Cabecalho
            // 
            this.Cabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(47)))), ((int)(((byte)(67)))));
            this.Cabecalho.Controls.Add(this.Titulo_Cabecalho);
            this.Cabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cabecalho.Location = new System.Drawing.Point(0, 0);
            this.Cabecalho.Margin = new System.Windows.Forms.Padding(0, 0, 0, 48);
            this.Cabecalho.Name = "Cabecalho";
            this.Cabecalho.Size = new System.Drawing.Size(1712, 72);
            this.Cabecalho.TabIndex = 0;
            // 
            // Titulo_Cabecalho
            // 
            this.Titulo_Cabecalho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Titulo_Cabecalho.AutoSize = true;
            this.Titulo_Cabecalho.BackColor = System.Drawing.Color.Transparent;
            this.Titulo_Cabecalho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Cabecalho.ForeColor = System.Drawing.Color.White;
            this.Titulo_Cabecalho.Location = new System.Drawing.Point(703, 25);
            this.Titulo_Cabecalho.Name = "Titulo_Cabecalho";
            this.Titulo_Cabecalho.Size = new System.Drawing.Size(307, 23);
            this.Titulo_Cabecalho.TabIndex = 1;
            this.Titulo_Cabecalho.Text = "Sistema de Gerenciamento de Apólices";
            // 
            // Coluna_Id
            // 
            this.Coluna_Id.HeaderText = "ID";
            this.Coluna_Id.MinimumWidth = 6;
            this.Coluna_Id.Name = "Coluna_Id";
            this.Coluna_Id.ReadOnly = true;
            this.Coluna_Id.Width = 59;
            // 
            // Coluna_Nome
            // 
            this.Coluna_Nome.HeaderText = "Nome";
            this.Coluna_Nome.MinimumWidth = 6;
            this.Coluna_Nome.Name = "Coluna_Nome";
            this.Coluna_Nome.ReadOnly = true;
            this.Coluna_Nome.Width = 90;
            // 
            // Coluna_Cpf_Cnpj
            // 
            this.Coluna_Cpf_Cnpj.HeaderText = "CPF/CNPJ";
            this.Coluna_Cpf_Cnpj.MinimumWidth = 6;
            this.Coluna_Cpf_Cnpj.Name = "Coluna_Cpf_Cnpj";
            this.Coluna_Cpf_Cnpj.ReadOnly = true;
            this.Coluna_Cpf_Cnpj.Width = 117;
            // 
            // Coluna_Cnh
            // 
            this.Coluna_Cnh.HeaderText = "CNH";
            this.Coluna_Cnh.MinimumWidth = 6;
            this.Coluna_Cnh.Name = "Coluna_Cnh";
            this.Coluna_Cnh.ReadOnly = true;
            this.Coluna_Cnh.Width = 78;
            // 
            // Coluna_Genero
            // 
            this.Coluna_Genero.HeaderText = "Gênero";
            this.Coluna_Genero.MinimumWidth = 6;
            this.Coluna_Genero.Name = "Coluna_Genero";
            this.Coluna_Genero.ReadOnly = true;
            this.Coluna_Genero.Width = 98;
            // 
            // Coluna_Data_Nascimento
            // 
            this.Coluna_Data_Nascimento.HeaderText = "Data de Nascimento";
            this.Coluna_Data_Nascimento.MinimumWidth = 6;
            this.Coluna_Data_Nascimento.Name = "Coluna_Data_Nascimento";
            this.Coluna_Data_Nascimento.ReadOnly = true;
            this.Coluna_Data_Nascimento.Width = 202;
            // 
            // Coluna_Cep
            // 
            this.Coluna_Cep.HeaderText = "CEP";
            this.Coluna_Cep.MinimumWidth = 6;
            this.Coluna_Cep.Name = "Coluna_Cep";
            this.Coluna_Cep.ReadOnly = true;
            this.Coluna_Cep.Width = 71;
            // 
            // Coluna_Estado
            // 
            this.Coluna_Estado.HeaderText = "Estado";
            this.Coluna_Estado.MinimumWidth = 6;
            this.Coluna_Estado.Name = "Coluna_Estado";
            this.Coluna_Estado.ReadOnly = true;
            this.Coluna_Estado.Width = 95;
            // 
            // Coluna_Cidade
            // 
            this.Coluna_Cidade.HeaderText = "Cidade";
            this.Coluna_Cidade.MinimumWidth = 6;
            this.Coluna_Cidade.Name = "Coluna_Cidade";
            this.Coluna_Cidade.ReadOnly = true;
            this.Coluna_Cidade.Width = 96;
            // 
            // Coluna_Bairro
            // 
            this.Coluna_Bairro.HeaderText = "Bairro";
            this.Coluna_Bairro.MinimumWidth = 6;
            this.Coluna_Bairro.Name = "Coluna_Bairro";
            this.Coluna_Bairro.ReadOnly = true;
            this.Coluna_Bairro.Width = 87;
            // 
            // Coluna_Rua
            // 
            this.Coluna_Rua.HeaderText = "Rua";
            this.Coluna_Rua.MinimumWidth = 6;
            this.Coluna_Rua.Name = "Coluna_Rua";
            this.Coluna_Rua.ReadOnly = true;
            this.Coluna_Rua.Width = 71;
            // 
            // Coluna_Numero
            // 
            this.Coluna_Numero.HeaderText = "Número";
            this.Coluna_Numero.MinimumWidth = 6;
            this.Coluna_Numero.Name = "Coluna_Numero";
            this.Coluna_Numero.ReadOnly = true;
            this.Coluna_Numero.Width = 106;
            // 
            // Coluna_Complemento
            // 
            this.Coluna_Complemento.HeaderText = "Complemento";
            this.Coluna_Complemento.MinimumWidth = 6;
            this.Coluna_Complemento.Name = "Coluna_Complemento";
            this.Coluna_Complemento.ReadOnly = true;
            this.Coluna_Complemento.Width = 155;
            // 
            // Coluna_Celular
            // 
            this.Coluna_Celular.HeaderText = "Celular";
            this.Coluna_Celular.MinimumWidth = 6;
            this.Coluna_Celular.Name = "Coluna_Celular";
            this.Coluna_Celular.ReadOnly = true;
            this.Coluna_Celular.Width = 94;
            // 
            // Coluna_Email
            // 
            this.Coluna_Email.HeaderText = "E-mail";
            this.Coluna_Email.MinimumWidth = 6;
            this.Coluna_Email.Name = "Coluna_Email";
            this.Coluna_Email.ReadOnly = true;
            this.Coluna_Email.Width = 90;
            // 
            // Tela_Informacoes_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 698);
            this.Controls.Add(this.Container_Principal);
            this.Name = "Tela_Informacoes_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_Informacoes_Funcionario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tela_Informacoes_Funcionario_Load);
            this.Container_Principal.ResumeLayout(false);
            this.Container_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Info_Funcionario)).EndInit();
            this.Cabecalho.ResumeLayout(false);
            this.Cabecalho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Container_Principal;
        private System.Windows.Forms.Label Titulo_Tela;
        private System.Windows.Forms.Panel Cabecalho;
        private System.Windows.Forms.Label Titulo_Cabecalho;
        private System.Windows.Forms.Button Botao_Voltar;
        private System.Windows.Forms.DataGridView DataGrid_Info_Funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Cpf_Cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Cnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Data_Nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna_Email;
    }
}