using System;

namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConObjetos
{
    public class ValorTransadoBruto
    {
        private double elValorFacial;
        private double laTasaBruta;
        private double losDiasAlVencimiento;

        public ValorTransadoBruto(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            this.elValorFacial = elValorFacial;
            losDiasAlVencimiento = new PlazoDeVencimiento(laFechaDeVencimiento, laFechaActual).EnDias();
            laTasaBruta = new TasaBruta(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, losDiasAlVencimiento).ComoNumero();            
        }

        public double ComoNumero()
        {
            return elValorFacial / (1 + ((laTasaBruta / 100.0) * (losDiasAlVencimiento / 365.0)));
        }
    }
}