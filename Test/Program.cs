using Entidades;

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
        }
    }
}
