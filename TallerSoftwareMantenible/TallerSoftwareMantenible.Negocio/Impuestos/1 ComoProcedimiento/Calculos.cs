using System;

namespace TallerSoftwareMantenible.Negocio.Impuestos.ComoProcedimiento
{
    public class Calculos
    {
        public static double GenereElImpuesto(
            double elValorFacial,
            double elValorTransadoNeto,
            double laTasaDeImpuesto,
            DateTime laFechaDeVencimiento,
            DateTime laFechaActual,
            bool tieneTratamientoFiscal)
        {
            double elImpuestoRedondeado;

            if (tieneTratamientoFiscal)
            {
                var laDiferenciaDeFechas = (laFechaDeVencimiento - laFechaActual);
                double losDiasAlVencimiento = laDiferenciaDeFechas.Days;

                double laTasaNeta;
                laTasaNeta = ((elValorFacial - elValorTransadoNeto) / (elValorTransadoNeto * (losDiasAlVencimiento / 365))) * 100;

                double laTasaBruta;
                laTasaBruta = laTasaNeta / (1 - laTasaDeImpuesto);

                double elValorTransadoBruto =
                elValorTransadoBruto = elValorFacial / (1 + ((laTasaBruta/ 100) *(losDiasAlVencimiento / 365)));

                double elImpuesto = elValorTransadoNeto - elValorTransadoBruto;
                elImpuestoRedondeado = Math.Round(elImpuesto, 4);
            }
            else
            {
                elImpuestoRedondeado = 0;
            }            

            return elImpuestoRedondeado;
        }
    }
}
