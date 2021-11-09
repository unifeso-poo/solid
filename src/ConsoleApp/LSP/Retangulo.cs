namespace Solid.ConsoleApp.LSP
{
    public class Retangulo
    {
        public int Largura { get; protected set; }
        public int Altura { get; protected set; }

        public virtual void InserirAltura(int altura) => Altura = altura;
        public virtual void InserirLargura(int largura) => Largura = largura;
    }
}