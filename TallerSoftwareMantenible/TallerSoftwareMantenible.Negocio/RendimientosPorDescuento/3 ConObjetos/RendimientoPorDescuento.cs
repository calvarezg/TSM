using System;

namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConObjetos
{
    public class RendimientoPorDescuento
    {
        private double elValorFacial;
        private double elValorTransadoBruto;

        public RendimientoPorDescuento(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual, bool tieneTratamientoFiscal)
        {
            this.elValorFacial = elValorFacial;
            elValorTransadoBruto = ObtengaElValorTransadoBruto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual, tieneTratamientoFiscal);            
        }

        private static double ObtengaElValorTransadoBruto(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual, bool tieneTratamientoFiscal)
        {
            if (tieneTratamientoFiscal)
                return new ValorTransadoBruto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual).ComoNumero();
            else
                return elValorTransadoNeto;
        }

        public double ComoNumero()
        {
            return elValorFacial - elValorTransadoBruto;
        }
    }
}