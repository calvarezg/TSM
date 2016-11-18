
using System;

namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Polimorfismo
{
    public abstract class DatosDeISINEnUDES : DatosDeISIN
    {
        public override Monedas TipoDeMoneda
        {
            get
            {
                return Monedas.UDES;
            }
        }
    }
}
