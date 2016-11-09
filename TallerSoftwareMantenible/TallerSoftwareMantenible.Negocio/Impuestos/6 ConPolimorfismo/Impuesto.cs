using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConPolimorfismo;

namespace TallerSoftwareMantenible.Negocio.Impuestos.ConPolimorfismo
{
    public class Impuesto
    {
        private double elValorTransadoBruto;
        private double elValorTransadoNeto;

        public Impuesto(DatosDeTasaBruta losDatos)
        {
            elValorTransadoNeto = losDatos.ValorTransadoNeto;
            elValorTransadoBruto = new ValorTransadoBruto(losDatos).ComoNumero();            
        }

        public double ComoNumero()
        {
            return elValorTransadoNeto - elValorTransadoBruto;
        }
    }
}