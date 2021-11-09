namespace Solid.ConsoleApp.LSP
{
    public class Quadrado : Retangulo
    {
        public override void InserirAltura(int altura)
        {
            Altura = altura;
            Largura = altura;
        }

        public override void InserirLargura(int largura)
        {
            Altura = largura;
            Largura = largura;
        }
    }
}