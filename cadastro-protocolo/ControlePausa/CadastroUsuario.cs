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
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (textBox1.Text == String.Empty | textBox2.Text == String.Empty | textBox3.Text == String.Empty | textBox4.Text == String.Empty | comboBox1.Text == String.Empty)
            {
                MessageBox.Show("Favor prencher os campos Usuário,Nome e Senha! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }




            if (textBox4.Text != textBox3.Text)
            {
                MessageBox.Show("As senhas não conferem. " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Clear();
                textBox3.Focus();

                return;
            }



            {
                try
                {


                    string strSql = "insert into tb_usuario  (nmlogin,nome,senha,idperfil) "
    + "values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "',"+comboBox1.SelectedValue+")";



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
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();

                    textBox2.Focus();

                    //fecha a conexção
                    con.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("DADOS NÃO ENCONTRADOS " + ex.Message + "\n" + ex.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Application.Exit();

                }
                finally
                {
                    
                    MessageBox.Show("USUARIO CADASTRADO COM SUCESSO");
                    


                }
            }

        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {

            comboBox1.SelectedValue = -1;
            // TODO: This line of code loads data into the 'cad_pro_SEFAZDataSet.tb_perfil' table. You can move, or remove it, as needed.
            this.tb_perfilTableAdapter.Fill(this.cad_pro_SEFAZDataSet.tb_perfil);
            




        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnovoUser.PerformClick();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                DialogResult dialogo = MessageBox.Show("Deseja realmente excluir este usuário?" + "\n", "Finalizar Remessa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogo == DialogResult.Yes)
                {


                    if (textBox1.Text == String.Empty)
                    {
                        MessageBox.Show("Favor informar a usuário! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Focus();
                        return;
                    }

                    try
                    {




                        string strSql = "delete from tb_usuario where nmlogin = '" + textBox1.Text + "' ";



                        DataBaseConection str = new DataBaseConection();
                        //cria a conexão com o banco de dados
                        SqlConnection con = str.BuscarConexao();

                        SqlCommand cmd = new SqlCommand(strSql, con);

                        con.Open();

                        //define o tipo do comando
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandTimeout = 120;
                        //obtem um datareader

                        SqlDataReader dr = cmd.ExecuteReader();


                        textBox3.Clear();

                        if (dr.RecordsAffected >= 1)
                        {
                            con.Close();
                            MessageBox.Show("Usuário Deletado!");
                            textBox3.Clear();
                            textBox3.Focus();
                        }
                        else
                        {
                            con.Close();
                            MessageBox.Show("Usuário Inexistente!");
                            textBox3.Clear();
                            textBox3.Focus();

                        }
                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show("DADOS NÃO ENCONTRADOS " + ex.Message + "\n" + ex.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Application.Exit();

                    }

                }

            }
        }

        }
    
}
