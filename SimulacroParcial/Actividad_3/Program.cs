using Actividad_3.Enums;
using Actividad_3.Models;
namespace Remiseria
{
    class Program
    {
        static void Main()
        {
            Cliente Cliente = new Cliente("Lucas Martini", 3364628400);
            Cliente.AgregarMembresia();
            Conductor Conductor = new Conductor("Agustin Tarico", "XYH2398");
            Viaje viaje = new Viaje(Cliente, Conductor, Vehiculo.AutoEstandar, 15);
            viaje.FinalizarViaje();
        }
    }

}
