using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConPolimorfismo;
using System;

namespace TallerSoftwareMantenible.Negocio.Impuestos.ConPolimorfismo
{
    public class ImpuestoRedondeado
    {
        private double elImpuesto;

        public ImpuestoRedondeado(DatosDeTasaBruta losDatos)
        {
            elImpuesto = new Impuesto(losDatos).ComoNumero();
        }

        public double ConCuatroDecimales()
        {
            return Math.Round(elImpuesto, 4);
        }
    }
}
