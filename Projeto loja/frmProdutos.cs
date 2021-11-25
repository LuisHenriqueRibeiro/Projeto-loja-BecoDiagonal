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
using System.IO;

namespace Projeto_loja
{
    public partial class frmProdutos : Form
    {
        private NpgsqlConnection cn = new NpgsqlConnection();
        private string conexao = "Server = banco72b.postgresql.dbaas.com.br ; Database = banco72b; Port = 5432;"
                                 + "User ID = banco72b; password = b@nco@cti293";
        bool controleNovo = false;
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
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            CarregaAparelho();
            carregaCategoria();
            cmbCategoria.SelectedValue = 0;
        }
        private void carregaCategoria()
        {
            string sql;
            try
            {
                sql = "SELECT idcategoria,nomecategoria FROM eq2.categoria ORDER BY idcategoria";
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgPesquisa_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!controleNovo)
            {
                try
                {
                    Int64 idproduto;
                    idproduto = Convert.ToInt64(dgPesquisa.Rows[e.RowIndex].Cells[0].Value);
                    txtIdProduto.Text = txtIdProduto.ToString();
                    PesquisarProduto(idproduto);
                }
                catch (System.InvalidCastException ex)
                {
                    MessageBox.Show("Não há dados para serem acessados", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Erro, \n Não pode trazer os dados enquanto se cria u usuário",
                    "Cadastro Aparelho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void PesquisarProduto(Int64 idproduto)
        {
            string sql;
            try
            {
                sql = "SELECT p.idproduto,p.nomeproduto,p.preco,p.excluido,p.caminhoimagem, p.estoque,p.custo,p.margem_lucro,p.icms,c.nomecategoria, p.descricao, " +
                    "p.nomeimagem FROM eq2.produto p, eq2.categoria c ";
                sql += "WHERE p.idproduto = @idproduto AND p.idcategoria = c.idcategoria";

                Conectar();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@idproduto", Convert.ToInt64(idproduto));
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtIdProduto.Text = dr["idproduto"].ToString();
                    cmbCategoria.Text = dr["nomecategoria"].ToString();
                    txtNomeProduto.Text = dr["nomeproduto"].ToString();
                    chkExcluido.Checked = Convert.ToBoolean(dr["excluido"]);
                    numEstoque.Value = Convert.ToDecimal(dr["estoque"]);
                    txtPreco.Text = dr["preco"].ToString();
                    txtMargemLucro.Text = dr["margem_lucro"].ToString();
                    txtCusto.Text = dr["custo"].ToString();
                    txtICMS.Text = dr["icms"].ToString();
                    txtNomeImagem.Text = dr["nomeimagem"].ToString();
                    txtDescricao.Text = dr["descricao"].ToString();
                    string recebeCaminho = dr["caminhoimagem"].ToString();
                    string[] caminhpSplit = recebeCaminho.Split('/');
                    string caminho = Directory.GetCurrentDirectory() + "\\imagem\\"+caminhpSplit[1]; 
                    picImagem.Image = Image.FromFile(caminho);
                }
                else
                {
                    MessageBox.Show("Produto não encontrado", "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    LimpaForm();
                }
                dr.Close();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao processar o comando Pesquisar Produtos " +
                           "\n\nMais detalhes :" + ex.Message, "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Desconectar();
            }
        }

        private void txtIdProduto_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtIdProduto.Text))
            {
                PesquisarProduto(Convert.ToInt64(txtIdProduto.Text));
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregaAparelho();
        }
        private void CarregaAparelho()
        {
            string sql;
            try
            {
                sql = "SELECT p.idproduto, c.idcategoria ,c.nomecategoria , p.nomeproduto, p.preco, p.estoque, p.custo, p.margem_lucro,p.icms," +
                    " p.nomeimagem, p.caminhoimagem, p.descricao ";
                sql += "FROM eq2.produto p, eq2.categoria c ";
                sql += "WHERE p.excluido is false AND p.idcategoria = c.idcategoria ";
                sql += "ORDER BY p.idproduto ";

                Conectar();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                DataTable dt = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                dgPesquisa.DataSource = dt;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao processar o comando Carregar Aparelho  " +
                                "\n\nMais detalhes :" + ex.Message, "Cadastro Aparelho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Desconectar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaForm();
            chkExcluido.Enabled = true;
            txtIdProduto.Enabled = true;
            controleNovo = false;
            HabilitaBotoes(false);
        }
        private void LimpaForm()
        {
            txtIdProduto.Clear();
            txtNomeProduto.Clear();
            chkExcluido.Checked = false;
            numEstoque.Value = 0;
            txtICMS.Clear();
            txtCusto.Clear();
            txtMargemLucro.Clear();
            txtPreco.Clear();
            txtDescricao.Clear();
            cmbCategoria.SelectedValue = 0;
            txtNomeImagem.Clear();
        }
        private void HabilitaBotoes(bool estadoNovo = true)// define como padrão o true // se for enviado o false, ele será
        {
            if (estadoNovo)
            {
                btnNovo.Enabled = false;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = false;
                btnSair.Enabled = false;
                btnAtualizar.Enabled = false;
            }
            else
            {
                btnNovo.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSair.Enabled = true;
                btnAtualizar.Enabled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaForm();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaForm();
            txtIdProduto.Enabled = false;
            chkExcluido.Enabled = false;
            controleNovo = true;
            HabilitaBotoes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            string sql;
            try
            {
                if (!String.IsNullOrEmpty(txtIdProduto.Text))
                {
                    resp = MessageBox.Show("Deseja realmente excluir o produto " + txtNomeProduto.Text + "?",
                                            "Cadastro de Produtos",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
                    if (resp == DialogResult.Yes)
                    {
                        Conectar();
                        sql = "UPDATE eq2.produto SET excluido = true ";
                        sql += "   WHERE idproduto = @idproduto";
                        NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                        cmd.Parameters.AddWithValue("@idproduto", Convert.ToInt64(txtIdProduto.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produto excluído com sucesso !!!",
                                            "Cadastro de Aparelho",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        LimpaForm();
                        HabilitaBotoes(false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir o Produto !!!" +
                                "\n\nMais detalhes: " + ex.Message,
                                            "Cadastro de Produtos",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string sql;
            try
            {
                if (String.IsNullOrWhiteSpace(txtNomeProduto.Text) ||
                    String.IsNullOrWhiteSpace(txtPreco.Text) || String.IsNullOrWhiteSpace(txtDescricao.Text) || 
                    String.IsNullOrWhiteSpace(txtCusto.Text) || String.IsNullOrWhiteSpace(txtICMS.Text) ||
                    String.IsNullOrWhiteSpace(txtMargemLucro.Text) || String.IsNullOrWhiteSpace(txtNomeImagem.Text) ||
                    numEstoque.Value == 0)
                {
                    MessageBox.Show("Dados que devem ser preenchidos \n" +
                        "Dados incorretos ou precisam ser preenchidos", "Inclusão Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrWhiteSpace(txtIdProduto.Text))
                {
                    sql = "insert into eq2.produto (idproduto,idcategoria,nomeproduto,preco,excluido,estoque,dataexclusao,nomeimagem,custo,margem_lucro,icms)" +
                                           "values (default, @idcategoria, @nomeproduto, @preco, @excluido, @estoque, null,@nomeimagem,@custo,@margem_lucro,@icms)";
                }
                else
                {
                    sql = "update eq2.produto set" +
                        " idcategoria = @idcategoria, nomeproduto = @nomeproduto, preco = @preco,excluido=@excluido, nomeimagem = @nomeimagem, estoque = @estoque, custo = @custo, margem_lucro = @margem_lucro, icms = @icms" +
                        " where idproduto = @idproduto";
                }
                bool excluido;
                if(chkExcluido.Checked == true)
                {
                    excluido = true;
                }
                else
                {
                    excluido = false;
                }
                Conectar();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@idcategoria", cmbCategoria.SelectedValue);
                cmd.Parameters.AddWithValue("@nomeproduto", txtNomeProduto.Text);
                cmd.Parameters.AddWithValue("@excluido", excluido);
                cmd.Parameters.AddWithValue("@preco", Convert.ToDouble(txtPreco.Text));
                cmd.Parameters.AddWithValue("@estoque", numEstoque.Value);
                cmd.Parameters.AddWithValue("@custo", Convert.ToDouble(txtCusto.Text));
                cmd.Parameters.AddWithValue("@margem_lucro", Convert.ToDouble(txtMargemLucro.Text));
                cmd.Parameters.AddWithValue("@icms", Convert.ToDouble(txtICMS.Text));
                cmd.Parameters.AddWithValue("@nomeimagem", txtNomeImagem.Text);
                if (!String.IsNullOrWhiteSpace(txtIdProduto.Text))
                {
                    cmd.Parameters.AddWithValue("@idproduto", Convert.ToInt64(txtIdProduto.Text));
                }

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados salvos com sucesso", "Cadastro Produto",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaForm();
            }
            catch (NpgsqlException ex)
            {

                MessageBox.Show("Não foi possível salvar as alterações" +
                    "\n Para mais informações :" + ex.Message, "Cadastro Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Desconectar();
            }
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            CarregaAparelho();
        }
    }
}
