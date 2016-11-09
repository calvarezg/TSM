using TallerSoftwareMantenible.Negocio.Impuestos.ConPolimorfismo;

namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConPolimorfismo
{
    public class DatosDeTasaBrutaConTratamiento : DatosDeTasaBruta
    {
        public override double ValorTransadoBruto
        {
            get
            {
                return new ValorTransadoBruto(this).ComoNumero();
            }            
        }

        public override double Impuesto
        {
            get
            {
                return new ImpuestoRedondeado(this).ConCuatroDecimales();                
            }
        }
    }
}