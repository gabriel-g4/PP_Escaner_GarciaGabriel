using Entidades;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro doc = new Libro("Libro 1", "Autor 1", 1990, "123", "barcode1", 27);
            
            
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(doc.Estado);
                doc.AvanzarEstado();
            }

            Console.WriteLine();
            Console.WriteLine(doc.ToString());
        }
    }
}
