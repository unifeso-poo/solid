namespace Solid.ConsoleApp.OCP.Refatorado
{
    public abstract class Imposto
    {
        protected Imposto(global::EnumTipoImposto tipo)
        {
            Tipo = tipo;
        }

        public global::EnumTipoImposto Tipo { get; }
        public abstract int Calcular(SRP.Pedido pedido);
    }

    public class ICMS : Imposto
    {
        public ICMS() : base(global::EnumTipoImposto.ICMS)
        {
        }
        public override int Calcular(SRP.Pedido pedido)
        {
            return 0;
        }
    }
    
    public class IPI : Imposto
    {
        public IPI() : base(global::EnumTipoImposto.IPI)
        {
        }
        
        public override int Calcular(SRP.Pedido pedido)
        {
            return 0;
        }
    }

    public class CSLL : Imposto
    {
        public CSLL() : base(global::EnumTipoImposto.CSLL)
        {
            
        }

        public override int Calcular(SRP.Pedido pedido)
        {
            return 0;
        }
    }
}