using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro : Documento
    {
        #region Atributos
        int numPaginas;
        #endregion

        #region Constructores
        public Libro(string titulo, string autor, int anio, string numNormalizado, string barcode, int numPaginas)
            : base (titulo, autor, anio, numNormalizado, barcode)
        {
            this.numPaginas = numPaginas;
        }
        #endregion

        #region Propiedades
        public string ISBN
        {
            get => NumNormalizado;
        }

        public int NumPaginas
        {
            get => numPaginas;
        }
        #endregion

        #region Métodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Número de páginas: {numPaginas}.");
            return sb.ToString();
        }
        #endregion


        #region Operadores
        public static bool operator ==(Libro A, Libro B)
        {
            Console.WriteLine("Entro en el igual de libro");
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
        }

        public static bool operator !=(Libro A, Libro B)
        {
            return !(A == B);
        }
        #endregion
    }
}
