using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConParameterObject;
using System;

namespace TallerSoftwareMantenible.Negocio.Impuestos.ConParameterObject
{
    public class Calculos
    {
        public static double GenereElImpuesto(DatosDeRendimiento losDatos)
        {
            // TODO: Arreglar
            if (losDatos.TieneTratamientoFiscal)
            {
                return new ImpuestoRedondeado(losDatos).ConCuatroDecimales();
            }
            else
            {
                return 0;
            }
        }
    }
}
