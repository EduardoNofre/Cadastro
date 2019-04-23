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
    public partial class RelProducao : Form
    {
        public RelProducao()
        {
            InitializeComponent();
        }

        void Rremessa()
        { 
        dataGridView1.Columns.Clear();
            Boolean consulta = true;

            try
            {

 


                string strSql = "SELECT upper (nmlogin) as Usuario,dscaixa as Caixa,LTRIM(LEFT(CONVERT(VARCHAR(20), min(dtinclusao), 108), 8))[Hora Inicial],LTRIM(LEFT(CONVERT(VARCHAR(20), max(dtinclusao), 108), 8))[Hora Final],LTRIM(LEFT(CONVERT(VARCHAR(20), max(dtinclusao)- min(dtinclusao), 108), 8)) [Tempo Gasto],count(distinct a.iddocumento)Documentos "
+ "from tb_documento a  "
+ "join tb_usuario b on a.idusuario = b.idusuario "
+ "join tb_caixa c on c.idcaixa = a.idcaixa "
+ "where CONVERT(VARCHAR(20),  dtinclusao, 103) = '" + dateTimePicker2.Text + "' and idprojeto = " + comboBox1.SelectedValue + " and idtipodocumento = " + comboBox2.SelectedValue + " "
+ "group by NmLogin,dscaixa";


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
                //obtem um datareader

                SqlDataReader dr = cmd.ExecuteReader();
                int nColunas = dr.FieldCount;
                for (int i = 0; i < nColunas; i++)
                {
                    dataGridView1.Columns.Add(dr.GetName(i).ToString(), dr.GetName(i).ToString());
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                }

                //define um array de strings com nCOlunas
                string[] linhaDados = new string[nColunas];
                //percorre o DataRead



                consulta = false;
                while (dr.Read())
                {
                    //percorre cada uma das colunas
                    for (int a = 0; a < nColunas; a++)
                    {
                        //verifica o tipo de dados da coluna
                        if (dr.GetFieldType(a).ToString() == "System.Int32")
                        {
                            linhaDados[a] = dr.GetInt32(a).ToString();
                        }
                        if (dr.GetFieldType(a).ToString() == "System.String")
                        {
                            linhaDados[a] = dr.GetString(a).ToString();
                        }
                        if (dr.GetFieldType(a).ToString() == "System.DateTime")
                        {
                            linhaDados[a] = dr.GetDateTime(a).ToString();
                        }

                    }

                    if (consulta) MessageBox.Show("DADOS NÃO ENCONTRADOS");
                    dataGridView1.Rows.Add(linhaDados);

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

        void RUsuario()
        { 
        dataGridView1.Columns.Clear();
            Boolean consulta = true;

            try
            {

                



                string strSql = "SELECT upper (nmlogin) as Usuario,count(distinct a.iddocumento)Documentos "
+ "from tb_documento a  "
+ "join tb_usuario b on a.idusuario = b.idusuario "
+ "join tb_caixa c on c.idcaixa = a.idcaixa "
+ "where CONVERT(VARCHAR(20),  dtinclusao, 103) = '" + dateTimePicker2.Text + "' and idprojeto = " + comboBox1.SelectedValue + " and idtipodocumento = " + comboBox2.SelectedValue + " "
+ "group by NmLogin";


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
                //obtem um datareader

                SqlDataReader dr = cmd.ExecuteReader();
                int nColunas = dr.FieldCount;
                for (int i = 0; i < nColunas; i++)
                {
                    dataGridView1.Columns.Add(dr.GetName(i).ToString(), dr.GetName(i).ToString());
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                }

                //define um array de strings com nCOlunas
                string[] linhaDados = new string[nColunas];
                //percorre o DataRead



                consulta = false;
                while (dr.Read())
                {
                    //percorre cada uma das colunas
                    for (int a = 0; a < nColunas; a++)
                    {
                        //verifica o tipo de dados da coluna
                        if (dr.GetFieldType(a).ToString() == "System.Int32")
                        {
                            linhaDados[a] = dr.GetInt32(a).ToString();
                        }
                        if (dr.GetFieldType(a).ToString() == "System.String")
                        {
                            linhaDados[a] = dr.GetString(a).ToString();
                        }
                        if (dr.GetFieldType(a).ToString() == "System.DateTime")
                        {
                            linhaDados[a] = dr.GetDateTime(a).ToString();
                        }

                    }

                    if (consulta) MessageBox.Show("DADOS NÃO ENCONTRADOS");
                    dataGridView1.Rows.Add(linhaDados);


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
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) 


                 Rremessa();


            if (radioButton2.Checked == true) 


                 RUsuario();
            
           
        }

        private void RelProducao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cad_pro_SEFAZDataSet.tb_tipo_documento' table. You can move, or remove it, as needed.
            this.tb_tipo_documentoTableAdapter.Fill(this.cad_pro_SEFAZDataSet.tb_tipo_documento);
            // TODO: This line of code loads data into the 'cad_pro_SEFAZDataSet.tb_projeto' table. You can move, or remove it, as needed.
            this.tb_projetoTableAdapter.Fill(this.cad_pro_SEFAZDataSet.tb_projeto);
            dateTimePicker2.Value = DateTime.Today;

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtgeraRel.PerformClick();
            }
        }
    }
}

