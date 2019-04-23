using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.Xml.XPath;
using System.IO;
using System.Data.Sql;
using System.Configuration;


namespace CadastroProtocolo
{

    }
    public class DataBaseConection
    {
        private SqlConnection vConexao;



        public SqlConnection BuscarConexao()
        {
            try
            {

                vConexao = new SqlConnection();
                //vConexao.ConnectionString = ConfigurationManager.ConnectionStrings["StringConection"].ConnectionString;
                vConexao.ConnectionString = DecryptConnString();
                return vConexao;
            }
            catch
            {
                return null;
            }
        }

        private string DecryptConnString()
        {
            string conexaoDescript = string.Empty;
            try
            {
                Byte[] b = Convert.FromBase64String(ConfigurationManager.ConnectionStrings["StringConection"].ConnectionString);
                conexaoDescript = System.Text.ASCIIEncoding.ASCII.GetString(b);

            }
            catch (Exception)
            {
                throw new Exception("ERRO AO DECRIPTOGRAFAR A STRING DE CONEXÃO\n" +
                                  "VERIFIQUE O ARQUIVO DE CONFIGURAÇÃO [TCIOperation.exe.config]!");
            }
            return conexaoDescript;
        }

        
    }

      
      
