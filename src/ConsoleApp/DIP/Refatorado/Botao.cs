namespace Solid.ConsoleApp.DIP.Refatorado
{
    public class Botao : IInterruptor
    {
        private readonly IDispositivo _dispositivo;

        public Botao(IDispositivo dispositivo)
        {
            _dispositivo = dispositivo;
        }

        public void Acionar()
        {
            if (_dispositivo.Ligado)
            {
                _dispositivo.Desligar();
                return;
            }

            _dispositivo.Ligar();
        }
    }
}