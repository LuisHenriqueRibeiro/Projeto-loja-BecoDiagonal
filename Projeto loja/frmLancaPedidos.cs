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
    public partial class frmLancaPedidos : Form
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
        public frmLancaPedidos()
        {
            InitializeComponent();
        }

        private void dgProduto_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Int64 id_produto;
                id_produto = Convert.ToInt64(dgProduto.Rows[e.RowIndex].Cells[0].Value);
                txtIdProduto.Text = txtIdProduto.ToString();
                PesquisarProduto(id_produto);
            }
            catch (System.InvalidCastException ex)
            {
                MessageBox.Show("Não há dados para serem acessados", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmLancaPedidos_Load(object sender, EventArgs e)
        {
            CarregaProduto();
        }
        private void CarregaProduto()
        {
            string sql;
            try
            {
                sql = "SELECT p.idproduto,c.nomecategoria , p.nomeproduto, p.preco, p.estoque ";
                sql += "FROM eq2.produto p, eq2.categoria c ";
                sql += "WHERE p.excluido is false AND p.idcategoria = c.idcategoria ";
                sql += "ORDER BY p.idproduto ";

                Conectar();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                DataTable dt = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                dgProduto.DataSource = dt;
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
        private void LimpaForm()
        {
            txtIdProduto.Clear();
            txtNomeProduto.Clear();
            txtNomeCategoria.Clear();
            txtPreco.Clear();
            numQuantidade.Value = 1;
        }
        private void PesquisarProduto(Int64 id_Produto)
        {
            string sql;
            try
            {
                sql = "SELECT p.idproduto,p.nomeproduto,p.preco,c.nomecategoria FROM eq2.produto p, eq2.categoria c ";
                sql += "WHERE idproduto = @idproduto AND p.idcategoria = c.idcategoria";

                Conectar();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@idproduto", Convert.ToInt64(id_Produto));
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtIdProduto.Text = dr["idproduto"].ToString();
                    txtNomeCategoria.Text = dr["nomecategoria"].ToString();
                    txtPreco.Text = Convert.ToInt64(dr["preco"]).ToString();
                    txtNomeProduto.Text = dr["nomeproduto"].ToString();
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                bool SeConseguiu;
                SeConseguiu = darBaixaNoEstoque();
                if(SeConseguiu)
                {
                    inserirNaTabelaVenda();
                    adicionarNaTabelaItemVenda();

                    MessageBox.Show("Produto Comprado com sucesso !!!",
                                                "Compra de Produtos",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao realizar compra !!!" +
                                "\n\nMais detalhes: " + ex.Message,
                                            "Realizar Compra",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
            }
            finally
            {
                Desconectar();
            }
        }
        private void inserirNaTabelaVenda()
        {
            string sql;
            Conectar();
            sql = "INSERT INTO eq2.venda VALUES (DEFAULT,NOW(),'f')";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            cmd.ExecuteNonQuery();
            Desconectar();
        }

        private bool darBaixaNoEstoque()
        {
            int estoque = 0;
            Conectar();
            string sql = "Select estoque from eq2.produto where idproduto = @idproduto";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@idprodutp", Convert.ToInt64(txtIdProduto.Text));
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                estoque = Convert.ToInt16(reader["estoque"]);
            }
            Desconectar();
            if ( numQuantidade.Value <= 0 || numQuantidade.Value > estoque)
            {
                MessageBox.Show("Quantidade pedida não suportada pela plataforma", "Lança Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            Conectar();
            sql = "UPDATE eq2.produto SET estoque=estoque-@qtd WHERE idproduto = @idproduto";
            cmd = new NpgsqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@qtd", numQuantidade.Value);
            cmd.Parameters.AddWithValue("@idproduto", Convert.ToInt64(txtIdProduto.Text));
            cmd.ExecuteNonQuery();
            Desconectar();
            return true;
        }
        private void adicionarNaTabelaItemVenda()
        {

            string sql;
            string codvenda = pegarIdVenda();
            if (codvenda == "")
            {
                return;
            }

            sql = "INSERT INTO eq2.itemvenda VALUES (default, @idvenda , @idproduto, @idusuario, @qtde , @preco , FALSE);";
            Conectar();
            Controle controle = new Controle();
            NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@preco", Convert.ToInt32(txtPreco.Text));
            cmd.Parameters.AddWithValue("@idvenda", Convert.ToInt64(codvenda));
            cmd.Parameters.AddWithValue("@idproduto", Convert.ToInt64(txtIdProduto.Text));
            cmd.Parameters.AddWithValue("@idusuario", controle.getIdDele());
            cmd.Parameters.AddWithValue("@qtde", numQuantidade.Value);
            cmd.ExecuteNonQuery();
            Desconectar();
        }
        private string pegarIdVenda()
        {
            try
            {
                string sql;
                Conectar();
                sql = "SELECT MAX(idvenda) FROM eq2.venda WHERE excluido = FALSE";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return dr["max"].ToString();
                }
                return "";
            }
            finally
            {
                Desconectar();
            }


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregaProduto();
        }
    }
}
