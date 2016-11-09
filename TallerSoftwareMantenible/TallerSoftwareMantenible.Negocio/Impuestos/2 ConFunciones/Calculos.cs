using System;

namespace TallerSoftwareMantenible.Negocio.Impuestos.ConFunciones
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
            if (tieneTratamientoFiscal)
            {
                return ObtengaElImpuestoConTratamientoFiscal(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual);
            }
            else
            {
                return 0;
            }
        }

        private static double ObtengaElImpuestoConTratamientoFiscal(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            double elImpuesto = ObtengaElImpuesto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual);
            return RedondeeACuatroDecimales(elImpuesto);
        }

        private static double ObtengaElImpuesto(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            double elValorTransadoBruto = ObtengaElValorTransadoBruto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual);
            return CalculeElImpuesto(elValorTransadoNeto, elValorTransadoBruto);
        }

        private static double ObtengaElValorTransadoBruto(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            double losDiasAlVencimiento = ObtengaLosDiasAlVencimiento(laFechaDeVencimiento, laFechaActual);
            double laTasaBruta = ObtengaLaTasaBruta(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, losDiasAlVencimiento);

            return CalculeElValorTransadoBruto(elValorFacial, losDiasAlVencimiento, laTasaBruta);
        }

        private static double ObtengaLosDiasAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            var laDiferenciaDeFechas = CalculeLaDiferenciaDeFechas(laFechaDeVencimiento, laFechaActual);
            return ObtengaLaCantidadDeDias(laDiferenciaDeFechas);
        }

        private static TimeSpan CalculeLaDiferenciaDeFechas(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            return (laFechaDeVencimiento - laFechaActual);
        }

        private static double ObtengaLaCantidadDeDias(TimeSpan laDiferenciaDeFechas)
        {
            return laDiferenciaDeFechas.Days;
        }

        private static double ObtengaLaTasaBruta(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, double losDiasAlVencimiento)
        {
            double laTasaNeta = CalculeLaTasaNeta(elValorFacial, elValorTransadoNeto, losDiasAlVencimiento);
            return CalculeLaTasaBruta(laTasaDeImpuesto, laTasaNeta);
        }

        private static double CalculeLaTasaNeta(double elValorFacial, double elValorTransadoNeto, double losDiasAlVencimiento)
        {
            return ((elValorFacial - elValorTransadoNeto) / (elValorTransadoNeto * (losDiasAlVencimiento / 365))) * 100;
        }

        private static double CalculeLaTasaBruta(double laTasaDeImpuesto, double laTasaNeta)
        {
            return laTasaNeta / (1 - laTasaDeImpuesto);
        }

        private static double CalculeElValorTransadoBruto(double elValorFacial, double losDiasAlVencimiento, double laTasaBruta)
        {
            return elValorFacial / (1 + ((laTasaBruta / 100.0) * (losDiasAlVencimiento / 365.0)));
        }

        private static double CalculeElImpuesto(double elValorTransadoNeto, double elValorTransadoBruto)
        {
            return elValorTransadoNeto - elValorTransadoBruto;
        }

        private static double RedondeeACuatroDecimales(double elImpuesto)
        {
            return Math.Round(elImpuesto, 4);
        }
    }
}
