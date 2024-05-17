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

        #region Operadores

        public static bool operator ==(Escaner e, Documento d)
        {
            foreach (Documento docElement in e.ListaDocumentos)
            {
                if (docElement == d)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Escaner e, Documento d)
        {
            return !(e == d);
        }

        #endregion

    }
}
