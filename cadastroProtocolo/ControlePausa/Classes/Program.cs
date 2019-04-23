using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;


namespace CadastroProtocolo
{
    public class Program
    {


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            string meuProcesso = Process.GetCurrentProcess().ProcessName;



            // Procura o processo atual na lista de processos que estão a ser executados neste momento, no computador

            Process[] processos = Process.GetProcessesByName(meuProcesso);



            // Além desta instância, já existe mais alguma?

            if (processos != null && processos.Length > 1)
            {

                // Mostra uma mensagem, e termina esta instância...

                MessageBox.Show("PROGRMA JÁ EM EXECUÇÃO! " + "\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {

                // Permite executar a aplicação

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new telalogin());


            }
        }
        
    }
}
