namespace EncontrarArquivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtPastaInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDiretorioInicial = new System.Windows.Forms.Button();
            this.lbArquivos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.cboPadraoArquivos = new System.Windows.Forms.ComboBox();
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtArquivoEscolhido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnDescriptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChavePublica = new System.Windows.Forms.TextBox();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtPastaInicial
            // 
            this.txtPastaInicial.Location = new System.Drawing.Point(153, 9);
            this.txtPastaInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtPastaInicial.Name = "txtPastaInicial";
            this.txtPastaInicial.Size = new System.Drawing.Size(458, 22);
            this.txtPastaInicial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pasta Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Padrão de arquivos";
            // 
            // btnDiretorioInicial
            // 
            this.btnDiretorioInicial.Image = ((System.Drawing.Image)(resources.GetObject("btnDiretorioInicial.Image")));
            this.btnDiretorioInicial.Location = new System.Drawing.Point(619, 10);
            this.btnDiretorioInicial.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiretorioInicial.Name = "btnDiretorioInicial";
            this.btnDiretorioInicial.Size = new System.Drawing.Size(42, 23);
            this.btnDiretorioInicial.TabIndex = 2;
            this.btnDiretorioInicial.UseVisualStyleBackColor = true;
            this.btnDiretorioInicial.Click += new System.EventHandler(this.btnDiretorioInicial_Click);
            // 
            // lbArquivos
            // 
            this.lbArquivos.ForeColor = System.Drawing.Color.Blue;
            this.lbArquivos.FormattingEnabled = true;
            this.lbArquivos.ItemHeight = 16;
            this.lbArquivos.Location = new System.Drawing.Point(13, 124);
            this.lbArquivos.Margin = new System.Windows.Forms.Padding(4);
            this.lbArquivos.Name = "lbArquivos";
            this.lbArquivos.ScrollAlwaysVisible = true;
            this.lbArquivos.Size = new System.Drawing.Size(598, 116);
            this.lbArquivos.TabIndex = 3;
            this.lbArquivos.Click += new System.EventHandler(this.LbArquivos_Click);
            this.lbArquivos.DoubleClick += new System.EventHandler(this.LbArquivos_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Arq.Encontrados(*.gpg-Arq. a ser Descriptado/*.txt a ser Encriptado)";
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(981, 476);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 30);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // cboPadraoArquivos
            // 
            this.cboPadraoArquivos.FormattingEnabled = true;
            this.cboPadraoArquivos.Items.AddRange(new object[] {
            "Text (*.txt)",
            "All Files (*.*)",
            "PDF Files (*.pdf)",
            "(*.gpg)",
            "(*.asc)"});
            this.cboPadraoArquivos.Location = new System.Drawing.Point(153, 55);
            this.cboPadraoArquivos.Name = "cboPadraoArquivos";
            this.cboPadraoArquivos.Size = new System.Drawing.Size(458, 24);
            this.cboPadraoArquivos.TabIndex = 6;
            this.cboPadraoArquivos.DropDown += new System.EventHandler(this.CboPadraoArquivos_DropDown);
            this.cboPadraoArquivos.SelectedIndexChanged += new System.EventHandler(this.CboPadraoArquivos_SelectedIndexChanged);
            // 
            // txtArquivoEscolhido
            // 
            this.txtArquivoEscolhido.Location = new System.Drawing.Point(618, 124);
            this.txtArquivoEscolhido.Name = "txtArquivoEscolhido";
            this.txtArquivoEscolhido.Size = new System.Drawing.Size(248, 22);
            this.txtArquivoEscolhido.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Arquivo Escolhido";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(13, 247);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(80, 26);
            this.btnEncriptar.TabIndex = 9;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.BtnEncriptar_Click);
            // 
            // btnDescriptar
            // 
            this.btnDescriptar.Location = new System.Drawing.Point(531, 247);
            this.btnDescriptar.Name = "btnDescriptar";
            this.btnDescriptar.Size = new System.Drawing.Size(80, 26);
            this.btnDescriptar.TabIndex = 10;
            this.btnDescriptar.Text = "Descriptar";
            this.btnDescriptar.UseVisualStyleBackColor = true;
            this.btnDescriptar.Click += new System.EventHandler(this.BtnDescriptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Digite a Chave Pública (apenas para encriptar)";
            // 
            // txtChavePublica
            // 
            this.txtChavePublica.Location = new System.Drawing.Point(618, 187);
            this.txtChavePublica.Name = "txtChavePublica";
            this.txtChavePublica.Size = new System.Drawing.Size(248, 22);
            this.txtChavePublica.TabIndex = 13;
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.ForeColor = System.Drawing.Color.Blue;
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 16;
            this.listBoxResultado.Location = new System.Drawing.Point(13, 330);
            this.listBoxResultado.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.ScrollAlwaysVisible = true;
            this.listBoxResultado.Size = new System.Drawing.Size(598, 116);
            this.listBoxResultado.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1095, 519);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtChavePublica);
            this.Controls.Add(this.btnDescriptar);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArquivoEscolhido);
            this.Controls.Add(this.cboPadraoArquivos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbArquivos);
            this.Controls.Add(this.btnDiretorioInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPastaInicial);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste GPG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPastaInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDiretorioInicial;
        private System.Windows.Forms.ListBox lbArquivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cboPadraoArquivos;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.TextBox txtArquivoEscolhido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnDescriptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChavePublica;
        private System.Windows.Forms.ListBox listBoxResultado;
    }
}

