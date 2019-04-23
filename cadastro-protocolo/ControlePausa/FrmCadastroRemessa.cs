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
    public partial class FrmCadastroRemessa : Form
    {
        public FrmCadastroRemessa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty | textBox2.Text == String.Empty)
            {
                MessageBox.Show("Favor preencha todos os campos! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            string strSql = "select * from tb_caixa where dscaixa = '"+textBox1.Text+"'+'/'+right ((CONVERT(VARCHAR(20), GETDATE(), 103)),4)  and idstatus <> 6";



                DataBaseConection str = new DataBaseConection();
                //cria a conexão com o banco de dados
                SqlConnection con = str.BuscarConexao();
                //cria o objeto command para executar a instruçao sql

                SqlCommand cmd = new SqlCommand(strSql, con);

                con.Open();

                //define o tipo do comando
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 120;
                //obtem um datareader

                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    MessageBox.Show("Caixa já cadastrada anteriormente! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                else
                {


                   

                    {

                        try
                        {

                            string strSql1 = "declare  @numero int ,@dscaixa varchar(18) ,@ano varchar(18) "

+"set @numero = "+textBox1.Text+" "
+ "set @dscaixa = 0 "
+"set @ano = right ((CONVERT(VARCHAR(20), GETDATE(), 103)),4) "
+ "while  @numero >='" + textBox1.Text + "' and  @numero <='" + textBox2.Text + "' "
+"begin "
+"insert into tb_caixa (dscaixa,idstatus,idprojeto) "
+ "values (CONVERT(VARCHAR(20), @numero, 12)+'/'+@ano,1,1) "

+"set @numero =  @numero +1 "

+"end";



                            SqlConnection con1 = str.BuscarConexao();
                            //cria o objeto command para executar a instruçao sql

                            SqlCommand cmd1 = new SqlCommand(strSql1, con1);

                            //SqlCommand cmd1 = new SqlCommand(novodocumento, con);


                            //con.Open();
                            //cmd1.CommandType = CommandType.Text;
                            //cmd1.CommandTimeout = 120;
                            //SqlDataReader dr1 = cmd1.ExecuteReader();
                            //con.Close();
                            //abre a conexao
                            con1.Open();

                            //define o tipo do comando
                            cmd1.CommandType = CommandType.Text;
                            cmd1.CommandTimeout = 120;
                            //obtem um datareader

                            SqlDataReader dr1 = cmd1.ExecuteReader();

                            textBox1.Focus();
                            textBox1.Clear();
                            textBox2.Clear();

                            if (dr.HasRows)
                            {

                            }
                            con.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("DADOS NÃO ENCONTRADOS " + ex.Message + "\n" + ex.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            Application.Exit();

                        }
                        finally
                        {
                            MessageBox.Show("Caixa cadastrada com sucesso!  \n", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Deseja realmente excluir esta remessa remessa?" + "\n", "Finalizar Remessa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogo == DialogResult.Yes)
            {


                if (textBox3.Text == String.Empty)
                {
                    MessageBox.Show("Favor informar a Remessa! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    return;
                }

                try
                {




                    string strSql = "declare @tmp as table (iddocumento int)  "
+"insert into @tmp  "
+"select a.iddocumento from tb_valor_indice a "
+"join tb_documento b on b.iddocumento = a.iddocumento "
+"join tb_caixa c on c.idcaixa = b.idcaixa "
+"where  dscaixa =  '"+textBox3.Text+"' "
+"begin "
+"delete from tb_valor_indice where iddocumento in(select distinct iddocumento from @tmp); "
+"delete from tb_documento where iddocumento in (select distinct iddocumento from @tmp); "
+"delete from tb_caixa where idcaixa in (select distinct idcaixa from @tmp); "
+"end" ;



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
                        MessageBox.Show("Remessa Deletada!");
                        textBox3.Clear();
                        textBox3.Focus();
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("Remessa Inexistente!");
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == String.Empty)
                {
                    MessageBox.Show("Favor informar a Remessa! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    return;
                }

                try
                {




                    string strSql = "update tb_caixa set idstatus = 1 where dscaixa = '"+textBox4.Text+"'";




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
                        MessageBox.Show("Remessa Liberada!");
                        textBox4.Clear();
                        textBox4.Focus();

                    }
                    else {
                        con.Close();
                        MessageBox.Show("Remessa Inexistente!");
                        textBox4.Clear();
                        textBox4.Focus();
                    }
                    
                }


                catch (Exception ex)
                {
                    MessageBox.Show("DADOS NÃO ENCONTRADOS " + ex.Message + "\n" + ex.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Application.Exit();

                }
                
            }

        private void FrmCadastroRemessa_Load(object sender, EventArgs e)
        {

            // string strSql = "select idpallet,nmpallet from tb_pallet a join tb_projeto b on a.idprojeto = b.idprojeto where idstatus = 1 and a.idprojeto = 1";
            string strSql = "select top 1 dscaixa from tb_caixa order by idcaixa desc";



            DataBaseConection str = new DataBaseConection();
            //cria a conexão com o banco de dados
            SqlConnection con = str.BuscarConexao();

            SqlCommand cmd = new SqlCommand(strSql, con);
            //cria o objeto command para executar a instruçao sql


            //abre a conexao
            con.Open();
            //define o tipo do comando
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 120;

            SqlDataReader dr1 = null;

            dr1 = cmd.ExecuteReader();

            if (dr1.Read())
            {

                label5.Text = dr1["dscaixa"].ToString();




            }
        }

        }
        }

