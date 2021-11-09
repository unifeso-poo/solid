using System;

namespace Solid.ConsoleApp.OCP
{
    public class Imposto
    {
        public int Calcular(EnumTipoImposto tipoImposto, Pedido pedido)
        {
            switch (tipoImposto)
            {
                case EnumTipoImposto.ICMS:
                    return CalcularICMS(pedido);
                case EnumTipoImposto.IPI:
                    return CalcularIPI(pedido);
                case EnumTipoImposto.PIS:
                    return CalcularPIS(pedido);
                case EnumTipoImposto.COFINS:
                    return CalcularCOFINS(pedido);
                case EnumTipoImposto.II:
                    return CalcularII(pedido);
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipoImposto), tipoImposto, null);
            }
        }

        private int CalcularII(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        private int CalcularCOFINS(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        private int CalcularPIS(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        private int CalcularIPI(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        private int CalcularICMS(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
}