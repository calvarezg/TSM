namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConObjetos
{
    public class TasaBruta
    {
        private double laTasaDeImpuesto;
        private double laTasaNeta;

        public TasaBruta(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, double losDiasAlVencimiento)
        {
            this.laTasaDeImpuesto = laTasaDeImpuesto;
            laTasaNeta = CalculeLaTasaNeta(elValorFacial, elValorTransadoNeto, losDiasAlVencimiento);            
        }

        private static double CalculeLaTasaNeta(double elValorFacial, double elValorTransadoNeto, double losDiasAlVencimiento)
        {
            return ((elValorFacial - elValorTransadoNeto) / (elValorTransadoNeto * (losDiasAlVencimiento / 365))) * 100;
        }

        public double ComoNumero()
        {
            return laTasaNeta / (1 - laTasaDeImpuesto);
        }
    }
}
