using System;

namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.TellDontAsk
{
    public class ValorDeMercado
    {
        private decimal elMontoConvertido;
        private decimal elPrecioLimpioDelVectorDePrecios;

        public ValorDeMercado(DatosDeValoracion losDatos)
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
