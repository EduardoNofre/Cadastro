using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;
using System.Diagnostics;
using System.Data.SqlClient;

namespace CadastroProtocolo
{
    public partial class telamenu : Form
    {
        public string idusuario;


        public telamenu()
        {
            
            InitializeComponent();
            Load += comboBox4_SelectedIndexChanged;
            Load += telamenu_Load;


        }
        //a salvação para chamar um componete de outro frame
        public telamenu(string valor)
        {
            InitializeComponent();
            textBox1.Text = valor;
        }

        private void telamenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Application.Exit();
        }
        


        private void telamenu_Load(object sender, EventArgs e)
        {



            textBox2.Text = idusuario.ToString();
            


            // TODO: This line of code loads data into the 'cad_proDataSet.tb_projeto' table. You can move, or remove it, as needed.
            this.tb_projetoTableAdapter.Fill(this.cad_proDataSet.tb_projeto);

            try 
            
            {

          

            
                
            //string strProvider = "Data Source=10.254.194.53;Initial Catalog=cad_pro_SEFAZ;Persist Security Info=True;User ID=sa;Password=senha@123; Connect Timeout = 120";
            //define a instrução SQL




            string strSql = "select idperfil from tb_usuario where idusuario = '" + textBox2.Text + "' and idperfil = 1 ";



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

            if (dr.HasRows)
            {
                btConfig.Visible = true;

            }
            else 
                {
                BtAtrsenhausuario.Visible = true;
                }

            }
                catch (Exception ex)
                {
                    MessageBox.Show("DADOS NÃO ENCONTRADOS " + ex.Message + "\n" + ex.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Application.Exit();

                }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            groupPesquisa.Visible = false;
            groupPallet.Visible = true;
            groupIndexer.Visible = false;
            


        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmCadastroRemessa cadremessa = new CadastroProtocolo.FrmCadastroRemessa();
            cadremessa.Parent = this.Parent;
            cadremessa.ShowDialog();
            this.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            groupPesquisa.Visible = false;
            groupPallet.Visible = false;
            groupIndexer.Visible = true;    
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ProCaixa caixa = new CadastroProtocolo.ProCaixa();
            caixa.Parent = this.Parent;
            caixa.ShowDialog();
            this.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ImprimirPatch Gpatch = new CadastroProtocolo.ImprimirPatch();
            Gpatch.Parent = this.Parent;
            Gpatch.ShowDialog();
            this.Show();
        }


       

        private void button8_Click(object sender, EventArgs e)
        {

            {

                if (comboBox5.Text == String.Empty)
                {
                    MessageBox.Show("Favor escolha uma remessa! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    return;
                }

                try
                {




                    string strSql = "select * from tb_caixa where idcaixa = "+comboBox5.SelectedValue+" and idusuario is null or idusuario ="+idusuario+"";



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
                        try
                        {
                            con.Close();

                            // string strSql = "select idpallet,nmpallet from tb_pallet a join tb_projeto b on a.idprojeto = b.idprojeto where idstatus = 1 and a.idprojeto = 1";
                            string strSql1 = "update tb_caixa set idstatus = 2 where idcaixa = '" + comboBox5.SelectedValue + "'";
                            string strSql2 = "update tb_caixa set idusuario = " + idusuario + " where idcaixa = '" + comboBox5.SelectedValue + "'";





                            //cria a conexão com o banco de dados

                            //cria o objeto command para executar a instruçao sql
                            SqlCommand cmd1 = new SqlCommand(strSql1, con);
                            SqlCommand cmd2 = new SqlCommand(strSql2, con);
                            //abre a conexao
                            con.Open();
                            DataTable dt = new DataTable();
                            dt.Load(cmd1.ExecuteReader());
                            dt.Load(cmd2.ExecuteReader());
                            con.Close();

                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("FALHA DE ACESSO " + ex.Message + "\n" + ex.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        comboBox5.SelectedItem = -1;
                        Indexer frm = new Indexer();
                        frm.idprojeto = comboBox4.SelectedValue.ToString();
                        frm.idcaixa = comboBox5.SelectedValue.ToString();
                        frm.dscaixa = comboBox5.Text;
                        frm.idusuario = textBox2.Text;
                        frm.ShowDialog();
                        groupPallet.Visible = false;

                        Indexer indexer = new CadastroProtocolo.Indexer();
                        indexer.Parent = this.Parent;

                        this.button8.Enabled = true;

                        this.Show();
                        comboBox4.SelectedValue = -1;
                        comboBox5.SelectedValue = -1;


                    }
                    else
                    {

                        MessageBox.Show("A remessa "+comboBox5.Text+" já está em uso! \n Favor escolha outra remessa.");

                    }



                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DADOS NÃO ENCONTRADOS " + ex.Message + "\n" + ex.StackTrace, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Application.Exit();

                }
               
            }
        }

        


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
         {
            try
            {
                



                
                string strSql = "Select idcaixa,dscaixa from tb_caixa a join   tb_projeto  b on b.idprojeto = a.idprojeto  where b.idprojeto = '" + comboBox4.SelectedValue + "' and a.idstatus = 1";



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
                comboBox5.DataSource = dt;
                comboBox5.DisplayMember = "dscaixa";
                comboBox5.ValueMember = "idcaixa";
                comboBox5.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboBox5.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch (Exception ex)
            {
            }
        }

        

       


        
        

        private void button6_Click_1(object sender, EventArgs e)
        {
            CadastroUsuario usuario = new CadastroProtocolo.CadastroUsuario();
            usuario.Parent = this.Parent;
            usuario.ShowDialog();

            this.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            AlterarSenha alterarsenha = new CadastroProtocolo.AlterarSenha();
            alterarsenha.Parent = this.Parent;
            alterarsenha.ShowDialog();

            this.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            groupPallet.Visible = false;
            groupIndexer.Visible = false;
            groupPesquisa.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            buscaRemessa Bremessa = new CadastroProtocolo.buscaRemessa();
            Bremessa.Parent = this.Parent;
            Bremessa.ShowDialog();

            this.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            buscaParticipante Bparticipante = new CadastroProtocolo.buscaParticipante();
            Bparticipante.Parent = this.Parent;
            Bparticipante.ShowDialog();

            this.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            buscaLote Blote = new CadastroProtocolo.buscaLote();
            Blote.Parent = this.Parent;
            Blote.ShowDialog();

            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RelProducao Rproducao = new CadastroProtocolo.RelProducao();
            Rproducao.Parent = this.Parent;
            Rproducao.ShowDialog();

            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AlterarsenhaUsuariologado Atrsenha = new CadastroProtocolo.AlterarsenhaUsuariologado();
            Atrsenha.Parent = this.Parent;
            Atrsenha.idusuario = textBox1.Text;
            Atrsenha.ShowDialog();


            this.Show();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {

            FrmCadastroRemessa Atrremessa = new CadastroProtocolo.FrmCadastroRemessa();
            Atrremessa.Parent = this.Parent;
            Atrremessa.ShowDialog();


            this.Show();
        }


        }
  
        }

        

        
        
    




	


