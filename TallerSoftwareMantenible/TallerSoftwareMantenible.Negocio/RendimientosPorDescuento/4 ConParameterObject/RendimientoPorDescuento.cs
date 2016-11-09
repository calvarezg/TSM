using System;

namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConParameterObject
{
    public class RendimientoPorDescuento
    {
        private double elValorFacial;
        private double elValorTransadoBruto;

        public RendimientoPorDescuento(DatosDeRendimiento losDatos)
        {
            elValorFacial = losDatos.ValorFacial;
            elValorTransadoBruto = ObtengaElValorTransadoBruto(losDatos);
        }

        private static double ObtengaElValorTransadoBruto(DatosDeRendimiento losDatos)
        {
            // TODO: mas de una cosa
            if (losDatos.TieneTratamientoFiscal)
                return new ValorTransadoBruto(losDatos).ComoNumero();
            else
                return losDatos.ValorTransadoNeto;
        }

        public double ComoNumero()
        {
            return elValorFacial - elValorTransadoBruto;
        }
    }
}