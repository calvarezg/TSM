using System;

namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Polimorfismo
{
    public class PlazoAlVencimiento
    {
        private TimeSpan elPlazoAlVencimiento;

        public PlazoAlVencimiento(DatosDeISIN losDatos)
        {
            elPlazoAlVencimiento = losDatos.PlazoDeVencimiento;
        }
        
        public double EnDias()
        {
            return elPlazoAlVencimiento.TotalDays;
        }
    }
}
