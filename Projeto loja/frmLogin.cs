using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Npgsql;

namespace Projeto_loja
{
    public partial class frmLogin : Form
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

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnConferir_Click(object sender, EventArgs e)
        {
            string sql;
            string senha;
            try
            {
                if (String.IsNullOrWhiteSpace(txtLogin.Text) || String.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    MessageBox.Show("ERRO, REVER OS VALORES DIGITADOS", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sql = "select idusuario,senha from eq2.usuario " +
                        "where login = @login";
                Conectar();
                NpgsqlCommand cmd = new NpgsqlCommand(sql,cn);
                cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {   
                    MD5 md5 = MD5.Create();
                    senha = dr["senha"].ToString();
                    byte[] cripto = md5.ComputeHash(Encoding.UTF8.GetBytes(txtSenha.Text));
                    StringBuilder construindoSenha = new StringBuilder();
                    for (int i =0; i< cripto.Length;i++)
                    {
                        construindoSenha.Append(cripto[i].ToString("x2"));
                    }
                    string senhaDigitada = construindoSenha.ToString();
                    if(senhaDigitada != senha)
                    {
                        MessageBox.Show("ERRO, REVER OS VALORES DIGITADOS", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Controle controle = new Controle();
                    controle.setSeEleSaiuNoLogin(false);
                    controle.setIdDele(Convert.ToInt32(dr["idusuario"]));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ususario não encontrado, por favor, entrar com login correto, ou se cadastrar", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmCadastrar cadastro = new frmCadastrar();
            cadastro.ShowDialog();
            this.Visible = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.setSeEleSaiuNoLogin(true);
            controle.setIdDele(0);
            this.Close();
        }
    }
}
