using Entidades;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro doc = new Libro("Libro 1", "Autor 1", 1990, "123", "barcode1", 27);
            Console.WriteLine(doc.Estado);
            doc.AvanzarEstado();
            Console.WriteLine(doc.Estado);
            doc.AvanzarEstado(); 
            Console.WriteLine(doc.Estado);
            doc.AvanzarEstado();
            Console.WriteLine(doc.Estado);
            doc.AvanzarEstado();
            Console.WriteLine(doc.Estado);
            doc.AvanzarEstado();
            Console.WriteLine(doc.Estado);
            doc.AvanzarEstado();

            Console.WriteLine(doc.ToString());
        }
    }
}
