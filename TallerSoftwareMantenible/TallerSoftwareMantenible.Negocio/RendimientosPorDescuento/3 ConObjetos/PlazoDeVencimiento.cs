using System;

namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConObjetos
{
    public class PlazoDeVencimiento
    {
        private TimeSpan laDiferenciaDeFechas;

        public PlazoDeVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            laDiferenciaDeFechas = CalculeLaDiferenciaDeFechas(laFechaDeVencimiento, laFechaActual);            
        }

        private static TimeSpan CalculeLaDiferenciaDeFechas(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            return (laFechaDeVencimiento - laFechaActual);
        }

        public int EnDias()
        {
            return laDiferenciaDeFechas.Days;
        }
    }
}
