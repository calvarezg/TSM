using System;

namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Objetos
{
    public class PlazoAlVencimiento
    {
        private TimeSpan elPlazoAlVencimiento;

        public PlazoAlVencimiento(DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial)
        {
            elPlazoAlVencimiento = CalculeElPlazoDeVencimiento(laFechaActual, laFechaDeVencimientoDelValorOficial);
        }

        private static TimeSpan CalculeElPlazoDeVencimiento(DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial)
        {
            return laFechaDeVencimientoDelValorOficial.Subtract(laFechaActual);
        }

        public double EnDias()
        {
            return elPlazoAlVencimiento.TotalDays;
        }
    }
}
