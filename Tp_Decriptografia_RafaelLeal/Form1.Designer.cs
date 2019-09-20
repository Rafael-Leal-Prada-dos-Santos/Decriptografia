namespace Tp_Decriptografia_RafaelLeal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDecriptografar = new System.Windows.Forms.Button();
            this.txtCaminhoArquivoCriptografado = new System.Windows.Forms.TextBox();
            this.txtCaminhoArquivoDecriptografado = new System.Windows.Forms.TextBox();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEscolherArquivoCriptografado = new System.Windows.Forms.Button();
            this.btnEscolherArquivoDeSaida = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEscolherArquivoCriptografado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCaminhoArquivoCriptografado);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivo a ser Decriptografado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEscolherArquivoDeSaida);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCaminhoArquivoDecriptografado);
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(782, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arquivo que irá conter o texto  decriptografado";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtChave);
            this.groupBox3.Location = new System.Drawing.Point(12, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(782, 91);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chave de Decriptografia";
            // 
            // btnDecriptografar
            // 
            this.btnDecriptografar.Location = new System.Drawing.Point(355, 341);
            this.btnDecriptografar.Name = "btnDecriptografar";
            this.btnDecriptografar.Size = new System.Drawing.Size(107, 23);
            this.btnDecriptografar.TabIndex = 2;
            this.btnDecriptografar.Text = "Decriptografar";
            this.btnDecriptografar.UseVisualStyleBackColor = true;
            this.btnDecriptografar.Click += new System.EventHandler(this.btnDecriptografar_Click);
            // 
            // txtCaminhoArquivoCriptografado
            // 
            this.txtCaminhoArquivoCriptografado.Location = new System.Drawing.Point(219, 41);
            this.txtCaminhoArquivoCriptografado.Name = "txtCaminhoArquivoCriptografado";
            this.txtCaminhoArquivoCriptografado.ReadOnly = true;
            this.txtCaminhoArquivoCriptografado.Size = new System.Drawing.Size(370, 20);
            this.txtCaminhoArquivoCriptografado.TabIndex = 0;
            // 
            // txtCaminhoArquivoDecriptografado
            // 
            this.txtCaminhoArquivoDecriptografado.Location = new System.Drawing.Point(219, 40);
            this.txtCaminhoArquivoDecriptografado.Name = "txtCaminhoArquivoDecriptografado";
            this.txtCaminhoArquivoDecriptografado.ReadOnly = true;
            this.txtCaminhoArquivoDecriptografado.Size = new System.Drawing.Size(370, 20);
            this.txtCaminhoArquivoDecriptografado.TabIndex = 1;
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(219, 39);
            this.txtChave.MaxLength = 8;
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(370, 20);
            this.txtChave.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caminho do arquivo decriptografado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite a Chave do arquivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Caminho do Arquivo Criptografado";
            // 
            // btnEscolherArquivoCriptografado
            // 
            this.btnEscolherArquivoCriptografado.Location = new System.Drawing.Point(634, 39);
            this.btnEscolherArquivoCriptografado.Name = "btnEscolherArquivoCriptografado";
            this.btnEscolherArquivoCriptografado.Size = new System.Drawing.Size(107, 23);
            this.btnEscolherArquivoCriptografado.TabIndex = 3;
            this.btnEscolherArquivoCriptografado.Text = "Escolher";
            this.btnEscolherArquivoCriptografado.UseVisualStyleBackColor = true;
            this.btnEscolherArquivoCriptografado.Click += new System.EventHandler(this.btnEscolherArquivoCriptografado_Click);
            // 
            // btnEscolherArquivoDeSaida
            // 
            this.btnEscolherArquivoDeSaida.Location = new System.Drawing.Point(634, 36);
            this.btnEscolherArquivoDeSaida.Name = "btnEscolherArquivoDeSaida";
            this.btnEscolherArquivoDeSaida.Size = new System.Drawing.Size(107, 23);
            this.btnEscolherArquivoDeSaida.TabIndex = 5;
            this.btnEscolherArquivoDeSaida.Text = "Escolher";
            this.btnEscolherArquivoDeSaida.UseVisualStyleBackColor = true;
            this.btnEscolherArquivoDeSaida.Click += new System.EventHandler(this.btnEscolherArquivoDeSaida_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 392);
            this.Controls.Add(this.btnDecriptografar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Decriptografador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCaminhoArquivoCriptografado;
        private System.Windows.Forms.TextBox txtCaminhoArquivoDecriptografado;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Button btnDecriptografar;
        private System.Windows.Forms.Button btnEscolherArquivoCriptografado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEscolherArquivoDeSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

