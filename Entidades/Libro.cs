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

        public static bool operator ==(Libro A, Libro B)
        {
            if (A.Barcode == B.Barcode || 
                A.ISBN == B.ISBN || 
               (A.Titulo == B.Titulo && A.Autor == B.Autor))
            {
                return true;
            }
            else
            {
                return false;
            }

            // Forma alternativa, peor pero más legible
            //if (A.Barcode == B.Barcode)
            //{
            //    return true;
            //}
            //else if (A.ISBN == B.ISBN)
            //{
            //    return true;
            //}
            //else if (A.Titulo == B.Titulo && A.Autor == B.Autor)
            //{
            //    return true;
            //}
            //else 
            //{
            //    return false;
            //}
        }

        public static bool operator !=(Libro A, Libro B)
        {
            return !(A == B);
        }
    }
}
