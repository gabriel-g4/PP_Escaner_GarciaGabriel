using Entidades;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Documento doc = new Documento("Libro 1", "Autor 1", 1990, "123", "barcode1");
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
