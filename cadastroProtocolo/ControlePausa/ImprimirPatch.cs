using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace CadastroProtocolo
{
    public partial class ImprimirPatch : Form
    {
        public ImprimirPatch()
        {
            InitializeComponent();

        }

        ReportDocument Crystal = new ReportDocument();

        private void BtGerarPatch_Click(object sender, EventArgs e)
        {



            Crystal.SetDatabaseLogon("cad_pro_SEFAZ", "suanota_sefaz01");


            if (maskedTextBox1.Text == String.Empty)
                {
                    MessageBox.Show("Favor digitar o número da remessa! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                DataBaseConection str = new DataBaseConection();
                //cria a conexão com o banco de dados
                SqlConnection con = str.BuscarConexao();


                SqlDataAdapter sda = new SqlDataAdapter("select nmvalorindice from tb_valor_indice a join tb_documento b on a.iddocumento = b.iddocumento join tb_caixa c on c.idcaixa = b.idcaixa where dscaixa  = '" + maskedTextBox1.Text + "'  and a.idindice = 4 ", con);

                DataSet Ds = new DataSet();

                sda.Fill(Ds,"tb_valor_indice");

                Crystal.SetDataSource(Ds);
                CrvGerarPatch.ReportSource = Crystal;
                con.Close();
                

            }
        



private void ImprimirPatch_Load(object sender, EventArgs e)
        {

            
// TODO: This line of code loads data into the 'cad_pro_SEFAZDataSet.tb_projeto' table. You can move, or remove it, as needed.
this.tb_projetoTableAdapter.Fill(this.cad_pro_SEFAZDataSet.tb_projeto);
Crystal.Load(@"C:\Cad_Pro\BarCode.rpt");


        }
        }

        }

        
