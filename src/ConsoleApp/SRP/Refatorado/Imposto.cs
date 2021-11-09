namespace Solid.ConsoleApp.SRP.Refatorado
{
    public abstract class Imposto
    {
        protected Imposto(EnumTipoImposto tipo)
        {
            Tipo = tipo;
        }

        public EnumTipoImposto Tipo { get; }
        public abstract int Calcular(Pedido pedido);
    }

    public class ICMS : Imposto
    {
        public ICMS() : base(EnumTipoImposto.ICMS)
        {
        }
        public override int Calcular(Pedido pedido)
        {
            return 0;
        }
    }
    
    public class IPI : Imposto
    {
        public IPI() : base(EnumTipoImposto.IPI)
        {
        }
        
        public override int Calcular(Pedido pedido)
        {
            return 0;
        }
    }

    public class CSLL : Imposto
    {
        public CSLL() : base(EnumTipoImposto.CSLL)
        {
            
        }

        public override int Calcular(Pedido pedido)
        {
            return 0;
        }
    }
}