namespace Solid.ConsoleApp.DIP
{
    public class Lampada
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