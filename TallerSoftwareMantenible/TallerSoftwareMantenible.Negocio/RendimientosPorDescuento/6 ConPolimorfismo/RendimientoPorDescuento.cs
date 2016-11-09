namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConPolimorfismo
{
    public class RendimientoPorDescuento
    {
        private double elValorFacial;
        private double elValorTransadoBruto;

        public RendimientoPorDescuento(DatosDeTasaBruta losDatos)
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