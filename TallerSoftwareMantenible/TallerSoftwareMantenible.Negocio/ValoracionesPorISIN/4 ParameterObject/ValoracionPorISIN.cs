using System;

namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.ParameterObject
{
    public class ValoracionPorISIN
    {
        private decimal elPorcentajeDeCoberturaRevisado;
        private decimal elValorDeMercado;

        public ValoracionPorISIN(DatosDeValoracion losDatos)
        {
            ISIN = losDatos.ISIN;

            elPorcentajeDeCoberturaRevisado = ObtengaElProcentajeDeCoberturaRevisado(losDatos);
            PorcentajeDeCobertura = elPorcentajeDeCoberturaRevisado;

            elValorDeMercado = ObtengaElValorDeMercado(losDatos);
            ValorDeMercado = elValorDeMercado;

            AporteDeGarantia = CalculeElAporteDeGarantia(elPorcentajeDeCoberturaRevisado, elValorDeMercado);
        }

        public string ISIN { get; set; }
        public decimal ValorDeMercado { get; set; }
        public decimal PorcentajeDeCobertura { get; set; }
        public decimal AporteDeGarantia { get; set; }

        private static decimal ObtengaElProcentajeDeCoberturaRevisado(DatosDeValoracion losDatos)
        {
            return new PorcentajeDeCoberturaRevisado(losDatos).ComoNumero();
        }

        private decimal ObtengaElValorDeMercado(DatosDeValoracion losDatos)
        {
            return new ValorDeMercado(losDatos).ComoNumero();
        }

        private static decimal CalculeElAporteDeGarantia(decimal elPorcentajeDeCoberturaRevisado, decimal elValorDeMercado)
        {
            return elValorDeMercado * elPorcentajeDeCoberturaRevisado;
        }

    }
}