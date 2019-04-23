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
    public partial class buscaParticipante : Form
    {
        public buscaParticipante()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtConsultar.PerformClick();

            }
        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            Boolean consulta = true;

            try
            {

             



                string strSql = "select remessa,lote,participante,[Status] as [Status da Remessa] from (select nmvalorindice as Lote,a.iddocumento from tb_valor_indice a "
+ "join tb_documento c on c.iddocumento = a.iddocumento where  a.idindice = 1 ) g "
+ "inner join (select nmvalorindice as Participante,d.iddocumento,dscaixa as Remessa,nmstatus as Status from tb_valor_indice d "
+ "join tb_documento e on d.iddocumento = e.iddocumento "
+ "join tb_caixa j on j.idcaixa = e.idcaixa "
+ "join tb_status k on k.idstatus = j.idstatus "
+ "where nmvalorindice = '" + textBox1.Text.Replace(" ", "") + "' and d.idindice = 2) h "
+ "on g.iddocumento = h.iddocumento "
+ "order by h.iddocumento";


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
    }
}
