namespace Solid.ConsoleApp.LSP.Refatorado
{
    public class Quadrado : IShape
    {
        public int Altura { get; private set; }
        public int Largura { get; private set; }

        public void InserirAltura(int altura)
        {
            Altura = altura;
            Largura = altura;
        }

        public void InserirLargura(int largura)
        {
            Altura = largura;
            Largura = largura;
        }
    }
}