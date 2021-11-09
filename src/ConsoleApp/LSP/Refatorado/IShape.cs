namespace Solid.ConsoleApp.LSP.Refatorado
{
    public interface IShape
    {
        int Altura { get; }
        int Largura { get; }

        void InserirAltura(int altura);
        void InserirLargura(int largura);
    }
}