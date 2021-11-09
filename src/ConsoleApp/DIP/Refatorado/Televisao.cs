namespace Solid.ConsoleApp.DIP.Refatorado
{
    public class Televisao : IDispositivo
    {
        public bool Ligado { get; private set; }
        public void Desligar()
        {
            Ligado = false;
        }

        public void Ligar()
        {
            Ligado = true;
        }
    }
}