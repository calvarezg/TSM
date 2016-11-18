
using System;

namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Polimorfismo
{
    public abstract class DatosDeISIN
    {
        public string ISIN;
        public DateTime FechaActual;
        public DateTime FechaDeVencimientoDelValorOficial;
        public int DiasMinimosAlVencimientoDelEmisor;
        public decimal PorcentajeCobertura;
        public decimal PrecioLimpioDelVectorDePrecios;
        public decimal MontoNominalDelSaldo;

        public abstract Monedas TipoDeMoneda { get; }

        public TimeSpan PlazoDeVencimiento
        {
            get
            {
                return FechaDeVencimientoDelValorOficial.Subtract(FechaActual);
            }
        }

        public abstract decimal MontoConvertido { get; }
    }
}
