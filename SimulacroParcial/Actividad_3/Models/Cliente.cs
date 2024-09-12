namespace Actividad_3.Models
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public double Telefono { get; private set; }
        public bool Membresia { get; private set; }
        public Cliente(string nombre, double telefono) { 
            Nombre = nombre;
            Telefono = telefono;
        }
        public void AgregarMembresia()
        {
            Membresia = true;
        }
    }
}
