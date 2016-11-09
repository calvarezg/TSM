using System;

namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.ParameterObject
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
    }
}
