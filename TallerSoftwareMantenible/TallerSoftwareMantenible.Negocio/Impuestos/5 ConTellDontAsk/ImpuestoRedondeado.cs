using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConTellDonAsk;
using System;

namespace TallerSoftwareMantenible.Negocio.Impuestos.ConTellDontAsk
{
    public class ImpuestoRedondeado
    {
        private double elImpuesto;

        public ImpuestoRedondeado(DatosDeRendimiento losDatos)
        {
            elImpuesto = new Impuesto(losDatos).ComoNumero();
        }

        public double ConCuatroDecimales()
        {
            return Math.Round(elImpuesto, 4);
        }
    }
}
