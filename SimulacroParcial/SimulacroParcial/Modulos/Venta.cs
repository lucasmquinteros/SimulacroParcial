namespace Act_1.Modulos
{
    public class Venta
    {
        public DateTime Fecha { get; private set; }
        public Producto ProductoVendido { get; private set; }
        public int Cantidad { get; private set; }
        public Cliente Cliente { get; private set; }
        public Venta(DateTime fecha, Producto productoVendido, int cantidad, Cliente cliente)
        {
            Fecha = fecha;
            ProductoVendido = productoVendido;
            Cantidad = cantidad;
            Cliente = cliente;
        }
        public double CalcularTotal()
        {
            return ProductoVendido.Precio;
        }
        public string MostrarVenta()
        {
            string mensaje = $"El cliente {Cliente.Nombre}\nCompro el producto: {ProductoVendido.Nombre} a un precio de {ProductoVendido.Precio :C}";
            return mensaje;
        }
    }
}
