using System;

namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Objetos
{
    public class PorcentajeDeCoberturaRevisado
    {
        private double losDiasAlVencimiento;
        private int losDiasMinimosAlVencimientoDelEmisor;
        private decimal elPorcentajeCobertura;

        public PorcentajeDeCoberturaRevisado(DateTime laFechaActual, DateTime laFechaDeVencimientoDelValorOficial, int losDiasMinimosAlVencimientoDelEmisor, decimal elPorcentajeCobertura)
        {
            this.losDiasMinimosAlVencimientoDelEmisor = losDiasMinimosAlVencimientoDelEmisor;
            this.elPorcentajeCobertura = elPorcentajeCobertura;
            losDiasAlVencimiento = new PlazoAlVencimiento(laFechaActual, laFechaDeVencimientoDelValorOficial).EnDias();
        }

        private bool LosDiasAlVencimientoSonMenosQueLosPermitidos()
        {
            return losDiasAlVencimiento < losDiasMinimosAlVencimientoDelEmisor;
        }

        public decimal ComoNumero()
        {
            if (LosDiasAlVencimientoSonMenosQueLosPermitidos())
                return 0;
            else
                return elPorcentajeCobertura;
        }
    }
}
