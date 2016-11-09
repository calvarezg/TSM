using System;

namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConFunciones
{
    public static class Calculos
    {
        public static double GenereElRedimientoPorDescuento(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual, bool tieneTratamientoFiscal)
        {
            double elRendimientoPorDescuento = ObtengaElRendimentoPorDescuento(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual, tieneTratamientoFiscal);
            return RedondeeACuatroDecimales(elRendimientoPorDescuento);
        }

        private static double ObtengaElRendimentoPorDescuento(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual, bool tieneTratamientoFiscal)
        {
            double elValorTransadoBruto = ObtengaElValorTransadoBruto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual, tieneTratamientoFiscal);
            return CalculeElRendimientoPorDescuento(elValorFacial, elValorTransadoBruto);
        }

        private static double ObtengaElValorTransadoBruto(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual, bool tieneTratamientoFiscal)
        {
            if (tieneTratamientoFiscal)
                return ObtengaElValorTransadoBrutoCuantoTieneTratamientoFiscal(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual);
            else
                return elValorTransadoNeto;
        }

        private static double ObtengaElValorTransadoBrutoCuantoTieneTratamientoFiscal(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            double losDiasAlVencimiento = CalculeLosDiasAlVencimiento(laFechaDeVencimiento, laFechaActual);
            double laTasaBruta = ObtengaLaTasaBruta(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, losDiasAlVencimiento);

            return CalculeElValorTransadoBrutoCuandoTieneTratamientoFiscal(elValorFacial, losDiasAlVencimiento, laTasaBruta);
        }

        private static double ObtengaLaTasaBruta(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, double losDiasAlVencimiento)
        {
            double laTasaNeta = CalculeLaTasaNeta(elValorFacial, elValorTransadoNeto, losDiasAlVencimiento);
            return CalculeLaTasaBruta(laTasaDeImpuesto, laTasaNeta);            
        }

        private static double CalculeLosDiasAlVencimiento(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            var laDiferenciaDeFechas = ObtengaLaDiferenciaDeFechas(laFechaDeVencimiento, laFechaActual);
            return ObtengaLaDiferenciaEnDias(laDiferenciaDeFechas);
        }

        private static TimeSpan ObtengaLaDiferenciaDeFechas(DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            return (laFechaDeVencimiento - laFechaActual);
        }

        private static double ObtengaLaDiferenciaEnDias(TimeSpan laDiferenciaDeFechas)
        {
            return laDiferenciaDeFechas.Days;
        }

        private static double CalculeLaTasaNeta(double elValorFacial, double elValorTransadoNeto, double losDiasAlVencimiento)
        {
            return ((elValorFacial - elValorTransadoNeto) / (elValorTransadoNeto * (losDiasAlVencimiento / 365))) * 100;
        }

        private static double CalculeLaTasaBruta(double laTasaDeImpuesto, double laTasaNeta)
        {
            return laTasaNeta / (1 - laTasaDeImpuesto);
        }

        private static double CalculeElValorTransadoBrutoCuandoTieneTratamientoFiscal(double elValorFacial, double losDiasAlVencimiento, double laTasaBruta)
        {
            return elValorFacial / (1 + ((laTasaBruta / 100) * (losDiasAlVencimiento / 365)));
        }

        private static double CalculeElRendimientoPorDescuento(double elValorFacial, double elValorTransadoBruto)
        {
            return elValorFacial - elValorTransadoBruto;
        }

        private static double RedondeeACuatroDecimales(double elRendimientoPorDescuento)
        {
            return Math.Round(elRendimientoPorDescuento, 4);
        }
    }
}