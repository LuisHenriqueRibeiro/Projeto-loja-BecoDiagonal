using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Reflection;
using System.Web;
namespace Projeto_loja
{
    public partial class frmGerarPdf : Form
    {
        public frmGerarPdf()
        {
            InitializeComponent();
        }
        private NpgsqlConnection cn = new NpgsqlConnection();
        private string conexao = "Server = banco72b.postgresql.dbaas.com.br ; Database = banco72b; Port = 5432;"
                                 + "User ID = banco72b; password = b@nco@cti293";

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ExportToPdf(DataTable dt, string strFilePath)
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(strFilePath, FileMode.Create));
            document.Open();
            iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 5);

            PdfPTable table = new PdfPTable(dt.Columns.Count);
            PdfPRow row = null;
            float[] widths = new float[dt.Columns.Count];
            for (int i = 0; i < dt.Columns.Count; i++)
                widths[i] = 4f;

            table.SetWidths(widths);

            table.WidthPercentage = 100;
            int iCol = 0;
            string colname = "";
            PdfPCell cell = new PdfPCell(new Phrase("Products"));

            cell.Colspan = dt.Columns.Count;

            foreach (DataColumn c in dt.Columns)
            {
                table.AddCell(new Phrase(c.ColumnName, font5));
            }

            foreach (DataRow r in dt.Rows)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int h = 0; h < dt.Columns.Count; h++)
                    {
                        table.AddCell(new Phrase(r[h].ToString(), font5));
                    }
                }
            }
            document.Add(table);
            document.Close();
        }

        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtCaminho.Text))
            {
                MessageBox.Show("Para baixar o Pdf, me indique o caminho da página, trocando o '\' por \\", "Gerar Pdf", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; 
            }
            else
            {
                string caminho = txtCaminho.Text;
                try
                {
                    NpgsqlConnection conn = new NpgsqlConnection(conexao);
                    NpgsqlCommand cmd = new NpgsqlCommand(
                        "select p.idproduto, " +
                        "p.nomeproduto, " +
                        "sum(iv.qtde) as qtdevendida " +
                        "from eq2.venda v " +
                        "inner " +
                        "join eq2.itemvenda iv " +
                        "on v.idvenda = iv.idvenda " +
                        "inner " +
                        "join eq2.produto p " +
                        "on p.idproduto = iv.idproduto " +
                        "group by p.idproduto, " +
                       "p.nomeproduto ", conn);
                    conn.Open();
                    DataTable dt = new DataTable();
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    dt.Clear();
                    da.Fill(dt);
                    string strFilePath = caminho+"\\BecoDiagonalLTDA.pdf";
                    ExportToPdf(dt, strFilePath);
                    conn.Close();
                    MessageBox.Show("PDF Gerado com sucesso!!", "Gerar PDF",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erros ocorridos : "+ex.Message+"!", "Gerar PDF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
