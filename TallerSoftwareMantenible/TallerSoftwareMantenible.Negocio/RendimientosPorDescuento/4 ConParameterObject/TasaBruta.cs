namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConParameterObject
{
    public class TasaBruta
    {
        private double laTasaDeImpuesto;
        private double laTasaNeta;

        public TasaBruta(DatosDeTasaBruta losDatos)
        {
            laTasaDeImpuesto = losDatos.TasaDeImpuesto;
            laTasaNeta = CalculeLaTasaNeta(losDatos);
        }

        private static double CalculeLaTasaNeta(DatosDeTasaBruta losDatos)
        {
            // TODO: Arreglar
            return ((losDatos.ValorFacial - losDatos.ValorTransadoNeto) / (losDatos.ValorTransadoNeto * (losDatos.DiasAlVencimiento / 365))) * 100;
        }

        public double ComoNumero()
        {
            return laTasaNeta / (1 - laTasaDeImpuesto);
        }
    }
}
