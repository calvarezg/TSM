using System;

namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.ParameterObject
{
    public class SaldoColonizado
    {
        private bool hayTipoDeCambioParaHoy;
        private decimal elSaldoColinizadoConTipoDeCambioDeHoy;
        private decimal elSaldoColinizadoConTipoDeCambioDeAyer;

        public SaldoColonizado(DatosDeValoracion losDatos)
        {
            hayTipoDeCambioParaHoy = HayTipoDeCambioParaHoy(losDatos);
            elSaldoColinizadoConTipoDeCambioDeHoy = CalculeElSaldoColonizadoConTipoCambioDeHoy(losDatos);
            elSaldoColinizadoConTipoDeCambioDeAyer = CalculeElSaldoColonizadoConTipoCambioDeAyer(losDatos);
        }

        private decimal CalculeElSaldoColonizadoConTipoCambioDeHoy(DatosDeValoracion losDatos)
        {
            // TODO: mas de una op
            return losDatos.MontoNominalDelSaldo * losDatos.TipoDeCambioUDESDeHoy;
        }

        private decimal CalculeElSaldoColonizadoConTipoCambioDeAyer(DatosDeValoracion losDatos)
        {
            // TODO: mas de una op
            return losDatos.MontoNominalDelSaldo * losDatos.TipoDeCambioUDESDeAyer;
        }

        private bool HayTipoDeCambioParaHoy(DatosDeValoracion losDatos)
        {
            // TODO: mas de una op
            return losDatos.TipoDeCambioUDESDeHoy > 0;
        }     

        public decimal ComoNumero()
        {
            if (hayTipoDeCambioParaHoy)
                return elSaldoColinizadoConTipoDeCambioDeHoy;
            else

                return elSaldoColinizadoConTipoDeCambioDeAyer;
        }
    }
}
