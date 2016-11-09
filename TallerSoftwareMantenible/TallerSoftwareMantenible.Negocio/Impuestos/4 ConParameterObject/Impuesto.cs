using TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConParameterObject;
using System;

namespace TallerSoftwareMantenible.Negocio.Impuestos.ConParameterObject
{
    public class Impuesto
    {
        private double elValorTransadoBruto;
        private double elValorTransadoNeto;

        public Impuesto(DatosDeRendimiento losDatos)
        {
            elValorTransadoNeto = losDatos.ValorTransadoNeto;
            elValorTransadoBruto = new ValorTransadoBruto(losDatos).ComoNumero();            
        }

        public double ComoNumero()
        {
            return elValorTransadoNeto - elValorTransadoBruto;
        }
    }
}