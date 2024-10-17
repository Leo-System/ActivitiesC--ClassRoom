namespace restauranteQuinta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNumMesa = new System.Windows.Forms.Label();
            this.txtNumMesa = new System.Windows.Forms.TextBox();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.chbChop = new System.Windows.Forms.CheckBox();
            this.chbPetiscos = new System.Windows.Forms.CheckBox();
            this.chbRefeicao = new System.Windows.Forms.CheckBox();
            this.txtChop = new System.Windows.Forms.TextBox();
            this.txtPetiscos = new System.Windows.Forms.TextBox();
            this.txtRefeicoes = new System.Windows.Forms.TextBox();
            this.lblTotalParcial = new System.Windows.Forms.Label();
            this.txtTotalParcial = new System.Windows.Forms.TextBox();
            this.lblTaxaServico = new System.Windows.Forms.Label();
            this.txtTaxaServico = new System.Windows.Forms.TextBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.bntPagarConta = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumMesa
            // 
            this.lblNumMesa.AutoSize = true;
            this.lblNumMesa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMesa.Location = new System.Drawing.Point(26, 33);
            this.lblNumMesa.Name = "lblNumMesa";
            this.lblNumMesa.Size = new System.Drawing.Size(111, 22);
            this.lblNumMesa.TabIndex = 0;
            this.lblNumMesa.Text = "N da mesa: ";
            this.lblNumMesa.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumMesa
            // 
            this.txtNumMesa.Location = new System.Drawing.Point(133, 35);
            this.txtNumMesa.Name = "txtNumMesa";
            this.txtNumMesa.Size = new System.Drawing.Size(100, 20);
            this.txtNumMesa.TabIndex = 1;
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.Location = new System.Drawing.Point(26, 95);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(86, 22);
            this.lblPedidos.TabIndex = 2;
            this.lblPedidos.Text = "Pedidos:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(223, 95);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(117, 22);
            this.lblQuantidade.TabIndex = 3;
            this.lblQuantidade.Text = "Quantidade: ";
            // 
            // chbChop
            // 
            this.chbChop.AutoSize = true;
            this.chbChop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbChop.Location = new System.Drawing.Point(30, 133);
            this.chbChop.Name = "chbChop";
            this.chbChop.Size = new System.Drawing.Size(113, 20);
            this.chbChop.TabIndex = 4;
            this.chbChop.Text = "Chop R$ 4,50: ";
            this.chbChop.UseVisualStyleBackColor = true;
            // 
            // chbPetiscos
            // 
            this.chbPetiscos.AutoSize = true;
            this.chbPetiscos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPetiscos.Location = new System.Drawing.Point(30, 190);
            this.chbPetiscos.Name = "chbPetiscos";
            this.chbPetiscos.Size = new System.Drawing.Size(134, 20);
            this.chbPetiscos.TabIndex = 5;
            this.chbPetiscos.Text = "Petiscos R$ 7,90: ";
            this.chbPetiscos.UseVisualStyleBackColor = true;
            // 
            // chbRefeicao
            // 
            this.chbRefeicao.AutoSize = true;
            this.chbRefeicao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRefeicao.Location = new System.Drawing.Point(30, 244);
            this.chbRefeicao.Name = "chbRefeicao";
            this.chbRefeicao.Size = new System.Drawing.Size(140, 20);
            this.chbRefeicao.TabIndex = 6;
            this.chbRefeicao.Text = "Refeição R$ 15,90: ";
            this.chbRefeicao.UseVisualStyleBackColor = true;
            this.chbRefeicao.CheckedChanged += new System.EventHandler(this.chbRefeicao_CheckedChanged);
            // 
            // txtChop
            // 
            this.txtChop.Location = new System.Drawing.Point(227, 133);
            this.txtChop.Name = "txtChop";
            this.txtChop.Size = new System.Drawing.Size(100, 20);
            this.txtChop.TabIndex = 7;
            // 
            // txtPetiscos
            // 
            this.txtPetiscos.Location = new System.Drawing.Point(227, 190);
            this.txtPetiscos.Name = "txtPetiscos";
            this.txtPetiscos.Size = new System.Drawing.Size(100, 20);
            this.txtPetiscos.TabIndex = 8;
            // 
            // txtRefeicoes
            // 
            this.txtRefeicoes.Location = new System.Drawing.Point(227, 244);
            this.txtRefeicoes.Name = "txtRefeicoes";
            this.txtRefeicoes.Size = new System.Drawing.Size(100, 20);
            this.txtRefeicoes.TabIndex = 9;
            // 
            // lblTotalParcial
            // 
            this.lblTotalParcial.AutoSize = true;
            this.lblTotalParcial.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalParcial.Location = new System.Drawing.Point(426, 133);
            this.lblTotalParcial.Name = "lblTotalParcial";
            this.lblTotalParcial.Size = new System.Drawing.Size(122, 22);
            this.lblTotalParcial.TabIndex = 10;
            this.lblTotalParcial.Text = "Total Parcial: ";
            // 
            // txtTotalParcial
            // 
            this.txtTotalParcial.Location = new System.Drawing.Point(596, 133);
            this.txtTotalParcial.Name = "txtTotalParcial";
            this.txtTotalParcial.Size = new System.Drawing.Size(100, 20);
            this.txtTotalParcial.TabIndex = 11;
            // 
            // lblTaxaServico
            // 
            this.lblTaxaServico.AutoSize = true;
            this.lblTaxaServico.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxaServico.Location = new System.Drawing.Point(426, 190);
            this.lblTaxaServico.Name = "lblTaxaServico";
            this.lblTaxaServico.Size = new System.Drawing.Size(152, 22);
            this.lblTaxaServico.TabIndex = 12;
            this.lblTaxaServico.Text = "Taxa de serviço: ";
            // 
            // txtTaxaServico
            // 
            this.txtTaxaServico.Location = new System.Drawing.Point(596, 194);
            this.txtTaxaServico.Name = "txtTaxaServico";
            this.txtTaxaServico.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaServico.TabIndex = 13;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(426, 244);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(128, 22);
            this.lblTotalPagar.TabIndex = 14;
            this.lblTotalPagar.Text = "Total a pagar: ";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(596, 248);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPagar.TabIndex = 15;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirma.BackgroundImage")));
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(30, 318);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(162, 109);
            this.btnConfirma.TabIndex = 16;
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntPagarConta
            // 
            this.bntPagarConta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntPagarConta.BackgroundImage")));
            this.bntPagarConta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntPagarConta.Location = new System.Drawing.Point(310, 318);
            this.bntPagarConta.Name = "bntPagarConta";
            this.bntPagarConta.Size = new System.Drawing.Size(162, 109);
            this.bntPagarConta.TabIndex = 17;
            this.bntPagarConta.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(596, 318);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(162, 109);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.bntPagarConta);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.txtTaxaServico);
            this.Controls.Add(this.lblTaxaServico);
            this.Controls.Add(this.txtTotalParcial);
            this.Controls.Add(this.lblTotalParcial);
            this.Controls.Add(this.txtRefeicoes);
            this.Controls.Add(this.txtPetiscos);
            this.Controls.Add(this.txtChop);
            this.Controls.Add(this.chbRefeicao);
            this.Controls.Add(this.chbPetiscos);
            this.Controls.Add(this.chbChop);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.txtNumMesa);
            this.Controls.Add(this.lblNumMesa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumMesa;
        private System.Windows.Forms.TextBox txtNumMesa;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.CheckBox chbChop;
        private System.Windows.Forms.CheckBox chbPetiscos;
        private System.Windows.Forms.CheckBox chbRefeicao;
        private System.Windows.Forms.TextBox txtChop;
        private System.Windows.Forms.TextBox txtPetiscos;
        private System.Windows.Forms.TextBox txtRefeicoes;
        private System.Windows.Forms.Label lblTotalParcial;
        private System.Windows.Forms.TextBox txtTotalParcial;
        private System.Windows.Forms.Label lblTaxaServico;
        private System.Windows.Forms.TextBox txtTaxaServico;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button bntPagarConta;
        private System.Windows.Forms.Button btnSair;
    }
}

