
namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Polimorfismo
{
    public class PorcentajeDeCoberturaRevisado
    {
        private double losDiasAlVencimiento;
        private int losDiasMinimosAlVencimientoDelEmisor;
        private decimal elPorcentajeCobertura;

        public PorcentajeDeCoberturaRevisado(DatosDeISIN losDatos)
        {
            losDiasMinimosAlVencimientoDelEmisor = losDatos.DiasMinimosAlVencimientoDelEmisor;
            elPorcentajeCobertura = losDatos.PorcentajeCobertura;
            losDiasAlVencimiento = new PlazoAlVencimiento(losDatos).EnDias();
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
