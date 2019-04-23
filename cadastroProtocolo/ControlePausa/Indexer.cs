using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace CadastroProtocolo
{
    public partial class Indexer : Form
    {

        const int MF_BYPOSITION = 0x400;


        [DllImport("User32")]
        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("User32")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("User32")]
        private static extern int GetMenuItemCount(IntPtr hWnd);

        public string idusuario;
        public string idprojeto;
        public string idcaixa;
        public string dscaixa;

        public Indexer()
        {
            InitializeComponent();

        }

        public Indexer(string valor)
        {

            InitializeComponent();



        }
        NotifyIcon Notif = new NotifyIcon();
        private void Indexer_Load(object sender, EventArgs e)
        {




            this.Text = "Indexer Caixa: " + dscaixa;
            //Desabilita o botão Fechar (X)
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuItemCount = GetMenuItemCount(hMenu);
            RemoveMenu(hMenu, MenuItemCount - 1, MF_BYPOSITION);

            // TODO: This line of code loads data into the 'cad_proDataSet.tb_projeto' table. You can move, or remove it, as needed.
            this.tb_projetoTableAdapter.Fill(this.cad_proDataSet.tb_projeto);
            // TODO: This line of code loads data into the 'cad_proDataSet.tb_pallet' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'cad_proDataSet.tb_projeto' table. You can move, or remove it, as needed.
            this.tb_projetoTableAdapter.Fill(this.cad_proDataSet.tb_projeto);



            if (idprojeto != "" | idcaixa != "" | idusuario != "")
            {
                textBox1.Text = idprojeto;
                textBox2.Text = idcaixa;
                textBox7.Text = idusuario;
            }
            // if (idcaixa != "")
            // {
            //     textBox1.Text = idcaixa;
            // }

            // {

          



            // string strSql = "select idpallet,nmpallet from tb_pallet a join tb_projeto b on a.idprojeto = b.idprojeto where idstatus = 1 and a.idprojeto = 1";
            string strSql = "select idtipoprocesso,nmtipoprocesso from tb_tipo_processo where idprojeto = " + textBox1.Text + "";



            DataBaseConection str = new DataBaseConection();
            //cria a conexão com o banco de dados
            SqlConnection con = str.BuscarConexao();
            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd = new SqlCommand(strSql, con);

            //abre a conexao
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "nmtipoprocesso";
            comboBox2.ValueMember = "idtipoprocesso";

            // string strSql = "select idpallet,nmpallet from tb_pallet a join tb_projeto b on a.idprojeto = b.idprojeto where idstatus = 1 and a.idprojeto = 1";
            string strSql1 = "select count(iddocumento) as qtddoc from tb_documento where idcaixa = " + textBox2.Text + "";



            //cria a conexão com o banco de dados
 
            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd1 = new SqlCommand(strSql1, con);

            //abre a conexao
            con.Open();
            //define o tipo do comando
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandTimeout = 120;
            

            SqlDataReader dr1 = null;

            dr1 = cmd1.ExecuteReader();
           

            if (dr1.Read())
            {

                label48.Text = dr1["qtddoc"].ToString();




            }


            con.Close();

            //comboBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
            //comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;



        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               


                // string strSql = "select idpallet,nmpallet from tb_pallet a join tb_projeto b on a.idprojeto = b.idprojeto where idstatus = 1 and a.idprojeto = 1";
                string strSql = "select * from tb_tipo_documento a join tb_tipo_processo b on a.idtipoprocesso = b.idtipoprocesso where a.idtipoprocesso = '" + comboBox2.SelectedValue + "'";



                DataBaseConection str = new DataBaseConection();
                //cria a conexão com o banco de dados
                SqlConnection con = str.BuscarConexao();
                //cria o objeto command para executar a instruçao sql
                SqlCommand cmd = new SqlCommand(strSql, con);

                //abre a conexao
                con.Open();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                con.Close();
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "nmtipodocumento";
                comboBox3.ValueMember = "idtipodocumento";
                comboBox3.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;


            }
            catch (Exception ex)
            {
            }
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {






            //FICHA DE DADOS CADASTRAIS
            if (comboBox3.SelectedValue.ToString() == "1" | comboBox3.SelectedValue.ToString() == "1")
            {


                panel6.Visible = true;

            }


        }




        //btinsert

        private void button8_Click(object sender, EventArgs e)
        {



            {

                if (maskedTextBox4.Text == String.Empty | maskedTextBox14.Text == String.Empty)
                {
                    MessageBox.Show("Prencer todos os campos! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    return;
                }

                try
                {

                  


                    string strSql = "declare @identitydoc int "
+ "insert into tb_documento values (" + comboBox3.SelectedValue + ",getdate()," + textBox2.Text + "," + textBox7.Text + "); select @@identity "
+ "set @identitydoc = @@identity "
+ "insert into tb_valor_indice values ('000" + maskedTextBox4.Text + "',@identitydoc,1) "
+ "insert into tb_valor_indice values ('" + maskedTextBox14.Text + "',@identitydoc,2) "
+ "insert into tb_valor_indice values ('*"+ maskedTextBox14.Text +"000"+ maskedTextBox4.Text + "*',@identitydoc,4) "

+ "select indice,nmvalorindice from tb_valor_indice a "
+ "join tb_indice b on a.idindice = b.idindice "
+ "where iddocumento = @identitydoc";



                    DataBaseConection str = new DataBaseConection();
                    //cria a conexão com o banco de dados
                    SqlConnection con = str.BuscarConexao();
                    //cria o objeto command para executar a instruçao sql

                    SqlCommand cmd = new SqlCommand(strSql, con);

                    //SqlCommand cmd1 = new SqlCommand(novodocumento, con);


                    //con.Open();
                    //cmd1.CommandType = CommandType.Text;
                    //cmd1.CommandTimeout = 120;
                    //SqlDataReader dr1 = cmd1.ExecuteReader();
                    //con.Close();
                    //abre a conexao
                    con.Open();

                    //define o tipo do comando
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 120;
                    //obtem um datareader
                    

                    SqlDataReader dr = cmd.ExecuteReader();
                    


                    if (dr.HasRows)
                    {
                        con.Close();
                        maskedTextBox4.Clear();
                        maskedTextBox14.Clear();
                        maskedTextBox4.Focus();

                        //string strProvider = "Data Source=10.254.194.53;Initial Catalog=cad_pro_SEFAZ;Persist Security Info=True;User ID=sa;Password=senha@123; Connect Timeout = 120";
                        //define a instrução SQL



                        // string strSql = "select idpallet,nmpallet from tb_pallet a join tb_projeto b on a.idprojeto = b.idprojeto where idstatus = 1 and a.idprojeto = 1";
                        string strSql1 = "select count(iddocumento) as qtddoc from tb_documento where idcaixa = " + textBox2.Text + "";



                        
                        //cria o objeto command para executar a instruçao sql
                        SqlCommand cmd1 = new SqlCommand(strSql1, con);

                        //abre a conexao
                        con.Open();
                        //define o tipo do comando
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandTimeout = 120;

                        

                        SqlDataReader dr1 = null;

                        dr1 = cmd1.ExecuteReader();
                        

                    
                        if (dr1.Read())
                        {
                            

                            label48.Text = dr1["qtddoc"].ToString();
                            con.Close();

                        }

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

                }
            }
        }




        private void Indexer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtUpdate.PerformClick();
            }
        }


        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtUpdate.PerformClick();
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {

            DialogResult dialogo = MessageBox.Show("Deseja realmente fechar a remessa?" + "\n", "Finalizar Remessa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogo == DialogResult.Yes)
            {

                try
                {
                    




                    // string strSql = "select idpallet,nmpallet from tb_pallet a join tb_projeto b on a.idprojeto = b.idprojeto where idstatus = 1 and a.idprojeto = 1";
                    string strSql = "update tb_caixa set idstatus = 3 where idcaixa = '" + textBox2.Text + "'";



                    DataBaseConection str = new DataBaseConection();
                    //cria a conexão com o banco de dados
                    SqlConnection con = str.BuscarConexao();
                    //cria o objeto command para executar a instruçao sql
                    SqlCommand cmd = new SqlCommand(strSql, con);

                    //abre a conexao
                    con.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    con.Close();


                }
                catch (Exception ex)
                {

                }
                Close();
                


            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Deseja realmente suspender a remessa?" + "\n", "Suspender Remessa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogo == DialogResult.Yes)
            {

                try
                {
                   



                    // string strSql = "select idpallet,nmpallet from tb_pallet a join tb_projeto b on a.idprojeto = b.idprojeto where idstatus = 1 and a.idprojeto = 1";
                    string strSql = "update tb_caixa set idstatus = 1 where idcaixa = '" + textBox2.Text + "'";



                    DataBaseConection str = new DataBaseConection();
                    //cria a conexão com o banco de dados
                    SqlConnection con = str.BuscarConexao();
                    //cria o objeto command para executar a instruçao sql
                    SqlCommand cmd = new SqlCommand(strSql, con);

                    //abre a conexao
                    con.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    con.Close();



                }
                catch (Exception ex)
                {

                }
                Close();

            }
        }


        private void comboBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.maskedTextBox4.Focus();
            }
        }

        private void maskedTextBox4_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                {


                 


                    string strSql = "select CodParticipante from tb_auto_complete_participante where CodRemessa =  '" + maskedTextBox4.Text + "' ";



                    DataBaseConection str = new DataBaseConection();
                    //cria a conexão com o banco de dados
                    SqlConnection con = str.BuscarConexao();
                    //cria o objeto command para executar a instruçao sql

                    SqlCommand cmd = new SqlCommand(strSql, con);

                    //SqlCommand cmd1 = new SqlCommand(novodocumento, con);


                    //con.Open();
                    //cmd1.CommandType = CommandType.Text;
                    //cmd1.CommandTimeout = 120;
                    //SqlDataReader dr1 = cmd1.ExecuteReader();
                    //con.Close();
                    //abre a conexao
                    con.Open();

                    //define o tipo do comando
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 120;
                    //obtem um datareader

                    SqlDataReader dr = cmd.ExecuteReader();
                    

                    if (dr.HasRows)
                    {

                        con.Close();

                        BtUpdate.Visible = true;
                        BtInsert.Visible = false;
                        {


                            try
                            {

 


                                string strSql1 = "select CodParticipante from tb_auto_complete_participante where CodRemessa =  '" + maskedTextBox4.Text + "'";



                                //cria o objeto command para executar a instruçao sql

                                SqlCommand cmd1 = new SqlCommand(strSql1, con);

                                //SqlCommand cmd1 = new SqlCommand(novodocumento, con);


                                //con.Open();
                                //cmd1.CommandType = CommandType.Text;
                                //cmd1.CommandTimeout = 120;
                                //SqlDataReader dr1 = cmd1.ExecuteReader();
                                //con.Close();
                                //abre a conexao
                                con.Open();

                                //define o tipo do comando
                                cmd1.CommandType = CommandType.Text;
                                cmd1.CommandTimeout = 120;
                                //obtem um datareader

                                SqlDataReader dr1 = cmd1.ExecuteReader();

                                

                                if (dr1.HasRows)
                                {
                                    
                                    while (dr1.Read())
                                    {

                                        maskedTextBox14.Text = dr1["CodParticipante"].ToString();
                                        this.maskedTextBox14.Focus();


                                    }
                                    if (dr1.HasRows)
                                    {
                                       

                                        try
                                        {

                                            con.Close();




                                            string strSql2 = "select nmvalorindice from tb_valor_indice where iddocumento = " + textBox11.Text + "";


                                            System.Data.SqlClient.SqlCommand com = new System.Data.SqlClient.SqlCommand(string.Format("select nmvalorindice from tb_valor_indice where iddocumento = " + textBox11.Text + " ", CommandType.Text), con);

                                            SqlCommand cmd2 = new SqlCommand(strSql2, con);


                                            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(cmd2);
                                            cmd2.CommandType = CommandType.Text;
                                            cmd2.CommandTimeout = 120;
                                            DataTable dt = new DataTable();


                                            con.Open();
                                            da.Fill(dt);
                                            maskedTextBox14.Text = dt.Rows[1]["nmvalorindice"].ToString();


                                            con.Close();
                                        }

                                        catch (Exception ex)
                                        {

                                        }
                                    }

                                }

                            }





                            catch (Exception ex)
                            {
                                MessageBox.Show("DADOS NÃO ENCONTRADOS " + ex.Message + "\n" + ex.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                Application.Exit();

                            }

                            return;
                        }




                    }

                    else
                    {

                        this.maskedTextBox14.Focus();


                    }
                }
            }
        }

        private void maskedTextBox14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtInsert.PerformClick();
                this.BtUpdate.PerformClick();
            }
        }


        //btupdate
        private void button14_Click(object sender, EventArgs e)
        {

            {

                if (maskedTextBox4.Text == String.Empty | maskedTextBox14.Text == String.Empty)
                {
                    MessageBox.Show("Prencer todos os campos! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    return;
                }

                try
                {




                    string strSql = "declare @identitydoc int "
+ "insert into tb_documento values (" + comboBox3.SelectedValue + ",getdate()," + textBox2.Text + "," + textBox7.Text + "); select @@identity "
+ "set @identitydoc = @@identity "
+ "insert into tb_valor_indice values ('000"+ maskedTextBox4.Text + "',@identitydoc,1) "
+ "insert into tb_valor_indice values ('" + maskedTextBox14.Text + "',@identitydoc,2) "
+ "insert into tb_valor_indice values ('*"+ maskedTextBox14.Text +"000"+maskedTextBox4.Text + "*',@identitydoc,4) "

+ "select indice,nmvalorindice from tb_valor_indice a "
+ "join tb_indice b on a.idindice = b.idindice "
+ "where iddocumento = @identitydoc";



                    DataBaseConection str = new DataBaseConection();
                    //cria a conexão com o banco de dados
                    SqlConnection con = str.BuscarConexao();

                    SqlCommand cmd = new SqlCommand(strSql, con);

                    //SqlCommand cmd1 = new SqlCommand(novodocumento, con);


                    //con.Open();
                    //cmd1.CommandType = CommandType.Text;
                    //cmd1.CommandTimeout = 120;
                    //SqlDataReader dr1 = cmd1.ExecuteReader();
                    //con.Close();
                    //abre a conexao
                    con.Open();

                    //define o tipo do comando
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 120;
                    //obtem um datareader

                    SqlDataReader dr = cmd.ExecuteReader();
                    
                    if (dr.HasRows)
                    {

                        con.Close();
                        maskedTextBox4.Clear();
                        maskedTextBox14.Clear();
                        maskedTextBox4.Focus();

                        //string strProvider = "Data Source=10.254.194.53;Initial Catalog=cad_pro_SEFAZ;Persist Security Info=True;User ID=sa;Password=senha@123; Connect Timeout = 120";
                        //define a instrução SQL



                        // string strSql = "select idpallet,nmpallet from tb_pallet a join tb_projeto b on a.idprojeto = b.idprojeto where idstatus = 1 and a.idprojeto = 1";
                        string strSql1 = "select count(iddocumento) as qtddoc from tb_documento where idcaixa = " + textBox2.Text + "";




                        //cria o objeto command para executar a instruçao sql
                        SqlCommand cmd1 = new SqlCommand(strSql1, con);

                        //abre a conexao
                        con.Open();
                        //define o tipo do comando
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandTimeout = 120;

                        SqlDataReader dr1 = null;

                        dr1 = cmd1.ExecuteReader();

                        if (dr1.Read())
                        {

                            label48.Text = dr1["qtddoc"].ToString();




                        }

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
                    BtUpdate.Visible = false;
                    BtInsert.Visible = true;
                    maskedTextBox14.Clear();
                    maskedTextBox4.Focus();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            {

                if (maskedTextBox4.Text == String.Empty | maskedTextBox14.Text == String.Empty)
                {
                    MessageBox.Show("Prencer todos os campos! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    return;
                }

                try
                {




                    string strSql = "declare @tmp as table (iddocumento int) "
+ "insert into @tmp "
+ "select a.iddocumento from tb_valor_indice a "
+ "join tb_documento b on b.iddocumento = a.iddocumento "
+ "where nmvalorindice = '000" + maskedTextBox4.Text + "' and idcaixa =  "+ textBox2.Text +" "
+ "begin "
+ "delete from tb_valor_indice where iddocumento in(select distinct iddocumento from @tmp); "
+ "delete from tb_documento where iddocumento in (select distinct iddocumento from @tmp); "
+ "end ";



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
                    
                    

                    if(dr.RecordsAffected >= 1)
                    {
                        con.Close();
                        MessageBox.Show("Documento Excluido!");
                    }

                    else
                    {
                        con.Close();
                        MessageBox.Show("Documento Inexistente!");
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show("DADOS NÃO ENCONTRADOS " + ex.Message + "\n" + ex.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Application.Exit();

                }
                finally
                {
                    BtUpdate.Visible = false;
                    BtInsert.Visible = true;
                    maskedTextBox14.Clear();
                    maskedTextBox4.Clear();
                    maskedTextBox4.Focus();
                }
            }

        }
    }
}


    

    

       


       
      

