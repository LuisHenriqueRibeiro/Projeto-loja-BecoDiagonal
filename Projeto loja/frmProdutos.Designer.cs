namespace Projeto_loja
{
    partial class frmProdutos
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgPesquisa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNomeImagem = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.txtMargemLucro = new System.Windows.Forms.TextBox();
            this.txtICMS = new System.Windows.Forms.TextBox();
            this.numEstoque = new System.Windows.Forms.NumericUpDown();
            this.chkExcluido = new System.Windows.Forms.CheckBox();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(622, 643);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(143, 37);
            this.btnSair.TabIndex = 25;
            this.btnSair.Text = "sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(622, 600);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(143, 37);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(622, 554);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(143, 37);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(471, 645);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(143, 37);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(471, 600);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(143, 37);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Text = "excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(471, 554);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(143, 37);
            this.btnNovo.TabIndex = 20;
            this.btnNovo.Text = "novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgPesquisa
            // 
            this.dgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesquisa.Location = new System.Drawing.Point(69, 26);
            this.dgPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.dgPesquisa.Name = "dgPesquisa";
            this.dgPesquisa.RowHeadersWidth = 51;
            this.dgPesquisa.Size = new System.Drawing.Size(810, 293);
            this.dgPesquisa.TabIndex = 26;
            this.dgPesquisa.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPesquisa_CellEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Id Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nome Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Preco:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Estoque:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 568);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Nome Imagem:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 594);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Excluido: ";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(238, 400);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(194, 22);
            this.txtIdProduto.TabIndex = 34;
            this.txtIdProduto.Validating += new System.ComponentModel.CancelEventHandler(this.txtIdProduto_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 623);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Custo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 651);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Margem de Lucro: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 679);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "ICMS:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(238, 428);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(194, 22);
            this.txtNomeProduto.TabIndex = 38;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(238, 483);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(194, 22);
            this.txtPreco.TabIndex = 39;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(239, 511);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(194, 22);
            this.txtDescricao.TabIndex = 40;
            // 
            // txtNomeImagem
            // 
            this.txtNomeImagem.Location = new System.Drawing.Point(239, 568);
            this.txtNomeImagem.Name = "txtNomeImagem";
            this.txtNomeImagem.Size = new System.Drawing.Size(194, 22);
            this.txtNomeImagem.TabIndex = 41;
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(238, 623);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(194, 22);
            this.txtCusto.TabIndex = 42;
            // 
            // txtMargemLucro
            // 
            this.txtMargemLucro.Location = new System.Drawing.Point(238, 651);
            this.txtMargemLucro.Name = "txtMargemLucro";
            this.txtMargemLucro.Size = new System.Drawing.Size(194, 22);
            this.txtMargemLucro.TabIndex = 43;
            // 
            // txtICMS
            // 
            this.txtICMS.Location = new System.Drawing.Point(238, 679);
            this.txtICMS.Name = "txtICMS";
            this.txtICMS.Size = new System.Drawing.Size(194, 22);
            this.txtICMS.TabIndex = 44;
            // 
            // numEstoque
            // 
            this.numEstoque.Location = new System.Drawing.Point(239, 540);
            this.numEstoque.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numEstoque.Name = "numEstoque";
            this.numEstoque.Size = new System.Drawing.Size(194, 22);
            this.numEstoque.TabIndex = 45;
            // 
            // chkExcluido
            // 
            this.chkExcluido.AutoSize = true;
            this.chkExcluido.Location = new System.Drawing.Point(238, 594);
            this.chkExcluido.Name = "chkExcluido";
            this.chkExcluido.Size = new System.Drawing.Size(84, 20);
            this.chkExcluido.TabIndex = 46;
            this.chkExcluido.Text = "Exclusâo";
            this.chkExcluido.UseVisualStyleBackColor = true;
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(515, 390);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(212, 157);
            this.picImagem.TabIndex = 47;
            this.picImagem.TabStop = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(394, 337);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(159, 33);
            this.btnAtualizar.TabIndex = 48;
            this.btnAtualizar.Text = "&Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click_1);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(239, 457);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(193, 24);
            this.cmbCategoria.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(160, 460);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 50;
            this.label11.Text = "Categoria:";
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 730);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.chkExcluido);
            this.Controls.Add(this.numEstoque);
            this.Controls.Add(this.txtICMS);
            this.Controls.Add(this.txtMargemLucro);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.txtNomeImagem);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPesquisa);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Name = "frmProdutos";
            this.Text = "frmProdutos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNomeImagem;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.TextBox txtMargemLucro;
        private System.Windows.Forms.TextBox txtICMS;
        private System.Windows.Forms.NumericUpDown numEstoque;
        private System.Windows.Forms.CheckBox chkExcluido;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label11;
    }
}