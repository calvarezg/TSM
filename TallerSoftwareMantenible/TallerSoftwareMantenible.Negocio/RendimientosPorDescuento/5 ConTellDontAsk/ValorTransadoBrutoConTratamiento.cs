using System;

namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConTellDonAsk
{
    public class ValorTransadoBruto
    {
        private double elValorFacial;
        private double laTasaBruta;
        private int losDiasAlVencimiento;

        public ValorTransadoBruto(DatosDeRendimiento losDatos)
        {
            elValorFacial = ObtengaElValorFacial(losDatos);
            losDiasAlVencimiento = new PlazoDeVencimiento(losDatos).EnDias();
            var losDatosDeTasa = new DatosDeTasaBruta
            {
                ValorFacial = losDatos.ValorFacial,
                ValorTransadoNeto = losDatos.ValorTransadoNeto,
                DiasAlVencimiento = losDiasAlVencimiento,
                TasaDeImpuesto = losDatos.TasaDeImpuesto
            };
            laTasaBruta = new TasaBruta(losDatosDeTasa).ComoNumero();            
        }

        private double ObtengaElValorFacial(DatosDeRendimiento losDatos)
        {
            return losDatos.ValorFacial;
        }

        public double ComoNumero()
        {
            return elValorFacial / (1 + ((laTasaBruta / 100.0) * (losDiasAlVencimiento / 365.0)));
        }
    }
}