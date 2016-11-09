namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConPolimorfismo
{
    public class DatosDeTasaBrutaSinTratamiento : DatosDeTasaBruta
    {
        public override double ValorTransadoBruto
        {
            get
            {
                return ValorTransadoNeto;
            }
        }

        public override double Impuesto
        {
            get
            {
                return 0;
            }
        }
    }
}
