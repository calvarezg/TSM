using System;

namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Polimorfismo
{
    public class ValorDeMercado
    {
        private decimal elMontoConvertido;
        private decimal elPrecioLimpioDelVectorDePrecios;

        public ValorDeMercado(DatosDeISIN losDatos)
        {
            elPrecioLimpioDelVectorDePrecios = losDatos.PrecioLimpioDelVectorDePrecios;
            elMontoConvertido = losDatos.MontoConvertido;
        }
        
        public decimal ComoNumero()
        {
            return elMontoConvertido * (elPrecioLimpioDelVectorDePrecios / 100);
        }
    }
}
