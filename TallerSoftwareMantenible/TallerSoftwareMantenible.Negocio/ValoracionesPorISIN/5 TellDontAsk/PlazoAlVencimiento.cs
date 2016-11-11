using System;

namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.TellDontAsk
{
    public class PlazoAlVencimiento
    {
        private TimeSpan elPlazoAlVencimiento;

        public PlazoAlVencimiento(DatosDeValoracion losDatos)
        {
            elPlazoAlVencimiento = losDatos.PlazoDeVencimiento;
        }
        
        public double EnDias()
        {
            return elPlazoAlVencimiento.TotalDays;
        }
    }
}
