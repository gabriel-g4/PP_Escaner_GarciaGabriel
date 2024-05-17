using Entidades;
using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Libro 1", "Autor 1", 1990, "123", "barcode1", 27);
            Libro libro2 = new Libro("Libro 2", "Autor 2", 2000, "456", "barcode2", 500);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(libro1.Estado);
                libro1.AvanzarEstado();
            }

            Console.WriteLine();
            Console.WriteLine(libro1.ToString());
            Console.WriteLine();
            Console.WriteLine(libro2.ToString());

            Console.WriteLine(libro1 == libro2);

            Mapa mapa1 = new Mapa("Mapa1", "Autor1", 1990, "123", 20, 30);
            Mapa mapa2 = new Mapa("Mapa2", "Autor2", 2000, "456", 30, 40);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(mapa1.Estado);
                mapa1.AvanzarEstado();
            }

            Console.WriteLine();
            Console.WriteLine(mapa1.ToString());
            Console.WriteLine();
            Console.WriteLine(mapa2.ToString());

            Console.WriteLine(mapa1 == mapa2);

        }
    }
}
