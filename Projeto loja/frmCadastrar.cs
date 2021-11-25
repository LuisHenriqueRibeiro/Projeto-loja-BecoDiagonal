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
using System.Security.Cryptography;

namespace Projeto_loja
{
    public partial class frmCadastrar : Form
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
        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtEmail.Text) || String.IsNullOrWhiteSpace(txtEnderco.Text) ||
               String.IsNullOrWhiteSpace(txtLogin.Text) || String.IsNullOrWhiteSpace(txtNomeUsuario.Text) ||
               String.IsNullOrWhiteSpace(txtSenha.Text) || String.IsNullOrWhiteSpace(mskCPF.Text) ||
               String.IsNullOrWhiteSpace(mskTelefone.Text) || String.IsNullOrWhiteSpace(mskRG.Text))
            {
                MessageBox.Show("Dados Incompletos", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                string sql;
                try
                {
                    sql = "INSERT INTO eq2.usuario (idusuario, email, login, senha, telefone, endereco, nomeusuario, cpf, rg, adm, excluido, dataexclusao) " +
                        "VALUES(DEFAULT,@email, @login, @senha, @telefone, @endereco, @nomeusuario, @cpf, @rg, false, false, null);";
                    MD5 md5 = MD5.Create();
                    byte[] cripto = md5.ComputeHash(Encoding.UTF8.GetBytes(txtSenha.Text));
                    StringBuilder construindoSenha = new StringBuilder();
                    for (int i = 0; i < cripto.Length; i++)
                    {
                        construindoSenha.Append(cripto[i].ToString("x2"));
                    }
                    string senhaDigitada = construindoSenha.ToString();
                    Conectar();
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                    cmd.Parameters.AddWithValue("@senha", senhaDigitada);
                    cmd.Parameters.AddWithValue("@telefone", mskTelefone.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEnderco.Text);
                    cmd.Parameters.AddWithValue("@nomeusuario", txtNomeUsuario.Text);
                    cmd.Parameters.AddWithValue("@cpf", mskCPF.Text);
                    cmd.Parameters.AddWithValue("@rg", mskRG.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados salvos com sucesso", "Cadastro",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch(NpgsqlException ex)
                {
                    MessageBox.Show("Não foi possível cadastrar" +
                   "\n Para mais informações :" + ex.Message, "Cadastro Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    Desconectar(); 
                }
            }
        }
    }
}
