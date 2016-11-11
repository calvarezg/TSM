using System;

namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.TellDontAsk
{
    public class DatosDeValoracion
    {
        public string ISIN;
        public DateTime FechaActual;
        public DateTime FechaDeVencimientoDelValorOficial;
        public int DiasMinimosAlVencimientoDelEmisor;
        public decimal PorcentajeCobertura;
        public decimal PrecioLimpioDelVectorDePrecios;
        public Monedas TipoDeMoneda;
        public bool SaldoEstaAnotadoEnCuenta;
        public decimal MontoNominalDelSaldo;
        public decimal TipoDeCambioUDESDeHoy;
        public decimal TipoDeCambioUDESDeAyer;

        public bool SaldoEstaAnotadoEnUDES
        {
            get
            {
                return EstaEnUDES && SaldoEstaAnotadoEnCuenta;
            }
        }

        public bool EstaEnUDES
        {
            get
            {
                return TipoDeMoneda == Monedas.UDES;
            }
        }

        public TimeSpan PlazoDeVencimiento
        {
            get
            {
                return FechaDeVencimientoDelValorOficial.Subtract(FechaActual);
            }
        }

        public decimal SaldoColonizadoConTipoDeCambioDeHoy
        {
            get
            {
                return MontoNominalDelSaldo * TipoDeCambioUDESDeHoy;
            }
        }

        public decimal SaldoColonizadoConTipoDeCambioDeAyer
        {
            get
            { return MontoNominalDelSaldo * TipoDeCambioUDESDeAyer; }
        }

        public bool TieneTipoDeCambioParaHoy
        {
            get

            {
                return TipoDeCambioUDESDeHoy > 0;
            }
        }

        public decimal MontoConvertido
        {
            get
            {
                if (SaldoEstaAnotadoEnUDES)
                    return SaldoColonizado;
                else
                    return MontoNominalDelSaldo;
            }
        }

        public decimal SaldoColonizado
        {
            get
            {
                if (TieneTipoDeCambioParaHoy)
                    return SaldoColonizadoConTipoDeCambioDeHoy;
                else
                    return SaldoColonizadoConTipoDeCambioDeAyer;
            }
        }
    }
}
