using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Configuration;


namespace CadastroProtocolo
{
    
    public partial class telalogin : Form
    {

        public telamenu telamenu;
        public AlterarsenhaUsuariologado AlterarsenhaUsuariologado;
        public Thread tipoThread;
        public int Porta;
  

        public telalogin()
        {
            
            InitializeComponent();


        }


        public telalogin(telamenu telamenu)
        {
            // TODO: Complete member initialization
            this.telamenu = telamenu;

        }

        public telalogin(AlterarsenhaUsuariologado AlterarsenhaUsuariologado)
        {
            // TODO: Complete member initialization
            this.AlterarsenhaUsuariologado = AlterarsenhaUsuariologado;

        }

        public void Logar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtUsuario.Text == String.Empty)
                {
                    MessageBox.Show("Favor prencher os campos Usuário e Senha! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    return;
                }


                

              
                //define a instrução SQL

                

                

                string strSql = "select idusuario,nmlogin,senha from tb_usuario where nmlogin = '" + txtUsuario.Text + "' and senha = '" + txtSenha.Text + "' ";


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
               
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = txtUsuario.Text;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtSenha.Text;

                

                SqlDataReader dr = null;

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    this.Hide();

                    telamenu frmp = new telamenu(txtUsuario.Text);
                    
                    frmp.idusuario = dr["idusuario"].ToString();

                    frmp.Show();
      
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Incorretos! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Clear();
                    txtSenha.Clear();
                    txtUsuario.Focus();
                }

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
                
            }
        }

        public void telalogin_Activated(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        public void telalogin_Load(object sender, EventArgs e)
        {
            this.Text = "Cadastro e Protocolo - " + Application.ProductVersion + " Login";


            CheckForIllegalCrossThreadCalls = false;

       //dynamic Registro = Microsoft.VisualBasic.Interaction.CreateObject("WScript.Shell", "");

       //Registro.regwrite("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\ControlePausa",Application.ExecutablePath);

        }

        private void telalogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Logar.PerformClick();
            }
        }


        

        private void telalogin_FormClosing(object sender, FormClosingEventArgs e)
        {

            System.Environment.Exit(System.Environment.ExitCode);

        }

}        
}


