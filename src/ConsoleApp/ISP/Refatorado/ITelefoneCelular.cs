namespace Solid.ConsoleApp.ISP.Refatorado
{
    public interface ITelefone
    {
        void Tocar();
        void Discar();
    }
    
    public interface ITelefoneCelular : ITelefone
    {
        void TirarFoto();
    }
}