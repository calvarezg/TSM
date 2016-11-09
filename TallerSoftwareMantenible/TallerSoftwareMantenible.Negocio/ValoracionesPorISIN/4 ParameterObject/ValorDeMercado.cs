namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.ParameterObject
{
    public class ValorDeMercado
    {
        private decimal elMontoConvertido;
        private decimal elPrecioLimpioDelVectorDePrecios;

        public ValorDeMercado(DatosDeValoracion losDatos)
        {
            elPrecioLimpioDelVectorDePrecios = losDatos.PrecioLimpioDelVectorDePrecios;
            elMontoConvertido = new MontoConvertido(losDatos).ComoNumero();
        }

        public decimal ComoNumero()
        {
            return elMontoConvertido * (elPrecioLimpioDelVectorDePrecios / 100);
        }
    }
}
