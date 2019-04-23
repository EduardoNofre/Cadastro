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


    public partial class pro_caixa : Form
    {

        private StringReader myReader;
        
        public pro_caixa()
        {
            InitializeComponent();
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCabecalho);
            
            
        }



        private void button1_Click(object sender, EventArgs e)
        {


            if (tbTipodoc.Text == "24")
            {


                listBox1.Items.Clear();
                

                if (comboBox2.Text == String.Empty)
                {
                    MessageBox.Show("Favor Selecionar a caixa! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                string strProvider = "Data Source=JONAS-PC;Initial Catalog=cad_pro_SEFAZ;Persist Security Info=True;User ID=sa;Password=senha@123; Connect Timeout = 120";
                //define a instrução SQL





                // string strSql = "select idpallet,nmpallet from tb_pallet a join tb_projeto b on a.idprojeto = b.idprojeto where idstatus = 1 and a.idprojeto = 1";
                //string strSql1 = "select ROW_NUMBER() OVER(ORDER BY nmvalorindice DESC) AS Row, indice,nmvalorindice from tb_valor_indice a join tb_indice b on a.idindice = b.idindice "
                //    + "join tb_documento c on c.iddocumento = a.iddocumento where c.idcaixa = "+comboBox2.SelectedValue+" and indice in ('Fornecedor','Data') order by a.iddocumento,indice desc";

                string strSql1 = "select * from (select ROW_NUMBER() OVER(ORDER BY a.iddocumento) AS Row,nmvalorindice as NOME,a.iddocumento from tb_valor_indice a "
    + "join tb_documento c on c.iddocumento = a.iddocumento where c.idcaixa = " + comboBox2.SelectedValue + "  and a.idindice = 54 ) g "
    + "inner join (select nmvalorindice as RA,d.iddocumento from tb_valor_indice d "
    + "join tb_documento e on d.iddocumento = e.iddocumento where e.idcaixa = " + comboBox2.SelectedValue + " and d.idindice = 55) h "
    + "on g.iddocumento = h.iddocumento order by h.iddocumento";


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


                    listBox1.Items.Add(dr1["Row"].ToString() + ": " + dr1["NOME"].ToString() + ": " + dr1["RA"].ToString());

                }

            }
            if (tbTipodoc.Text == "11")
            {


                listBox1.Items.Clear();
                

                if (comboBox2.Text == String.Empty)
                {
                    MessageBox.Show("Favor Selecionar a caixa! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                string strProvider = "Data Source=JONAS-PC;Initial Catalog=cad_pro_SEFAZ;Persist Security Info=True;User ID=sa;Password=senha@123; Connect Timeout = 120";
                //define a instrução SQL





                // string strSql = "select idpallet,nmpallet from tb_pallet a join tb_projeto b on a.idprojeto = b.idprojeto where idstatus = 1 and a.idprojeto = 1";
                //string strSql1 = "select ROW_NUMBER() OVER(ORDER BY nmvalorindice DESC) AS Row, indice,nmvalorindice from tb_valor_indice a join tb_indice b on a.idindice = b.idindice "
                //    + "join tb_documento c on c.iddocumento = a.iddocumento where c.idcaixa = "+comboBox2.SelectedValue+" and indice in ('Fornecedor','Data') order by a.iddocumento,indice desc";

                string strSql1 = "select * from (select ROW_NUMBER() OVER(ORDER BY a.iddocumento) AS Row,nmvalorindice as NOME,a.iddocumento from tb_valor_indice a "
    + "join tb_documento c on c.iddocumento = a.iddocumento where c.idcaixa = " + comboBox2.SelectedValue + "  and a.idindice = 2 ) g "
    + "inner join (select nmvalorindice as RA,d.iddocumento from tb_valor_indice d "
    + "join tb_documento e on d.iddocumento = e.iddocumento where e.idcaixa = " + comboBox2.SelectedValue + " and d.idindice = 4) h "
    + "on g.iddocumento = h.iddocumento order by h.iddocumento";


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


                    listBox1.Items.Add(dr1["Row"].ToString() + ": " + dr1["NOME"].ToString() + ": " + dr1["RA"].ToString());

                }

            }
            if (tbTipodoc.Text == "14")
            {


                listBox1.Items.Clear();


                if (comboBox2.Text == String.Empty)
                {
                    MessageBox.Show("Favor Selecionar a caixa! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                string strProvider = "Data Source=JONAS-PC;Initial Catalog=cad_pro_SEFAZ;Persist Security Info=True;User ID=sa;Password=senha@123; Connect Timeout = 120";
                //define a instrução SQL





                // string strSql = "select idpallet,nmpallet from tb_pallet a join tb_projeto b on a.idprojeto = b.idprojeto where idstatus = 1 and a.idprojeto = 1";
                //string strSql1 = "select ROW_NUMBER() OVER(ORDER BY nmvalorindice DESC) AS Row, indice,nmvalorindice from tb_valor_indice a join tb_indice b on a.idindice = b.idindice "
                //    + "join tb_documento c on c.iddocumento = a.iddocumento where c.idcaixa = "+comboBox2.SelectedValue+" and indice in ('Fornecedor','Data') order by a.iddocumento,indice desc";

                string strSql1 = "select * from (select ROW_NUMBER() OVER(ORDER BY a.iddocumento) AS Row,nmvalorindice as NOME,a.iddocumento from tb_valor_indice a "
    + "join tb_documento c on c.iddocumento = a.iddocumento where c.idcaixa = " + comboBox2.SelectedValue + "  and a.idindice = 26 ) g "
    + "inner join (select nmvalorindice as RA,d.iddocumento from tb_valor_indice d "
    + "join tb_documento e on d.iddocumento = e.iddocumento where e.idcaixa = " + comboBox2.SelectedValue + " and d.idindice = 27) h "
    + "on g.iddocumento = h.iddocumento order by h.iddocumento";


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


                    listBox1.Items.Add(dr1["Row"].ToString() + ": " + dr1["NOME"].ToString() + ": " + dr1["RA"].ToString());

                }

            }
            if (tbTipodoc.Text == "22")
            {


                listBox1.Items.Clear();


                if (comboBox2.Text == String.Empty)
                {
                    MessageBox.Show("Favor Selecionar a caixa! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                string strProvider = "Data Source=JONAS-PC;Initial Catalog=cad_pro_SEFAZ;Persist Security Info=True;User ID=sa;Password=senha@123; Connect Timeout = 120";
                //define a instrução SQL





                // string strSql = "select idpallet,nmpallet from tb_pallet a join tb_projeto b on a.idprojeto = b.idprojeto where idstatus = 1 and a.idprojeto = 1";
                //string strSql1 = "select ROW_NUMBER() OVER(ORDER BY nmvalorindice DESC) AS Row, indice,nmvalorindice from tb_valor_indice a join tb_indice b on a.idindice = b.idindice "
                //    + "join tb_documento c on c.iddocumento = a.iddocumento where c.idcaixa = "+comboBox2.SelectedValue+" and indice in ('Fornecedor','Data') order by a.iddocumento,indice desc";

                string strSql1 = "select * from (select ROW_NUMBER() OVER(ORDER BY a.iddocumento) AS Row,nmvalorindice as NOME,a.iddocumento from tb_valor_indice a "
    + "join tb_documento c on c.iddocumento = a.iddocumento where c.idcaixa = " + comboBox2.SelectedValue + "  and a.idindice = 8 ) g "
    + "inner join (select nmvalorindice as RA,d.iddocumento from tb_valor_indice d "
    + "join tb_documento e on d.iddocumento = e.iddocumento where e.idcaixa = " + comboBox2.SelectedValue + " and d.idindice = 9) h "
    + "on g.iddocumento = h.iddocumento order by h.iddocumento";


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


                    listBox1.Items.Add(dr1["Row"].ToString() + ": " + dr1["NOME"].ToString() + ": " + dr1["RA"].ToString());

                }

            }
            if (tbTipodoc.Text == "12")
            {


                listBox1.Items.Clear();


                if (comboBox2.Text == String.Empty)
                {
                    MessageBox.Show("Favor Selecionar a caixa! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                string strProvider = "Data Source=JONAS-PC;Initial Catalog=cad_pro_SEFAZ;Persist Security Info=True;User ID=sa;Password=senha@123; Connect Timeout = 120";
                //define a instrução SQL





                // string strSql = "select idpallet,nmpallet from tb_pallet a join tb_projeto b on a.idprojeto = b.idprojeto where idstatus = 1 and a.idprojeto = 1";
                //string strSql1 = "select ROW_NUMBER() OVER(ORDER BY nmvalorindice DESC) AS Row, indice,nmvalorindice from tb_valor_indice a join tb_indice b on a.idindice = b.idindice "
                //    + "join tb_documento c on c.iddocumento = a.iddocumento where c.idcaixa = "+comboBox2.SelectedValue+" and indice in ('Fornecedor','Data') order by a.iddocumento,indice desc";

                string strSql1 = "select * from (select ROW_NUMBER() OVER(ORDER BY a.iddocumento) AS Row,nmvalorindice as NOME,a.iddocumento from tb_valor_indice a "
    + "join tb_documento c on c.iddocumento = a.iddocumento where c.idcaixa = " + comboBox2.SelectedValue + "  and a.idindice = 13 ) g "
    + "inner join (select nmvalorindice as RA,d.iddocumento from tb_valor_indice d "
    + "join tb_documento e on d.iddocumento = e.iddocumento where e.idcaixa = " + comboBox2.SelectedValue + " and d.idindice = 14) h "
    + "on g.iddocumento = h.iddocumento order by h.iddocumento";


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


                    listBox1.Items.Add(dr1["Row"].ToString() + ": " + dr1["NOME"].ToString() + ": " + dr1["RA"].ToString());

                }

            }
            if (tbTipodoc.Text == "23")
            {


                listBox1.Items.Clear();


                if (comboBox2.Text == String.Empty)
                {
                    MessageBox.Show("Favor Selecionar a caixa! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                string strProvider = "Data Source=JONAS-PC;Initial Catalog=cad_pro_SEFAZ;Persist Security Info=True;User ID=sa;Password=senha@123; Connect Timeout = 120";
                //define a instrução SQL





                // string strSql = "select idpallet,nmpallet from tb_pallet a join tb_projeto b on a.idprojeto = b.idprojeto where idstatus = 1 and a.idprojeto = 1";
                //string strSql1 = "select ROW_NUMBER() OVER(ORDER BY nmvalorindice DESC) AS Row, indice,nmvalorindice from tb_valor_indice a join tb_indice b on a.idindice = b.idindice "
                //    + "join tb_documento c on c.iddocumento = a.iddocumento where c.idcaixa = "+comboBox2.SelectedValue+" and indice in ('Fornecedor','Data') order by a.iddocumento,indice desc";

                string strSql1 = "select * from (select ROW_NUMBER() OVER(ORDER BY a.iddocumento) AS Row,nmvalorindice as NOME,a.iddocumento from tb_valor_indice a "
    + "join tb_documento c on c.iddocumento = a.iddocumento where c.idcaixa = " + comboBox2.SelectedValue + "  and a.idindice = 19 ) g "
    + "inner join (select nmvalorindice as RA,d.iddocumento from tb_valor_indice d "
    + "join tb_documento e on d.iddocumento = e.iddocumento where e.idcaixa = " + comboBox2.SelectedValue + " and d.idindice = 20) h "
    + "on g.iddocumento = h.iddocumento order by h.iddocumento";


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


                    listBox1.Items.Add(dr1["Row"].ToString() + ": " + dr1["NOME"].ToString() + ": " + dr1["RA"].ToString());

                }

            }
        }



        private void pro_caixa_Load(object sender, EventArgs e)
        {
            this.listBox1.MultiColumn = false;
            // TODO: This line of code loads data into the 'cad_proDataSet.tb_projeto' table. You can move, or remove it, as needed.
            this.tb_projetoTableAdapter.Fill(this.cad_proDataSet.tb_projeto);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        PrintDialog printDialog = new PrintDialog();

        PrintDocument printDocument = new PrintDocument();
        printDialog.Document = printDocument;

        string strText = "";
        foreach (object x in listBox1.Items)
        {
            strText = strText + x.ToString() + "\n";

        }



        myReader = new StringReader(strText);
        if (printDialog.ShowDialog() == DialogResult.OK)     
        
        {
        this.printDocument1.Print();
        this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCabecalho);

        }

                
        }


        public void printCabecalho(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            //this prints the reciept


            Graphics graphic = e.Graphics;

            Font font = new Font("Arial", 10); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 10;
            int starty1 = 10;
            int starty2 = 15;
            int offset = 40;
            int startY = 50;
          

            offset = offset + 0; //make some room so that the total stands out.
            graphic.DrawString("                                                                                  Protocolo de Lote " + tbProjeto.Text + "", font, new SolidBrush(Color.Black), startX, starty1 + offset);
            offset = offset + 20; //make some room so that the total stands out.
            graphic.DrawString("                                                                                     Lote: " + comboBox2.Text + "", font, new SolidBrush(Color.Black), startX, starty1 + offset);

            
            offset = offset + 900; //make some room so that the total stands out.
            graphic.DrawString("\n" + "\n" + "\n" + "\n" + "\n" + "_____________________________________                                                        _____________________________________ " + "\n" + "Representante TCI                                                                                                      " + "Representante " + tbProjeto.Text + "" + "\n" + "                                                                            Fortaleza " + dateTimePicker1.Value + "", font, new SolidBrush(Color.Black), startX, startY + offset);
             
            System.Drawing.Image myImage = (pictureBox1.Image);

            graphic.DrawImage(myImage, startX, starty1);

            System.Drawing.Image myImage1 = (pictureBox2.Image);

            graphic.DrawImage(myImage1, 550, starty2);

            float linesPerPage = 0;
            float yPosition = 0;
            int count = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            string line = null;
            Font printFont = this.listBox1.Font;
            SolidBrush myBrush = new SolidBrush(Color.Black);

            // Work out the number of lines per page, using the MarginBounds.
            linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);

            // Iterate over the string using the StringReader, printing each line.
            while (count < linesPerPage && ((line = myReader.ReadLine()) != null))
            {
                // calculate the next line position based on
                // the height of the font according to the printing device
                yPosition = topMargin + (count * printFont.GetHeight(e.Graphics));

                // draw the next line in the rich edit control

                e.Graphics.DrawString(line, printFont,
                                        myBrush, leftMargin,
                                        yPosition, new StringFormat());
                count++;
            }
            // If there are more lines, print another page.
            
            
            if (line != null)
                e.HasMorePages = true;
            if (count >= 70) //se o valor do contador de etiquetas for 60 
            {
                e.HasMorePages = true; //Adiciona uma página
                count = 0; // Contador de etiquetas volta a ser zero
            }
            else
                e.HasMorePages = false;

            myBrush.Dispose();


            



            
        }

      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                
                try
                {
                    string strProvider = "Data Source=JONAS-PC;Initial Catalog=cad_pro_SEFAZ;Persist Security Info=True;User ID=sa;Password=senha@123; Connect Timeout = 120";
                    //define a instrução SQL





                    string strSql = "Select idcaixa,dscaixa from tb_caixa a join tb_pallet b on a.idpallet = b.idpallet join tb_projeto  c on c.idprojeto = b.idprojeto  where c.idprojeto = '" + comboBox1.SelectedValue + "' and a.idstatus = 3";



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
                    comboBox2.DisplayMember = "dscaixa";
                    comboBox2.ValueMember = "idcaixa";
                    comboBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
                    comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;

                   

                }
                catch (Exception ex)
                {
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             try
            {
                string strProvider = "Data Source=JONAS-PC;Initial Catalog=cad_pro_SEFAZ;Persist Security Info=True;User ID=sa;Password=senha@123; Connect Timeout = 120";
                //define a instrução SQL




                // string strSql = "select idpallet,nmpallet from tb_pallet a join tb_projeto b on a.idprojeto = b.idprojeto where idstatus = 1 and a.idprojeto = 1";
                string strSql = "update tb_caixa set idstatus = 4 where idcaixa = '" + comboBox2.SelectedValue + "'";



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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


            comboBox1.SelectedValue = -1;
            try
            {

                string strProvider = "Data Source=JONAS-PC;Initial Catalog=cad_pro_SEFAZ;Persist Security Info=True;User ID=sa;Password=senha@123; Connect Timeout = 120";


                string strSql = "select top 1 b.idtipodocumento,nmprojeto from tb_documento a "
+"join tb_tipo_documento b  on a.idtipodocumento = b.idtipodocumento "
+"join tb_tipo_processo c on c.idtipoprocesso = b.idtipoprocesso "
+"join tb_projeto d on d.idprojeto = c.idprojeto "
+ "where idcaixa = "+ comboBox2.SelectedValue +"";



                //cria a conexão com o banco de dados
                SqlConnection con = new SqlConnection(strProvider);
                //cria o objeto command para executar a instruçao sql
                SqlCommand cmd = new SqlCommand(strSql, con);

                //abre a conexao
                con.Open();
                //define o tipo do comando
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 120;

                SqlDataReader dr = null;

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {



                    tbTipodoc.Text = dr["idtipodocumento"].ToString();
                    tbProjeto.Text = dr["nmprojeto"].ToString();
                    



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

        private void button4_Click(object sender, EventArgs e)
        {
            {

                PrintDialog printDialog = new PrintDialog();

                PrintDocument printDocument = new PrintDocument();
                printDialog.Document = printDocument;

                string strText = "";
                foreach (object x in listBox1.Items)
                {
                    strText = strText + x.ToString() + "\n";

                }



                myReader = new StringReader(strText);
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    this.printDocument1.Print();
                    this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCabecalho);

                }


            }
        }

        }

        }

       
       
    


