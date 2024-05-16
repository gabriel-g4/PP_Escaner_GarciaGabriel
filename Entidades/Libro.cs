using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro : Documento
    {
        int numPaginas;

        public Libro(string titulo, string autor, int anio, string numNormalizado, string barcode, int numPaginas)
            : base (titulo, autor, anio, numNormalizado, barcode)
        {
            this.numPaginas = numPaginas;
        }

        public string ISBN
        {
            get => NumNormalizado;
        }

        public int NumPaginas
        {
            get => numPaginas;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Número de páginas: {numPaginas}.");

            return sb.ToString();
        }

    }
}
