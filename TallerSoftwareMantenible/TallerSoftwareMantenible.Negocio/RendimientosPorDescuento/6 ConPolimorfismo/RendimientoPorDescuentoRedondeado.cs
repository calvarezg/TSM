using System;

namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConPolimorfismo
{
    public class RendimientoPorDescuentoRedondeado
    {
        private double elRendimientoPorDescuento;

        public RendimientoPorDescuentoRedondeado(DatosDeTasaBruta losDatos)
        {            
            elRendimientoPorDescuento = new RendimientoPorDescuento(losDatos).ComoNumero();
        }
        
        public double ConCuatroDecimales()
        {
            return Math.Round(elRendimientoPorDescuento, 4);
        }
    }
}