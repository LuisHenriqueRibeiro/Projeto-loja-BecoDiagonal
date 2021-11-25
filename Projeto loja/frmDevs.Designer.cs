namespace Projeto_loja
{
    partial class frmDevs
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
            this.RadLuisHenrique = new System.Windows.Forms.RadioButton();
            this.radSophiaXavier = new System.Windows.Forms.RadioButton();
            this.radLuanVillarin = new System.Windows.Forms.RadioButton();
            this.radPedroHenrique = new System.Windows.Forms.RadioButton();
            this.lblInformacaoDevs = new System.Windows.Forms.Label();
            this.picImagemDev = new System.Windows.Forms.PictureBox();
            this.radArturXimenes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemDev)).BeginInit();
            this.SuspendLayout();
            // 
            // RadLuisHenrique
            // 
            this.RadLuisHenrique.AutoSize = true;
            this.RadLuisHenrique.Location = new System.Drawing.Point(135, 44);
            this.RadLuisHenrique.Name = "RadLuisHenrique";
            this.RadLuisHenrique.Size = new System.Drawing.Size(157, 20);
            this.RadLuisHenrique.TabIndex = 1;
            this.RadLuisHenrique.TabStop = true;
            this.RadLuisHenrique.Text = "Luís Henrique Ribeiro";
            this.RadLuisHenrique.UseVisualStyleBackColor = true;
            this.RadLuisHenrique.Click += new System.EventHandler(this.RadLuisHenrique_Click);
            // 
            // radSophiaXavier
            // 
            this.radSophiaXavier.AutoSize = true;
            this.radSophiaXavier.Location = new System.Drawing.Point(298, 44);
            this.radSophiaXavier.Name = "radSophiaXavier";
            this.radSophiaXavier.Size = new System.Drawing.Size(183, 20);
            this.radSophiaXavier.TabIndex = 3;
            this.radSophiaXavier.TabStop = true;
            this.radSophiaXavier.Text = "Sophia Xavier dos Santos";
            this.radSophiaXavier.UseVisualStyleBackColor = true;
            this.radSophiaXavier.Click += new System.EventHandler(this.RadSophiaXavier_Click);
            // 
            // radLuanVillarin
            // 
            this.radLuanVillarin.AutoSize = true;
            this.radLuanVillarin.Location = new System.Drawing.Point(385, 70);
            this.radLuanVillarin.Name = "radLuanVillarin";
            this.radLuanVillarin.Size = new System.Drawing.Size(154, 20);
            this.radLuanVillarin.TabIndex = 4;
            this.radLuanVillarin.TabStop = true;
            this.radLuanVillarin.Text = "Luan Villarin Campos";
            this.radLuanVillarin.UseVisualStyleBackColor = true;
            this.radLuanVillarin.CheckedChanged += new System.EventHandler(this.RadLuanVillarin_Click);
            // 
            // radPedroHenrique
            // 
            this.radPedroHenrique.AutoSize = true;
            this.radPedroHenrique.Location = new System.Drawing.Point(487, 44);
            this.radPedroHenrique.Name = "radPedroHenrique";
            this.radPedroHenrique.Size = new System.Drawing.Size(169, 20);
            this.radPedroHenrique.TabIndex = 5;
            this.radPedroHenrique.TabStop = true;
            this.radPedroHenrique.Text = "Pedro Henrique Martins";
            this.radPedroHenrique.UseVisualStyleBackColor = true;
            this.radPedroHenrique.Click += new System.EventHandler(this.RadPedroHenrique_Click);
            // 
            // lblInformacaoDevs
            // 
            this.lblInformacaoDevs.Font = new System.Drawing.Font("Onyx", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacaoDevs.Location = new System.Drawing.Point(378, 93);
            this.lblInformacaoDevs.Name = "lblInformacaoDevs";
            this.lblInformacaoDevs.Size = new System.Drawing.Size(333, 282);
            this.lblInformacaoDevs.TabIndex = 6;
            this.lblInformacaoDevs.Text = "Escolha um dos buttons de Devs, para conhecer ele(a)";
            this.lblInformacaoDevs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picImagemDev
            // 
            this.picImagemDev.Location = new System.Drawing.Point(65, 93);
            this.picImagemDev.Name = "picImagemDev";
            this.picImagemDev.Size = new System.Drawing.Size(307, 282);
            this.picImagemDev.TabIndex = 7;
            this.picImagemDev.TabStop = false;
            // 
            // radArturXimenes
            // 
            this.radArturXimenes.AutoSize = true;
            this.radArturXimenes.Location = new System.Drawing.Point(202, 70);
            this.radArturXimenes.Name = "radArturXimenes";
            this.radArturXimenes.Size = new System.Drawing.Size(165, 20);
            this.radArturXimenes.TabIndex = 8;
            this.radArturXimenes.TabStop = true;
            this.radArturXimenes.Text = "Arthur Ximenes Orsolini";
            this.radArturXimenes.UseVisualStyleBackColor = true;
            this.radArturXimenes.Click += new System.EventHandler(this.RadArthurOrsolini_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Conheça nossos Devs";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(574, 396);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(137, 33);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmDevs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 441);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radArturXimenes);
            this.Controls.Add(this.picImagemDev);
            this.Controls.Add(this.lblInformacaoDevs);
            this.Controls.Add(this.radPedroHenrique);
            this.Controls.Add(this.radLuanVillarin);
            this.Controls.Add(this.radSophiaXavier);
            this.Controls.Add(this.RadLuisHenrique);
            this.Name = "frmDevs";
            this.Text = "Devs";
            ((System.ComponentModel.ISupportInitialize)(this.picImagemDev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton RadLuisHenrique;
        private System.Windows.Forms.RadioButton radSophiaXavier;
        private System.Windows.Forms.RadioButton radLuanVillarin;
        private System.Windows.Forms.RadioButton radPedroHenrique;
        private System.Windows.Forms.Label lblInformacaoDevs;
        private System.Windows.Forms.PictureBox picImagemDev;
        private System.Windows.Forms.RadioButton radArturXimenes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
    }
}