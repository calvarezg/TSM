using System;

namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConTellDonAsk
{
    public class RendimientoPorDescuentoRedondeado
    {
        private double elRendimientoPorDescuento;

        public RendimientoPorDescuentoRedondeado(DatosDeRendimiento losDatos)
        {            
            elRendimientoPorDescuento = new RendimientoPorDescuento(losDatos).ComoNumero();
        }
        
        public double ConCuatroDecimales()
        {
            return Math.Round(elRendimientoPorDescuento, 4);
        }
    }
}