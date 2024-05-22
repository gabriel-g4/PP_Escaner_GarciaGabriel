using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Informes
    {
        public static void MostrarDistribuidos(Escaner e, out int extension, out int cantidad, out string resumen)
        {

        }

        private static void MostrarDocumentosPorEstado(Escaner e, Documento.Paso estado, out int extension, out int cantidad, out string resumen)
        {
            foreach (Documento d in e.ListaDocumentos)
            {
                if (d.Estado == estado)
                {

                }
            }
        }

        public static void MostrarEnEscaner(Escaner e, out int extension, out int cantidad, out string resumen)
        {

        }

        public static void MostrarEnRevision(Escaner e, out int extension, out int cantidad, out string resumen)
        {

        }

        public static void MostrarTerminados(Escaner e, out int extension, out int cantidad, out string resumen)
        {

        }
    }
}
