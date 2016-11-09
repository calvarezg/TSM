using System;

namespace TallerSoftwareMantenible.Negocio.Impuestos.ConObjetos
{
    public class Calculos
    {
        public static double GenereElImpuesto(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual, bool tieneTratamientoFiscal)
        {
            if (tieneTratamientoFiscal)
            {
                return new ImpuestoRedondeado(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual).ConCuatroDecimales();
            }
            else
            {
                return 0;
            }
        }
    }
}
