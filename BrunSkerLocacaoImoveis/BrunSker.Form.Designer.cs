namespace BrunSkerLocacaoImoveis
{
    partial class FrmMain
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
            this.lblDigiteCEP = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.grpDadosPesquisa = new System.Windows.Forms.GroupBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.lblGIA = new System.Windows.Forms.Label();
            this.lblINGE = new System.Windows.Forms.Label();
            this.txtDadosCEP = new System.Windows.Forms.TextBox();
            this.txtDadosLogradouro = new System.Windows.Forms.TextBox();
            this.txtDadosComplemento = new System.Windows.Forms.TextBox();
            this.txtDadosGIA = new System.Windows.Forms.TextBox();
            this.txtDadosIBGE = new System.Windows.Forms.TextBox();
            this.txtDadosBairro = new System.Windows.Forms.TextBox();
            this.txtDadosLocalidade = new System.Windows.Forms.TextBox();
            this.txtDadosUF = new System.Windows.Forms.TextBox();
            this.txtDadosUnidade = new System.Windows.Forms.TextBox();
            this.mskTxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.grpDadosPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDigiteCEP
            // 
            this.lblDigiteCEP.AutoSize = true;
            this.lblDigiteCEP.Location = new System.Drawing.Point(12, 19);
            this.lblDigiteCEP.Name = "lblDigiteCEP";
            this.lblDigiteCEP.Size = new System.Drawing.Size(70, 13);
            this.lblDigiteCEP.TabIndex = 0;
            this.lblDigiteCEP.Text = "Digite o CEP:";
            this.lblDigiteCEP.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(221, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(15, 56);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(281, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // grpDadosPesquisa
            // 
            this.grpDadosPesquisa.Controls.Add(this.lblINGE);
            this.grpDadosPesquisa.Controls.Add(this.lblGIA);
            this.grpDadosPesquisa.Controls.Add(this.lblLocalidade);
            this.grpDadosPesquisa.Controls.Add(this.txtDadosUnidade);
            this.grpDadosPesquisa.Controls.Add(this.txtDadosUF);
            this.grpDadosPesquisa.Controls.Add(this.txtDadosLocalidade);
            this.grpDadosPesquisa.Controls.Add(this.txtDadosBairro);
            this.grpDadosPesquisa.Controls.Add(this.txtDadosIBGE);
            this.grpDadosPesquisa.Controls.Add(this.txtDadosGIA);
            this.grpDadosPesquisa.Controls.Add(this.txtDadosComplemento);
            this.grpDadosPesquisa.Controls.Add(this.txtDadosLogradouro);
            this.grpDadosPesquisa.Controls.Add(this.txtDadosCEP);
            this.grpDadosPesquisa.Controls.Add(this.lblUF);
            this.grpDadosPesquisa.Controls.Add(this.lblUnidade);
            this.grpDadosPesquisa.Controls.Add(this.lblComplemento);
            this.grpDadosPesquisa.Controls.Add(this.lblBairro);
            this.grpDadosPesquisa.Controls.Add(this.lblLogradouro);
            this.grpDadosPesquisa.Controls.Add(this.lblCEP);
            this.grpDadosPesquisa.Location = new System.Drawing.Point(15, 94);
            this.grpDadosPesquisa.Name = "grpDadosPesquisa";
            this.grpDadosPesquisa.Size = new System.Drawing.Size(281, 268);
            this.grpDadosPesquisa.TabIndex = 3;
            this.grpDadosPesquisa.TabStop = false;
            this.grpDadosPesquisa.Text = "Dados da Pesquisa";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(6, 26);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 0;
            this.lblCEP.Text = "CEP:";
            this.lblCEP.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(6, 55);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(67, 13);
            this.lblLogradouro.TabIndex = 0;
            this.lblLogradouro.Text = "Logradouro: ";
            this.lblLogradouro.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(6, 103);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 0;
            this.lblBairro.Text = "Bairro:";
            this.lblBairro.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(6, 81);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(77, 13);
            this.lblComplemento.TabIndex = 0;
            this.lblComplemento.Text = "Complemento: ";
            this.lblComplemento.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(6, 185);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(50, 13);
            this.lblUnidade.TabIndex = 0;
            this.lblUnidade.Text = "Unidade:";
            this.lblUnidade.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(6, 159);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 13);
            this.lblUF.TabIndex = 0;
            this.lblUF.Text = "UF:";
            this.lblUF.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Location = new System.Drawing.Point(6, 133);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(62, 13);
            this.lblLocalidade.TabIndex = 0;
            this.lblLocalidade.Text = "Localidade:";
            this.lblLocalidade.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGIA
            // 
            this.lblGIA.AutoSize = true;
            this.lblGIA.Location = new System.Drawing.Point(6, 237);
            this.lblGIA.Name = "lblGIA";
            this.lblGIA.Size = new System.Drawing.Size(31, 13);
            this.lblGIA.TabIndex = 0;
            this.lblGIA.Text = "GIA: ";
            this.lblGIA.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblINGE
            // 
            this.lblINGE.AutoSize = true;
            this.lblINGE.Location = new System.Drawing.Point(6, 211);
            this.lblINGE.Name = "lblINGE";
            this.lblINGE.Size = new System.Drawing.Size(35, 13);
            this.lblINGE.TabIndex = 0;
            this.lblINGE.Text = "IBGE:";
            this.lblINGE.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDadosCEP
            // 
            this.txtDadosCEP.Location = new System.Drawing.Point(89, 19);
            this.txtDadosCEP.Name = "txtDadosCEP";
            this.txtDadosCEP.Size = new System.Drawing.Size(100, 20);
            this.txtDadosCEP.TabIndex = 1;
            this.txtDadosCEP.TextChanged += new System.EventHandler(this.txtDadosCEP_TextChanged);
            // 
            // txtDadosLogradouro
            // 
            this.txtDadosLogradouro.Location = new System.Drawing.Point(89, 48);
            this.txtDadosLogradouro.Name = "txtDadosLogradouro";
            this.txtDadosLogradouro.Size = new System.Drawing.Size(187, 20);
            this.txtDadosLogradouro.TabIndex = 1;
            this.txtDadosLogradouro.TextChanged += new System.EventHandler(this.txtDadosLogradouro_TextChanged);
            // 
            // txtDadosComplemento
            // 
            this.txtDadosComplemento.Location = new System.Drawing.Point(89, 74);
            this.txtDadosComplemento.Name = "txtDadosComplemento";
            this.txtDadosComplemento.Size = new System.Drawing.Size(186, 20);
            this.txtDadosComplemento.TabIndex = 1;
            // 
            // txtDadosGIA
            // 
            this.txtDadosGIA.Location = new System.Drawing.Point(89, 230);
            this.txtDadosGIA.Name = "txtDadosGIA";
            this.txtDadosGIA.Size = new System.Drawing.Size(186, 20);
            this.txtDadosGIA.TabIndex = 1;
            // 
            // txtDadosIBGE
            // 
            this.txtDadosIBGE.Location = new System.Drawing.Point(89, 204);
            this.txtDadosIBGE.Name = "txtDadosIBGE";
            this.txtDadosIBGE.Size = new System.Drawing.Size(186, 20);
            this.txtDadosIBGE.TabIndex = 1;
            // 
            // txtDadosBairro
            // 
            this.txtDadosBairro.Location = new System.Drawing.Point(89, 100);
            this.txtDadosBairro.Name = "txtDadosBairro";
            this.txtDadosBairro.Size = new System.Drawing.Size(186, 20);
            this.txtDadosBairro.TabIndex = 1;
            // 
            // txtDadosLocalidade
            // 
            this.txtDadosLocalidade.Location = new System.Drawing.Point(89, 126);
            this.txtDadosLocalidade.Name = "txtDadosLocalidade";
            this.txtDadosLocalidade.Size = new System.Drawing.Size(186, 20);
            this.txtDadosLocalidade.TabIndex = 1;
            // 
            // txtDadosUF
            // 
            this.txtDadosUF.Location = new System.Drawing.Point(89, 152);
            this.txtDadosUF.Name = "txtDadosUF";
            this.txtDadosUF.Size = new System.Drawing.Size(186, 20);
            this.txtDadosUF.TabIndex = 1;
            // 
            // txtDadosUnidade
            // 
            this.txtDadosUnidade.Location = new System.Drawing.Point(89, 178);
            this.txtDadosUnidade.Name = "txtDadosUnidade";
            this.txtDadosUnidade.Size = new System.Drawing.Size(186, 20);
            this.txtDadosUnidade.TabIndex = 1;
            // 
            // mskTxtCEP
            // 
            this.mskTxtCEP.Location = new System.Drawing.Point(106, 16);
            this.mskTxtCEP.Mask = "00000-000";
            this.mskTxtCEP.Name = "mskTxtCEP";
            this.mskTxtCEP.Size = new System.Drawing.Size(100, 20);
            this.mskTxtCEP.TabIndex = 4;
            this.mskTxtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 450);
            this.Controls.Add(this.mskTxtCEP);
            this.Controls.Add(this.grpDadosPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblDigiteCEP);
            this.Name = "FrmMain";
            this.Text = "BrunSker Locacao Imoveis";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpDadosPesquisa.ResumeLayout(false);
            this.grpDadosPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDigiteCEP;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox grpDadosPesquisa;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblINGE;
        private System.Windows.Forms.Label lblGIA;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.TextBox txtDadosUnidade;
        private System.Windows.Forms.TextBox txtDadosUF;
        private System.Windows.Forms.TextBox txtDadosLocalidade;
        private System.Windows.Forms.TextBox txtDadosBairro;
        private System.Windows.Forms.TextBox txtDadosIBGE;
        private System.Windows.Forms.TextBox txtDadosGIA;
        private System.Windows.Forms.TextBox txtDadosComplemento;
        private System.Windows.Forms.TextBox txtDadosLogradouro;
        private System.Windows.Forms.TextBox txtDadosCEP;
        private System.Windows.Forms.MaskedTextBox mskTxtCEP;
    }
}

