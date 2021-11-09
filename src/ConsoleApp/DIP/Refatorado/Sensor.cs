namespace Solid.ConsoleApp.DIP.Refatorado
{
    public class Sensor : IInterruptor
    {
        private readonly IDispositivo _dispositivo;

        public Sensor(IDispositivo dispositivo)
        {
            _dispositivo = dispositivo;
        }
        
        public void Acionar()
        {
            _dispositivo.Ligar();
        }
    }
}