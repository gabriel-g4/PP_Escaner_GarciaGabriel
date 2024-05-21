using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mapa : Documento
    {
        #region Atributos
        int alto;
        int ancho;
        #endregion

        #region Constructores
        public Mapa(string titulo, string autor, int anio, string numNormalizado, string barcode, int alto, int ancho)
            : base(titulo, autor, anio, "-1", barcode)
        {
            this.alto = alto;
            this.ancho = ancho;
        }
        #endregion


        #region Propiedades
        public int Alto
        {
            get => alto;
        }

        public int Ancho
        {
            get => ancho;
        }

        public int Superficie
        {
            get => Alto * Ancho;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Superficie: {alto} * {ancho} = {Superficie} cm2.");
            return sb.ToString();
        }
        #endregion

        #region Operadores
        public static bool operator ==(Mapa A, Mapa B)
        {
            if (A.Barcode == B.Barcode ||
                    (A.Titulo == B.Titulo && 
                    A.Autor == B.Autor && 
                    A.Anio == B.Anio && 
                    A.Superficie == B.Superficie))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Mapa A, Mapa B)
        {
            return !(A == B);
        }
        #endregion
    }
}
