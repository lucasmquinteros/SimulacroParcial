namespace Actividad_3.Models
{
    public class Conductor
    {
        public string Nombre { get; private set; }
        public string Licencia { get; private set; }
        public bool Disponible { get; private set; } = true;
        public Conductor(string nombre, string licencia)
        {
            Nombre = nombre;
            Licencia = licencia;
        }
        public void CambiarOcupado()
        {
            Disponible = !Disponible;
        }
    }
}
