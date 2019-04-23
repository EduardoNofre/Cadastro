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
    public partial class AlterarRemessa : Form
    {
        public AlterarRemessa()
        {
            InitializeComponent();
        }

        private void AlterarRemessa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cad_pro_SEFAZDataSet.tb_caixa' table. You can move, or remove it, as needed.
            this.tb_caixaTableAdapter.Fill(this.cad_pro_SEFAZDataSet.tb_caixa);
            // TODO: This line of code loads data into the 'cad_pro_SEFAZDataSet.tb_status' table. You can move, or remove it, as needed.
            this.tb_statusTableAdapter.Fill(this.cad_pro_SEFAZDataSet.tb_status);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogo = MessageBox.Show("Deseja realmente alterar a remessa?" + "\n", "Alterar Remessa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogo == DialogResult.Yes)
            {

                try
                {
                    

                    // string strSql = "select idpallet,nmpallet from tb_pallet a join tb_projeto b on a.idprojeto = b.idprojeto where idstatus = 1 and a.idprojeto = 1";
                    string strSql = "update tb_caixa set idstatus = " + comboBox1.SelectedValue + " where dscaixa = '" + textBox1.Text + "'";



                    DataBaseConection str = new DataBaseConection();
                    //cria a conexão com o banco de dados
                    SqlConnection con = str.BuscarConexao();
                    //cria o objeto command para executar a instruçao sql
                    SqlCommand cmd = new SqlCommand(strSql, con);

                    //abre a conexao
                    con.Open();
                 
                    SqlDataReader dr = cmd.ExecuteReader();

                    con.Close();

                }
                catch (Exception ex)
                {

                }

                Close();
                


            }
        }

        }
    
}
