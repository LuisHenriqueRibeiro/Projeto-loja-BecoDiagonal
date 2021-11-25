using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_loja
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            frmSplash splash = new frmSplash();
            splash.ShowDialog();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            Controle controle = new Controle();
            if (controle.getSeEleSaiuNoLogin())
            {
                this.Close();
            }
            else
            {
                this.Visible = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.setIdDele(0);
            this.Close();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            frmProdutos sp = new frmProdutos();
            sp.ShowDialog();
            this.Visible=true;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmPesquisar pesquisar = new frmPesquisar();
            pesquisar.ShowDialog();
            this.Visible = true;
        }

        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmGerarPdf gerarPdf = new frmGerarPdf();   
            gerarPdf.ShowDialog();
            this.Visible=true;
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLancaPedidos lancaPedidos = new frmLancaPedidos();
            lancaPedidos.ShowDialog();
            this.Visible = true;
        }

        private void btnDevs_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            frmDevs devs = new frmDevs();
            devs.ShowDialog();
            this.Visible = true;
        }
    }
}
