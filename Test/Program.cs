using Entidades;
using System;
using System.Collections.Concurrent;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Libro libro1 = new Libro("Libro 1", "Autor 1", 1990, "123", "barcode1", 27);
            //Libro libro2 = new Libro("Libro 2", "Autor 2", 2000, "456", "barcode2", 500);

            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine(libro1.Estado);
            //    libro1.AvanzarEstado();
            //}

            //Console.WriteLine();
            //Console.WriteLine(libro1.ToString());
            //Console.WriteLine();
            //Console.WriteLine(libro2.ToString());

            //Console.WriteLine(libro1 == libro2);

            //Mapa mapa1 = new Mapa("Mapa1", "Autor1", 1990, "nN", "123", 20, 30);
            //Mapa mapa2 = new Mapa("Mapa2", "Autor2", 2000, "nN", "456", 30, 40);


            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine(mapa1.Estado);
            //    mapa1.AvanzarEstado();
            //}

            //Console.WriteLine();
            //Console.WriteLine(mapa1.ToString());
            //Console.WriteLine();
            //Console.WriteLine(mapa2.ToString());

            //Console.WriteLine(mapa1 == mapa2);


            //Console.WriteLine(e.Marca);
            //Console.WriteLine(e.Locacion);
            //Console.WriteLine(e.Tipo);
            //Console.WriteLine(e.ListaDocumentos);

            //Escaner e = new Escaner("Marca 1", Escaner.TipoDoc.mapa);
            //Mapa mapaNuevo = new Mapa("Mapa nuevo", "Autor", 1990, "isbn", "123", 20, 30);
            //Mapa mapaCopia = new Mapa("Mapa nuevo", "Autor", 1990, "isbn", "123", 20, 30);
            //Mapa mapaNuevo2 = new Mapa("Mapa nuevo", "Autor", 1990, "isbn", "312", 20, 30);
            //Console.WriteLine("MAPA NUEVO 1");
            //Console.WriteLine(e + mapaNuevo);
            //Console.WriteLine("MAPA COPIA");
            //Console.WriteLine(e + mapaCopia);
            //Console.WriteLine("MAPA NUEVO 2");
            //Console.WriteLine(e + mapaNuevo2);
            //Console.WriteLine($"Comparacion {mapaNuevo == mapaNuevo2}");

            Escaner e = new Escaner("Marca 1", Escaner.TipoDoc.libro);
            Libro libroNuevo = new Libro("Libro nuevo", "Autor", 1990, "isbn", "123", 200);
            Libro libroCopia = new Libro("Libro copia", "Autor", 1990, "isbn", "123", 200);
            Libro libroNuevo2 = new Libro("Libro nuevo 2", "Autor", 1990, "isbn2", "12356", 200);
            Console.WriteLine("NUEVO 1");
            Console.WriteLine(e + libroNuevo);
            Console.WriteLine("COPIA");
            Console.WriteLine(e + libroCopia);
            Console.WriteLine("NUEVO 2");
            Console.WriteLine(e + libroNuevo2);

            //foreach (Documento d in e.ListaDocumentos)
            //{
            //    Console.WriteLine(d);
            //}

            Console.WriteLine(libroNuevo.Estado);
            Console.WriteLine(e.CambiarEstadoDocumento(libroNuevo));
            Console.WriteLine(libroNuevo.Estado);
            Console.WriteLine(e.CambiarEstadoDocumento(libroNuevo2));

            Console.WriteLine("DISTRIBUIDOS");
            Informes.MostrarDistribuidos(e, out int extension, out int cantidad, out string resumen);
            Console.WriteLine($"{extension}\n{cantidad}\n{resumen}");

            Console.WriteLine("EN ESCANER");
            Informes.MostrarEnEscaner(e, out extension, out cantidad, out resumen);
            Console.WriteLine($"{extension}\n{cantidad}\n{resumen}");

            Console.WriteLine("EN REVISION");
            Informes.MostrarEnRevision(e, out extension, out cantidad, out resumen);
            Console.WriteLine($"{extension}\n{cantidad}\n{resumen}");

            Console.WriteLine("TERMINADOS");
            Informes.MostrarTerminados(e, out extension, out cantidad, out resumen);
            Console.WriteLine($"{extension}\n{cantidad}\n{resumen}");


        }
    }
}
