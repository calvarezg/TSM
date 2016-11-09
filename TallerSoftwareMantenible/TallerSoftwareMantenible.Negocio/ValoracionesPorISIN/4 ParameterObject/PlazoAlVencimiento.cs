using System;

namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.ParameterObject
{
    public class PlazoAlVencimiento
    {
        private TimeSpan elPlazoAlVencimiento;

        public PlazoAlVencimiento(DatosDeValoracion losDatos)
        {
            elPlazoAlVencimiento = CalculeElPlazoDeVencimiento(losDatos);
        }

        private static TimeSpan CalculeElPlazoDeVencimiento(DatosDeValoracion losDatos)
        {
            // TODO: mas de una operacion
            return losDatos.FechaDeVencimientoDelValorOficial.Subtract(losDatos.FechaActual);
        }

        public double EnDias()
        {
            return elPlazoAlVencimiento.TotalDays;
        }
    }
}
