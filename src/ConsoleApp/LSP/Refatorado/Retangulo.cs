namespace Solid.ConsoleApp.LSP.Refatorado
{
    public class Retangulo : IShape
    {
        public int Largura { get; protected set; }
        public int Altura { get; protected set; }

        public void InserirAltura(int altura) => Altura = altura;
        public void InserirLargura(int largura) => Largura = largura;
    }
}