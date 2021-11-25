using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto_loja
{
    public partial class frmDevs : Form
    {
        public frmDevs()
        {
            InitializeComponent();
        }

        private void RadLuisHenrique_Click(object sender, EventArgs e)
        {
            string caminho = Directory.GetCurrentDirectory() + "\\imagem\\luis.png";
            picImagemDev.Image = Image.FromFile(caminho);
            lblInformacaoDevs.Text = "Líder \n Nº18 \n luis.henrique-ribeiro@unesp.br";
        }

        private void RadSophiaXavier_Click(object sender, EventArgs e)
        {
            string caminho = Directory.GetCurrentDirectory() + "\\imagem\\sophia.png";
            picImagemDev.Image = Image.FromFile(caminho);
            lblInformacaoDevs.Text = "Dev \n Nº32 \n sophia.santos@unesp.br";

        }

        private void RadPedroHenrique_Click(object sender, EventArgs e)
        {
            string caminho = Directory.GetCurrentDirectory() + "\\imagem\\pedro.png";
            picImagemDev.Image = Image.FromFile(caminho);
            lblInformacaoDevs.Text = "Dev \n Nº26 \n pedro.m.nascimento@unesp.br";
            
        }

        private void RadArthurOrsolini_Click(object sender, EventArgs e)
        {
            string caminho = Directory.GetCurrentDirectory() + "\\imagem\\arthur.png";
            picImagemDev.Image = Image.FromFile(caminho);
            lblInformacaoDevs.Text = "Vice-Líder \n Nº02 \n arthur.ximenes@unesp.br";
        }

        private void RadLuanVillarin_Click(object sender, EventArgs e)
        {
            string caminho = Directory.GetCurrentDirectory() + "\\imagem\\luan.png";
            picImagemDev.Image = Image.FromFile(caminho);
            lblInformacaoDevs.Text = "Dev \n Nº17 \n luan.villarin@unesp.br";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
