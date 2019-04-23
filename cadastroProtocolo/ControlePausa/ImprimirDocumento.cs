using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;

namespace CadastroProtocolo
{
    class ImprimirDocumento : PrintDocument
    {
          
        private string[] texto;
        private int numeroPagina;
        private int offset;

        public string[] Texto
        {
            get { return texto; }
            set { texto = value; }
        }

        public int NumeroPagina
        {
            get { return numeroPagina; }
            set { numeroPagina = value; }
        }

        public int Offset
        {
            get { return offset; }
            set { offset = value; }
        }

        public ImprimirDocumento(string[] _texto)
        {
            this.Texto = _texto;
        }
    }
    
}
