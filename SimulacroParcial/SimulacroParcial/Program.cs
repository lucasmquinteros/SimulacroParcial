using Act_1.Modulos;
namespace Tienda
{
    class Program
    {
        static void Main()
        {
            Cliente cliente = new Cliente("Lucas", 628400, "01");
            Producto celular = new Producto("Iphone 11 ProMax", 300000, "01");
            Venta venta = new Venta(DateTime.Now, celular, 1, cliente);
            Console.WriteLine($"{venta.MostrarVenta()}");
        }
    }
}