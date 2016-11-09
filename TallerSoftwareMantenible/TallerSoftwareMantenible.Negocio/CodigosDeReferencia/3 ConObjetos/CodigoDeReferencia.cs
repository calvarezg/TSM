using System;

namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos
{
    public class CodigoDeReferencia
    {
        private int elDigitoVerificador;
        private string elRequerimiento;

        public CodigoDeReferencia(
            DateTime laFecha,
            string elCodigoDeCliente,
            string elCodigoDeSistema,
            string elConsecutivo)
        {
            elRequerimiento = new Requerimiento(laFecha, elCodigoDeCliente, elCodigoDeSistema, elConsecutivo).ComoTexto();
            elDigitoVerificador = new DigitoVerificador(elRequerimiento).ComoNumero();            
        }
        
        public string ComoTexto()
        {
            return $"{elRequerimiento}{elDigitoVerificador}";
        }
    }
}
