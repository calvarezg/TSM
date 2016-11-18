using System;

namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Polimorfismo
{
    public class ValoracionPorISIN
    {
        private string elISIN;
        private decimal elPorcentajeDeCoberturaRevisado;
        private decimal elValorDeMercado;

        public ValoracionPorISIN(DatosDeISIN losDatos)
        {
            elISIN = losDatos.ISIN;
            elPorcentajeDeCoberturaRevisado = ObtengaElProcentajeDeCoberturaRevisado(losDatos);
            elValorDeMercado = ObtengaElValorDeMercado(losDatos);
        }

        public string ISIN
        {
            get
            {
                return elISIN;
            }
        }

        public decimal ValorDeMercado
        {
            get
            {
                return elValorDeMercado;
            }
        }

        public decimal PorcentajeDeCobertura
        {
            get
            {
                return elPorcentajeDeCoberturaRevisado;
            }
        }

        public decimal AporteDeGarantia
        {
            get
            {
                return elValorDeMercado * elPorcentajeDeCoberturaRevisado;
            }
        }

        private static decimal ObtengaElProcentajeDeCoberturaRevisado(DatosDeISIN losDatos)
        {
            return new PorcentajeDeCoberturaRevisado(losDatos).ComoNumero();
        }

        private decimal ObtengaElValorDeMercado(DatosDeISIN losDatos)
        {
            return new ValorDeMercado(losDatos).ComoNumero();
        }
    }
}