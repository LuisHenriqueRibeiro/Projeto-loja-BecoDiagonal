namespace Projeto_loja
{
    partial class frmGerarPdf
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
            this.btnGerarPDF = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGerarPDF
            // 
            this.btnGerarPDF.AutoSize = true;
            this.btnGerarPDF.Location = new System.Drawing.Point(12, 120);
            this.btnGerarPDF.Name = "btnGerarPDF";
            this.btnGerarPDF.Size = new System.Drawing.Size(162, 39);
            this.btnGerarPDF.TabIndex = 0;
            this.btnGerarPDF.Text = "btnGerar";
            this.btnGerarPDF.UseVisualStyleBackColor = true;
            this.btnGerarPDF.Click += new System.EventHandler(this.btnGerarPDF_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(314, 120);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(162, 39);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(123, 72);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(235, 22);
            this.txtCaminho.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Para gerar o pdf, entre com o endereço da Pasta na qual deseja guarda-lo\r\nLmbre d" +
    "e usar \\\\ no lugar de \\";
            // 
            // frmGerarPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 183);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerarPDF);
            this.Name = "frmGerarPdf";
            this.Text = "PDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarPDF;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label label1;
    }
}