namespace ZNAzul
{
    partial class Cadastro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cbLogradouto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroLogradouro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMotivoInfracao = new System.Windows.Forms.ComboBox();
            this.dtpInfracao = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTiquete = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFiscalizador = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtNumeroAviso = new System.Windows.Forms.MaskedTextBox();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(401, 301);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número Aviso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(245, 207);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 7;
            // 
            // cbLogradouto
            // 
            this.cbLogradouto.FormattingEnabled = true;
            this.cbLogradouto.Location = new System.Drawing.Point(15, 256);
            this.cbLogradouto.Name = "cbLogradouto";
            this.cbLogradouto.Size = new System.Drawing.Size(214, 21);
            this.cbLogradouto.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Logradouro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Número Logradouro";
            // 
            // txtNumeroLogradouro
            // 
            this.txtNumeroLogradouro.Location = new System.Drawing.Point(247, 257);
            this.txtNumeroLogradouro.Name = "txtNumeroLogradouro";
            this.txtNumeroLogradouro.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroLogradouro.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Motivo Infracao";
            // 
            // cbMotivoInfracao
            // 
            this.cbMotivoInfracao.FormattingEnabled = true;
            this.cbMotivoInfracao.Location = new System.Drawing.Point(352, 207);
            this.cbMotivoInfracao.Name = "cbMotivoInfracao";
            this.cbMotivoInfracao.Size = new System.Drawing.Size(121, 21);
            this.cbMotivoInfracao.TabIndex = 13;
            // 
            // dtpInfracao
            // 
            this.dtpInfracao.Location = new System.Drawing.Point(17, 303);
            this.dtpInfracao.Name = "dtpInfracao";
            this.dtpInfracao.Size = new System.Drawing.Size(212, 20);
            this.dtpInfracao.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Data Infração";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Hora";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tíquete";
            // 
            // txtTiquete
            // 
            this.txtTiquete.Location = new System.Drawing.Point(354, 257);
            this.txtTiquete.Name = "txtTiquete";
            this.txtTiquete.Size = new System.Drawing.Size(119, 20);
            this.txtTiquete.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Fiscalizador";
            // 
            // txtFiscalizador
            // 
            this.txtFiscalizador.Location = new System.Drawing.Point(14, 347);
            this.txtFiscalizador.Name = "txtFiscalizador";
            this.txtFiscalizador.Size = new System.Drawing.Size(215, 20);
            this.txtFiscalizador.TabIndex = 21;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(245, 303);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 23;
            // 
            // txtNumeroAviso
            // 
            this.txtNumeroAviso.Location = new System.Drawing.Point(15, 207);
            this.txtNumeroAviso.Name = "txtNumeroAviso";
            this.txtNumeroAviso.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroAviso.TabIndex = 24;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(129, 208);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 185);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 381);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtNumeroAviso);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFiscalizador);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTiquete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpInfracao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMotivoInfracao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumeroLogradouro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbLogradouto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImprimir);
            this.Name = "Cadastro";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.ComboBox cbLogradouto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroLogradouro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMotivoInfracao;
        private System.Windows.Forms.DateTimePicker dtpInfracao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTiquete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFiscalizador;
        private System.Windows.Forms.MaskedTextBox txtHora;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox txtNumeroAviso;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

