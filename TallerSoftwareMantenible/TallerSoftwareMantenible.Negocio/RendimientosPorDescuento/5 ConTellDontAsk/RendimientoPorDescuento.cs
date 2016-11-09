namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConTellDonAsk
{
    public class RendimientoPorDescuento
    {
        private double elValorFacial;
        private double elValorTransadoBruto;

        public RendimientoPorDescuento(DatosDeRendimiento losDatos)
        {
            elValorFacial = losDatos.ValorFacial;
            elValorTransadoBruto = losDatos.ValorTransadoBruto;
        }

        public double ComoNumero()
        {
            return elValorFacial - elValorTransadoBruto;
        }
    }
}