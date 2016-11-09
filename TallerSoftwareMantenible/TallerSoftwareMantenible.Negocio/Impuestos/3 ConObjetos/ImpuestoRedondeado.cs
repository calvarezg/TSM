using System;

namespace TallerSoftwareMantenible.Negocio.Impuestos.ConObjetos
{
    public class ImpuestoRedondeado
    {
        private double elImpuesto;

        public ImpuestoRedondeado(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            elImpuesto = new Impuesto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual).ComoNumero();            
        }

        public double ConCuatroDecimales()
        {
            return Math.Round(elImpuesto, 4);
        }
    }
}
