using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConObjetos;
using System;

namespace TallerSoftwareMantenible.Negocio.Impuestos.ConObjetos
{
    public class Impuesto
    {
        private double elValorTransadoBruto;
        private double elValorTransadoNeto;
        
        public Impuesto(double elValorFacial, double elValorTransadoNeto, double laTasaDeImpuesto, DateTime laFechaDeVencimiento, DateTime laFechaActual)
        {
            this.elValorTransadoNeto = elValorTransadoNeto;
            elValorTransadoBruto = new ValorTransadoBruto(elValorFacial, elValorTransadoNeto, laTasaDeImpuesto, laFechaDeVencimiento, laFechaActual).ComoNumero();            
        }

        public double ComoNumero()
        {
            return elValorTransadoNeto - elValorTransadoBruto;
        }
    }
}