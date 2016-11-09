using System;

namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConTellDonAsk
{
    public class PlazoDeVencimiento
    {
        private TimeSpan laDiferenciaDeFechas;

        public PlazoDeVencimiento(DatosDeRendimiento losDatos)
        {
            laDiferenciaDeFechas = losDatos.DiferenciaDeFechas;
        }
        
        public int EnDias()
        {
            return laDiferenciaDeFechas.Days;
        }
    }
}
