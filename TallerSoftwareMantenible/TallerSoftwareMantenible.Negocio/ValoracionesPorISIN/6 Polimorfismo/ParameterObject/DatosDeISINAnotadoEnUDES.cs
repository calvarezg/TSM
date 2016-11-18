using System;

namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Polimorfismo
{

    public abstract class DatosDeISINAnotadoEnUDES : DatosDeISINEnUDES
    {
        public override decimal MontoConvertido
        {
            get
            {
                return SaldoColonizado;
            }
        }
        
        public abstract decimal SaldoColonizado { get; }
    }
}
