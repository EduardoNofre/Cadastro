using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;

namespace CadastroProtocolo
{
    public partial class pro_pallet : Form
    {
        public pro_pallet()
        {
            InitializeComponent();
        }

        private void pro_pallet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cad_proDataSet.tb_projeto' table. You can move, or remove it, as needed.
            this.tb_projetoTableAdapter.Fill(this.cad_proDataSet.tb_projeto);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    string strProvider = "Data Source=JONAS-PC;Initial Catalog=cad_pro_SEFAZ;Persist Security Info=True;User ID=sa;Password=senha@123; Connect Timeout = 120";
                    //define a instrução SQL





                    string strSql = "Select b.idpallet,b.nmpallet from tb_caixa a join tb_pallet b on a.idpallet = b.idpallet join tb_projeto  c on c.idprojeto = b.idprojeto  where c.idprojeto = '" + comboBox1.SelectedValue + "' and b.idstatus = 1";



                    //cria a conexão com o banco de dados
                    SqlConnection con = new SqlConnection(strProvider);
                    //cria o objeto command para executar a instruçao sql
                    SqlCommand cmd = new SqlCommand(strSql, con);

                    //abre a conexao
                    con.Open();
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    con.Close();
                    comboBox2.DataSource = dt;
                    comboBox2.DisplayMember = "nmpallet";
                    comboBox2.ValueMember = "idpallet";
                    comboBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
                    comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;

                }
                catch (Exception ex)
                {
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox2.Text == String.Empty )
            {
                MessageBox.Show("Favor Selecionar o pallet! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return;
            }
            
            
            string strProvider = "Data Source=JONAS-PC;Initial Catalog=cad_pro_SEFAZ;Persist Security Info=True;User ID=sa;Password=senha@123; Connect Timeout = 120";
            //define a instrução SQL





            // string strSql = "select idpallet,nmpallet from tb_pallet a join tb_projeto b on a.idprojeto = b.idprojeto where idstatus = 1 and a.idprojeto = 1";
            string strSql1 = "select ROW_NUMBER() OVER(ORDER BY dscaixa DESC) AS Row,dscaixa from tb_caixa  where idpallet = " + comboBox2.SelectedValue + " and idstatus = 3";




            //cria a conexão com o banco de dados
            SqlConnection con1 = new SqlConnection(strProvider);
            //cria o objeto command para executar a instruçao sql
            SqlCommand cmd1 = new SqlCommand(strSql1, con1);

            //abre a conexao
            con1.Open();
            //define o tipo do comando
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandTimeout = 120;

            SqlDataReader dr1 = null;

            dr1 = cmd1.ExecuteReader();




            while (dr1.Read())
            {

                listBox1.Items.Add(dr1["Row"].ToString() +" - "+ dr1["dscaixa"].ToString());
                
                   
               
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            {


                PrintDialog printDialog = new PrintDialog();

                PrintDocument printDocument = new PrintDocument();

                printDialog.Document = printDocument; //add the document to the dialog box...        

                printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

                //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

                DialogResult result = printDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    printDocument.Print();

                }
            }
        }

        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            
            
            //this prints the reciept

            Graphics graphic = e.Graphics;

            Font font = new Font("Aparajita", 14); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 50;
            int starty1 = 10;
            int offset = 40;
            offset = offset + 0; //make some room so that the total stands out.
            graphic.DrawString("                                                         Protocolo de Caixas " + comboBox1.Text + "", font, new SolidBrush(Color.Black), startX, starty1 + offset);
            offset = offset + 40; //make some room so that the total stands out.
            graphic.DrawString("                                                                                 Pallet: " + comboBox2.Text + "", font, new SolidBrush(Color.Black), startX, starty1 + offset);
            offset = offset + 0; //make some room so that the total stands out.


            System.Drawing.Image myImage = (pictureBox1.Image);

            graphic.DrawImage(myImage,startX, starty1);

            System.Drawing.Image myImage1 = (pictureBox2.Image);

            graphic.DrawImage(myImage1, 680, starty1);

 
           


            foreach (string item in listBox1.Items)
            {
               
                //create the string to print on the reciept


                String productDescription = item;
                


                if (productDescription.Contains("  -"))
                {
                    string productLine = productDescription.Substring(0, 24);


                    graphic.DrawString(productLine, new Font("Aparajita", 12, FontStyle.Italic), new SolidBrush(Color.Red), startX, startY + offset);

                    offset = offset + (int)fontHeight + 5 ; //make the spacing consistent
                }
                else
                {
                    string productLine = productDescription;

                    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);

                    offset = offset + (int)fontHeight + 5; //make the spacing consistent
                }

            }


            offset = offset + 30; //make some room so that the total stands out.
            graphic.DrawString("\n" + "\n" + "\n" + "\n" + "\n" + "_____________________________________ " + "\n" + "Representante " + comboBox1.Text + "", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 150; //make some room so that the total stands out.
            graphic.DrawString("\n" + "\n" + "\n" + "\n" + "\n" + "_____________________________________ " + "\n" + "Representante TCI", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 150; //make some room so that the total stands out.
            graphic.DrawString("\n" + "\n" + "Fortaleza " + dateTimePicker1.Value + "", font, new SolidBrush(Color.Black), startX, startY + offset);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
             try
            {
                string strProvider = "Data Source=JONAS-PC;Initial Catalog=cad_pro_SEFAZ;Persist Security Info=True;User ID=sa;Password=senha@123; Connect Timeout = 120";
                //define a instrução SQL




                // string strSql = "select idpallet,nmpallet from tb_pallet a join tb_projeto b on a.idprojeto = b.idprojeto where idstatus = 1 and a.idprojeto = 1";
                string strSql = "update tb_pallet set idstatus = 4 where idpallet = '" + comboBox2.SelectedValue + "'";



                //cria a conexão com o banco de dados
                SqlConnection con = new SqlConnection(strProvider);
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

        }

        
    

