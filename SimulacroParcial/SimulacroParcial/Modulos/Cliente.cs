namespace Act_1.Modulos
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public double Telefono { get; private set; }
        public string Codigo { get; private set; }
        public Cliente(string nombre, double telefono, string codigo)
        {
            Nombre = nombre;
            Telefono = telefono;
            Codigo = codigo;
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Cliente: {Nombre}\nTelefono: {Telefono}\nCodigo: {Codigo}");
        }
    }
}
