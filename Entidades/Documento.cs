using System.Text;

namespace Entidades
{
    public abstract class Documento
    {
        #region Atributos
        int anio;
        string autor;
        string barcode;
        Paso estado;
        string numNormalizado;
        string titulo;
        #endregion

        #region Constructores
        public Documento(string titulo, string autor, int anio, 
                         string numNormalizado, string barcode)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anio = anio;
            this.numNormalizado = numNormalizado;
            this.barcode = barcode;
            this.estado = Paso.Inicio;
        }
        #endregion

        #region Enums
        public enum Paso
        {
            Inicio,
            Distribuido,
            EnEscaner,
            EnRevision,
            Terminado
        }
        #endregion

        #region Propiedades
        public int Anio
        {
            get => anio;
        }

        public string Autor
        {
            get => autor;
        }

        public string Barcode
        {
            get => barcode;
        }

        public Paso Estado
        {
            get => estado;
        }

        protected string NumNormalizado
        {
            get => numNormalizado;
        }

        public string Titulo
        {
            get => titulo;
        }
        #endregion

        #region Metodos
        public bool AvanzarEstado()
        {
            if (estado != Paso.Terminado)
            {
                estado += 1;
                return true;
            }
            else
            {
                return false;
            }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Título: {titulo}");
            sb.AppendLine($"Autor: {autor}");
            sb.AppendLine($"Año: {anio}");
            if (numNormalizado != "no tiene")
            {
                sb.AppendLine($"ISBN: {numNormalizado}");
            }
            sb.AppendLine($"Cód. de barras: {barcode}");
            return sb.ToString();
        }
        #endregion
    }
}
