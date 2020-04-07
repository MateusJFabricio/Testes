namespace Banco
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtValorInicial = new System.Windows.Forms.TextBox();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtValorContaClienteAtual = new System.Windows.Forms.TextBox();
            this.txtEnderecoClienteAtual = new System.Windows.Forms.TextBox();
            this.txtNomeClienteAtual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOperacoesConta = new System.Windows.Forms.TextBox();
            this.btnCredito = new System.Windows.Forms.Button();
            this.btnDebito = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor inicial(R$):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCriarConta);
            this.groupBox1.Controls.Add(this.txtValorInicial);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novos clientes";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(119, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(260, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(119, 61);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(260, 20);
            this.txtEndereco.TabIndex = 4;
            // 
            // txtValorInicial
            // 
            this.txtValorInicial.Location = new System.Drawing.Point(119, 93);
            this.txtValorInicial.Name = "txtValorInicial";
            this.txtValorInicial.Size = new System.Drawing.Size(64, 20);
            this.txtValorInicial.TabIndex = 5;
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.Location = new System.Drawing.Point(286, 152);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(135, 23);
            this.btnCriarConta.TabIndex = 6;
            this.btnCriarConta.Text = "Criar Conta";
            this.btnCriarConta.UseVisualStyleBackColor = true;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(19, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 10);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtValorContaClienteAtual);
            this.groupBox2.Controls.Add(this.txtEnderecoClienteAtual);
            this.groupBox2.Controls.Add(this.txtNomeClienteAtual);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 126);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente atual";
            // 
            // txtValorContaClienteAtual
            // 
            this.txtValorContaClienteAtual.Enabled = false;
            this.txtValorContaClienteAtual.Location = new System.Drawing.Point(119, 90);
            this.txtValorContaClienteAtual.Name = "txtValorContaClienteAtual";
            this.txtValorContaClienteAtual.Size = new System.Drawing.Size(64, 20);
            this.txtValorContaClienteAtual.TabIndex = 5;
            // 
            // txtEnderecoClienteAtual
            // 
            this.txtEnderecoClienteAtual.Enabled = false;
            this.txtEnderecoClienteAtual.Location = new System.Drawing.Point(119, 61);
            this.txtEnderecoClienteAtual.Name = "txtEnderecoClienteAtual";
            this.txtEnderecoClienteAtual.Size = new System.Drawing.Size(260, 20);
            this.txtEnderecoClienteAtual.TabIndex = 4;
            // 
            // txtNomeClienteAtual
            // 
            this.txtNomeClienteAtual.Enabled = false;
            this.txtNomeClienteAtual.Location = new System.Drawing.Point(119, 32);
            this.txtNomeClienteAtual.Name = "txtNomeClienteAtual";
            this.txtNomeClienteAtual.Size = new System.Drawing.Size(260, 20);
            this.txtNomeClienteAtual.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Valor Atual(R$):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Endereco:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDebito);
            this.groupBox3.Controls.Add(this.btnCredito);
            this.groupBox3.Controls.Add(this.txtOperacoesConta);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 374);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 120);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operacoes na conta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Valor(R$):";
            // 
            // txtOperacoesConta
            // 
            this.txtOperacoesConta.Location = new System.Drawing.Point(66, 23);
            this.txtOperacoesConta.Name = "txtOperacoesConta";
            this.txtOperacoesConta.Size = new System.Drawing.Size(64, 20);
            this.txtOperacoesConta.TabIndex = 7;
            // 
            // btnCredito
            // 
            this.btnCredito.Location = new System.Drawing.Point(9, 58);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(154, 46);
            this.btnCredito.TabIndex = 8;
            this.btnCredito.Text = "Credito";
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // btnDebito
            // 
            this.btnDebito.Location = new System.Drawing.Point(267, 58);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(154, 46);
            this.btnDebito.TabIndex = 9;
            this.btnDebito.Text = "Debito";
            this.btnDebito.UseVisualStyleBackColor = true;
            this.btnDebito.Click += new System.EventHandler(this.btnDebito_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 502);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtValorInicial;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCriarConta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtValorContaClienteAtual;
        private System.Windows.Forms.TextBox txtEnderecoClienteAtual;
        private System.Windows.Forms.TextBox txtNomeClienteAtual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDebito;
        private System.Windows.Forms.Button btnCredito;
        private System.Windows.Forms.TextBox txtOperacoesConta;
        private System.Windows.Forms.Label label7;
    }
}

