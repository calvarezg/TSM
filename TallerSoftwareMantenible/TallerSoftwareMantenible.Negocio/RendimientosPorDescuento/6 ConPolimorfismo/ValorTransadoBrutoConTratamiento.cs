using System;

namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConPolimorfismo
{
    public class ValorTransadoBruto
    {
        private double elValorFacial;
        private double laTasaBruta;
        private double losDiasAlVencimiento;

        public ValorTransadoBruto(DatosDeTasaBruta losDatos)
        {            
            elValorFacial = losDatos.ValorFacial;
            losDiasAlVencimiento = losDatos.DiasAlVencimiento;            
            laTasaBruta = new TasaBruta(losDatos).ComoNumero();            
        }       

        public double ComoNumero()
        {
            return elValorFacial / (1 + ((laTasaBruta / 100.0) * (losDiasAlVencimiento / 365.0)));
        }
    }
}