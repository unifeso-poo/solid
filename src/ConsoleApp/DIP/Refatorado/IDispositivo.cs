namespace Solid.ConsoleApp.DIP.Refatorado
{
    public interface IDispositivo
    {
        bool Ligado { get; }
        void Desligar();
        void Ligar();
    }
}