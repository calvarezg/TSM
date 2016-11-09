using System;

namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConParameterObject
{
    public class PlazoDeVencimiento
    {
        private TimeSpan laDiferenciaDeFechas;

        public PlazoDeVencimiento(DatosDeRendimiento losDatos)
        {
            // TODO: mas de una operacion
            laDiferenciaDeFechas = losDatos.FechaDeVencimiento - losDatos.FechaActual;
        }
        

        public int EnDias()
        {
            return laDiferenciaDeFechas.Days;
        }
    }
}
