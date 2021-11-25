namespace Projeto_loja
{
    partial class frmPesquisar
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
            this.radCategoria = new System.Windows.Forms.RadioButton();
            this.radNome = new System.Windows.Forms.RadioButton();
            this.txtPesquisaPorNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.dgPesquisa = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // radCategoria
            // 
            this.radCategoria.AutoSize = true;
            this.radCategoria.Checked = true;
            this.radCategoria.Location = new System.Drawing.Point(24, 13);
            this.radCategoria.Name = "radCategoria";
            this.radCategoria.Size = new System.Drawing.Size(87, 20);
            this.radCategoria.TabIndex = 0;
            this.radCategoria.TabStop = true;
            this.radCategoria.Text = "Categoria";
            this.radCategoria.UseVisualStyleBackColor = true;
            this.radCategoria.Click += new System.EventHandler(this.radCategoria_Click);
            // 
            // radNome
            // 
            this.radNome.AutoSize = true;
            this.radNome.Location = new System.Drawing.Point(268, 21);
            this.radNome.Name = "radNome";
            this.radNome.Size = new System.Drawing.Size(65, 20);
            this.radNome.TabIndex = 1;
            this.radNome.Text = "Nome";
            this.radNome.UseVisualStyleBackColor = true;
            this.radNome.Click += new System.EventHandler(this.radNome_Click);
            // 
            // txtPesquisaPorNome
            // 
            this.txtPesquisaPorNome.Location = new System.Drawing.Point(491, 40);
            this.txtPesquisaPorNome.Name = "txtPesquisaPorNome";
            this.txtPesquisaPorNome.Size = new System.Drawing.Size(220, 22);
            this.txtPesquisaPorNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite para pesquisar: ";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(24, 39);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(215, 24);
            this.cmbCategoria.TabIndex = 4;
            // 
            // dgPesquisa
            // 
            this.dgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesquisa.Location = new System.Drawing.Point(12, 84);
            this.dgPesquisa.Name = "dgPesquisa";
            this.dgPesquisa.RowHeadersWidth = 51;
            this.dgPesquisa.RowTemplate.Height = 24;
            this.dgPesquisa.Size = new System.Drawing.Size(467, 303);
            this.dgPesquisa.TabIndex = 5;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(508, 130);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(121, 30);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(508, 182);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 30);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(508, 84);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(121, 30);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 417);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dgPesquisa);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesquisaPorNome);
            this.Controls.Add(this.radNome);
            this.Controls.Add(this.radCategoria);
            this.Name = "frmPesquisar";
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.frmPesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radCategoria;
        private System.Windows.Forms.RadioButton radNome;
        private System.Windows.Forms.TextBox txtPesquisaPorNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.DataGridView dgPesquisa;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisar;
    }
}