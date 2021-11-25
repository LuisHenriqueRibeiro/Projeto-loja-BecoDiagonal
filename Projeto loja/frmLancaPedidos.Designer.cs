namespace Projeto_loja
{
    partial class frmLancaPedidos
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
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.lblNomeCategoria = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgProduto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(642, 216);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(121, 33);
            this.btnAtualizar.TabIndex = 44;
            this.btnAtualizar.Text = "&Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(395, 273);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(151, 22);
            this.txtPreco.TabIndex = 43;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(110, 236);
            this.txtIdProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(151, 22);
            this.txtIdProduto.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 33);
            this.label1.TabIndex = 41;
            this.label1.Text = "Id Produto";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(642, 306);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 37);
            this.btnSair.TabIndex = 40;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(642, 261);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(4);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(121, 37);
            this.btnComprar.TabIndex = 39;
            this.btnComprar.Text = "&Realizar Pedido";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(395, 314);
            this.numQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.numQuantidade.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.numQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(160, 22);
            this.numQuantidade.TabIndex = 38;
            this.numQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Location = new System.Drawing.Point(313, 317);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(148, 33);
            this.lblQuantidade.TabIndex = 37;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblPreco
            // 
            this.lblPreco.Location = new System.Drawing.Point(343, 277);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(148, 33);
            this.lblPreco.TabIndex = 36;
            this.lblPreco.Text = "Preco";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Location = new System.Drawing.Point(140, 317);
            this.txtNomeCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.ReadOnly = true;
            this.txtNomeCategoria.Size = new System.Drawing.Size(155, 22);
            this.txtNomeCategoria.TabIndex = 35;
            // 
            // lblNomeCategoria
            // 
            this.lblNomeCategoria.Location = new System.Drawing.Point(9, 320);
            this.lblNomeCategoria.Name = "lblNomeCategoria";
            this.lblNomeCategoria.Size = new System.Drawing.Size(148, 33);
            this.lblNomeCategoria.TabIndex = 34;
            this.lblNomeCategoria.Text = "Nome da Categoria";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(140, 277);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.ReadOnly = true;
            this.txtNomeProduto.Size = new System.Drawing.Size(155, 22);
            this.txtNomeProduto.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(41, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 33);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nome Produto";
            // 
            // dgProduto
            // 
            this.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduto.Location = new System.Drawing.Point(38, 32);
            this.dgProduto.Margin = new System.Windows.Forms.Padding(4);
            this.dgProduto.Name = "dgProduto";
            this.dgProduto.RowHeadersWidth = 51;
            this.dgProduto.Size = new System.Drawing.Size(725, 160);
            this.dgProduto.TabIndex = 31;
            this.dgProduto.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduto_CellEnter);
            // 
            // frmLancaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtNomeCategoria);
            this.Controls.Add(this.lblNomeCategoria);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgProduto);
            this.Name = "frmLancaPedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.frmLancaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Label lblNomeCategoria;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgProduto;
    }
}