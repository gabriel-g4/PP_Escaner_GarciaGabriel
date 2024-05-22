using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Escaner
    {
        #region Atributos
        List<Documento> listaDocumentos;
        Departamento locacion;
        string marca;
        TipoDoc tipo;
        #endregion

        #region Constructores
        public Escaner(string marca, TipoDoc tipo)
        {
            this.marca = marca;
            this.tipo = tipo;
            listaDocumentos = new List<Documento>();
            locacion = (tipo == TipoDoc.mapa) ? Departamento.mapoteca : Departamento.procesosTecnicos;
        }
        #endregion

        #region Enums
        public enum Departamento
        {
            nulo,
            mapoteca,
            procesosTecnicos
        }

        public enum TipoDoc
        {
            libro,
            mapa
        }
        #endregion

        #region Propiedades
        public List<Documento> ListaDocumentos
        {
            get => listaDocumentos;
        }

        public Departamento Locacion
        {
            get => locacion;
        }

        public string Marca
        {
            get => marca;
        }

        public TipoDoc Tipo
        {
            get => tipo;
        }
        #endregion

        #region Métodos

        public bool CambiarEstadoDocumento(Documento d)
        {
            if (this == d)
            {
                d.AvanzarEstado();
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Operadores

        public static bool operator ==(Escaner e, Documento d)
        {
            if (e.Tipo == TipoDoc.mapa) //&& d.GetType() == typeof(Mapa))
            {
                foreach (Documento docElement in e.listaDocumentos)
                {
                    if ((Mapa)docElement == (Mapa)d)
                    {
                        return true;
                    }
                }
            }
            else
            {
                foreach (Documento docElement in e.listaDocumentos)
                {
                    if ((Libro)docElement == (Libro)d)
                    {
                        return true;
                    }
                }
            }

            return false;

            //foreach (Documento docElement in e.listaDocumentos)
            //{
            //    if (docElement == d)
            //    {
            //        return true;
            //    }
            //}


            //return false;
        }

        public static bool operator !=(Escaner e, Documento d)
        {
            return !(e == d);
        }


        public static bool operator +(Escaner e, Documento d)
        {
            if (e != d &&
                d.Estado == Documento.Paso.Inicio &&
                    ((e.Tipo == TipoDoc.libro && d.GetType() == typeof(Libro)) ||
                    (e.Tipo == TipoDoc.mapa && d.GetType() == typeof(Mapa))))
            {
                d.AvanzarEstado();
                e.listaDocumentos.Add(d);
                return true;
            }

            return false;
        }
        #endregion

    }
}
