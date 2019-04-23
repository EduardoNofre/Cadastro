using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroProtocolo
{
    public partial class AlterarSenha : Form
    {
        public AlterarSenha()
        {
            InitializeComponent();
        }

        private void AlterarSenha_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cad_pro_SEFAZDataSet.tb_usuario' table. You can move, or remove it, as needed.
            this.tb_usuarioTableAdapter.Fill(this.cad_pro_SEFAZDataSet.tb_usuario);

        }

        private void BtnovoUser_Click(object sender, EventArgs e)
        {

            {
                if (textBox3.Text == string.Empty | textBox4.Text == string.Empty | comboBox2.Text == string.Empty)
                {
                    MessageBox.Show("Prencher os campos Usuario, Senha e Confirmar senha!" + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBox2.Focus();
                    return;
                }

                if (textBox4.Text != textBox3.Text)
                {
                    MessageBox.Show("As senhas não conferem! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBox2.Focus();
                    return;
                }
                try
                {

                   
                    string strSql = "update tb_usuario "
+ "set senha = '" + textBox3.Text + "' "
+ "where idusuario = '" + comboBox2.SelectedValue + "'";


                    DataBaseConection str = new DataBaseConection();
                    //cria a conexão com o banco de dados
                    SqlConnection con = str.BuscarConexao();
                    //cria o objeto command para executar a instruçao sql
                    SqlCommand cmd = new SqlCommand(strSql, con);
                    //abre a conexao
                    con.Open();

                    //define o tipo do comando
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 120;

                    SqlDataReader dr = cmd.ExecuteReader();

                    //limpar campos

                    textBox3.Clear();
                    textBox4.Clear();
                    comboBox2.Focus();

                    //fecha a conexção
                    con.Close();

                    MessageBox.Show("SENHA ALTERADA COM SUCESSO");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("DADOS NÃO ENCONTRADOS " + ex.Message + "\n" + ex.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Application.Exit();

                }
                finally
                {


                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
