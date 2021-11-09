namespace Solid.ConsoleApp.DIP.Refatorado
{
    public class Lampada : IDispositivo
    {
        public bool Ligado { get; private set; }
        
        public void Ligar()
        {
            Ligado = true;
        }

        public void Desligar()
        {
            Ligado = false;
        }
    }
}