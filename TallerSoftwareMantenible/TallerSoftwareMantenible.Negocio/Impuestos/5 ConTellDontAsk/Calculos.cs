using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConTellDonAsk;
using System;

namespace TallerSoftwareMantenible.Negocio.Impuestos.ConTellDontAsk
{
    public class Calculos
    {
        public static double GenereElImpuesto(DatosDeRendimiento losDatos)
        {
            return losDatos.Impuesto;
        }
    }
}
