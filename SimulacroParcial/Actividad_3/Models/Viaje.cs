using Actividad_3.Enums;

namespace Actividad_3.Models
{
    public class Viaje
    {
        public Cliente Cliente {  get; private set; }
        public Conductor Conductor { get; private set; }
        public double TarifaBase { get; private set; }
        public Vehiculo Vehiculo { get; private set; }
        public double Distancia { get; private set; }
        
        public Viaje(Cliente cliente, Conductor conductor, Vehiculo vehiculo, double distancia)
        {
            this.Cliente = cliente;
            this.Conductor = conductor;
            Conductor.CambiarOcupado();;
            Vehiculo = vehiculo;
            Distancia = distancia;
        }
        public double CalcularCosto()
        {
            double Total = 0;
            Total += Distancia * 2;
            if(Cliente.Membresia == false)
            {
                return Total;
            }
            else
            {
                return Total * 0.9;
            }
        }
        public void FinalizarViaje()
        {
            Conductor.CambiarOcupado();
            Console.WriteLine($"Viaje Finalizado\nCosto: {CalcularCosto()}");
        }
    }
}
