using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Projeto_loja
{
    public partial class frmPesquisar : Form
    {
        private NpgsqlConnection cn = new NpgsqlConnection();
        private string conexao = "Server = banco72b.postgresql.dbaas.com.br ; Database = banco72b; Port = 5432;"
                                 + "User ID = banco72b; password = b@nco@cti293";
        private void Conectar()
        {
            try
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.ConnectionString = conexao;
                    cn.Open();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao processar o comando no banco de dados " +
                                "\n\nMais detalhes :" + ex.Message, "Cadastro Aparelho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Desconectar()
        {
            try
            {
                cn.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao processar o comando no banco de dados " +
                                "\n\nMais detalhes :" + ex.Message, "Cadastro Aparelho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public frmPesquisar()
        {
            InitializeComponent();
        }
        private void carregaCategoria()
        {
            string sql;
            try
            {
                sql = " SELECT idcategoria, nomecategoria FROM eq2.categoria ORDER BY idcategoria ";
                Conectar();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                DataTable dt = new DataTable();
                NpgsqlDataAdapter dr = new NpgsqlDataAdapter(cmd);
                dt.Clear();
                dr.Fill(dt);
                cmbCategoria.DisplayMember = "nomecategoria";
                cmbCategoria.ValueMember = "idcategoria";
                cmbCategoria.DataSource = dt;
                cmbCategoria.SelectedIndex = -1;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao processar o comando Carregar Categoria " +
                           "\n\nMais detalhes :" + ex.Message, "Cadastro Aparelho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Desconectar();
            }
        }

        private void frmPesquisar_Load(object sender, EventArgs e)
        {
            carregaCategoria();
    
        }

        private void radCategoria_Click(object sender, EventArgs e)
        {
            txtPesquisaPorNome.Enabled = false;
            cmbCategoria.Enabled = true;
        }

        private void radNome_Click(object sender, EventArgs e)
        {
            txtPesquisaPorNome.Enabled = true;
            cmbCategoria.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(radCategoria.Checked)
            {
                try
                {
                    string sql = "select p.nomeproduto, p.preco, c.nomecategoria " +
                        "from eq2.produto p, eq2.categoria c " +
                        " where c.idcategoria = p.idcategoria  and p.idcategoria = @idcategoria and p.excluido is false ";
                    Conectar();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@idcategoria", cmbCategoria.SelectedValue);
                    DataTable dt = new DataTable();
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    dt.Clear();
                    da.Fill(dt);
                    dgPesquisa.DataSource = dt;
                }
                catch(NpgsqlException ex)
                {
                    MessageBox.Show("Erro \n para mais detalhes:"+ex+" .", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Desconectar();
                }
            }
            else if(radNome.Checked)
            {
                try
                {
                    string sql = "select p.nomeproduto, p.preco, c.nomecategoria " +
                        "from eq2.produto p, eq2.categoria c " +
                        " where c.idcategoria = p.idcategoria  and p.nomeproduto = @nomeproduto and p.excluido is false ";
                    Conectar();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@nomeproduto", txtPesquisaPorNome.Text);
                    DataTable dt = new DataTable();
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    dt.Clear();
                    da.Fill(dt);
                    dgPesquisa.DataSource = dt;
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Erro \n para mais detalhes:" + ex + " .", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Desconectar();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmbCategoria.SelectedValue = 0;
            txtPesquisaPorNome.Clear();
            DataTable dt = new DataTable();
            dt.Clear();
            dgPesquisa.DataSource = dt;

        }
    }
}
