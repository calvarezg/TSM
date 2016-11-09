using System;

namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ComoUnProcedimiento
{
    public static class Calculos
    {
        public static double GenereElRedimientoPorDescuento(
            double elValorFacial,
            double elValorTransadoNeto, 
            double laTasaDeImpuesto, 
            DateTime laFechaDeVencimiento, 
            DateTime laFechaActual, 
            bool tieneTratamientoFiscal)
        {            
            double elValorTransadoBruto;
            if (tieneTratamientoFiscal)
            {   
                double losDiasAlVencimiento;
                losDiasAlVencimiento = (laFechaDeVencimiento - laFechaActual).Days;

                double laTasaNeta;
                laTasaNeta = ((elValorFacial - elValorTransadoNeto) / (elValorTransadoNeto * (losDiasAlVencimiento / 365))) *100;

                double laTasaBruta;
                laTasaBruta = laTasaNeta / (1 - laTasaDeImpuesto);
                                
                elValorTransadoBruto = elValorFacial / (1 + ((laTasaBruta / 100) * (losDiasAlVencimiento / 365)));
            }
            else
            {
                elValorTransadoBruto = elValorTransadoNeto;                
            }

            double elRendimientoPorDescuento;
            elRendimientoPorDescuento = elValorFacial - elValorTransadoBruto;

            double elRendimientoRedondeado;
            elRendimientoRedondeado = Math.Round(elRendimientoPorDescuento, 4);
            
            return elRendimientoRedondeado;
        }
    }
}
