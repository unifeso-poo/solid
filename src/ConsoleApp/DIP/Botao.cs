namespace Solid.ConsoleApp.DIP
{
    public class Botao
    {
        private readonly Lampada _lampada;

        public Botao(Lampada lampada)
        {
            _lampada = lampada;
        }

        public void Acionar()
        {
            if (_lampada.Ligado)
            {
                _lampada.Desligar();
                return;
            }

            _lampada.Ligar();
        }
    }
}