namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConPolimorfismo
{
    public class TasaBruta
    {
        private double laTasaDeImpuesto;
        private double laTasaNeta;

        public TasaBruta(DatosDeTasaBruta losDatos)
        {
            laTasaDeImpuesto = losDatos.TasaDeImpuesto;
            laTasaNeta = losDatos.TasaNeta;
        }

        public double ComoNumero()
        {
            return laTasaNeta / (1 - laTasaDeImpuesto);
        }
    }
}
