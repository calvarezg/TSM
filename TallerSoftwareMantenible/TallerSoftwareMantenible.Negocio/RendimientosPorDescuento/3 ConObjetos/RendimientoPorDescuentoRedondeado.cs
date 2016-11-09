using System;

namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConObjetos
{
    public class RendimientoPorDescuentoRedondeado
    {
        private double elRendimientoPorDescuento;

        public RendimientoPorDescuentoRedondeado(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual, bool tieneTratamientoFiscal)
        {
            elRendimientoPorDescuento = new RendimientoPorDescuento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual, tieneTratamientoFiscal).ComoNumero();            
        }
        
        public double ConCuatroDecimales()
        {
            return Math.Round(elRendimientoPorDescuento, 4);
        }
    }
}