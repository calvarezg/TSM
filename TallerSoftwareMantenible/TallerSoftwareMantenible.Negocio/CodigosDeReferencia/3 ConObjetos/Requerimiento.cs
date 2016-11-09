using System;

namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos
{
    public class Requerimiento
    {
        private string elCodigoDeClienteFormateado;
        private string elCodigoDeSistemaFormateado;
        private string elConsecutivoFormateado;
        private string laFechaFormateada;

        public Requerimiento(DateTime laFecha, string elCodigoDeCliente, string elCodigoDeSistema, string elConsecutivo)
        {
            laFechaFormateada = new FechaFormateada(laFecha).ComoTexto();
            elCodigoDeClienteFormateado = FormateeElCodigoDelCliente(elCodigoDeCliente);
            elCodigoDeSistemaFormateado = FormateeElCodigoDeSistema(elCodigoDeSistema);
            elConsecutivoFormateado = FormateeElConsecutivo(elConsecutivo);            
        }

        private string FormateeElCodigoDelCliente(string elCodigoDeCliente)
        {
            return elCodigoDeCliente.PadLeft(3, '0');
        }

        private string FormateeElCodigoDeSistema(string elCodigoDeSistema)
        {
            return elCodigoDeSistema.PadLeft(2, '0');
        }

        private string FormateeElConsecutivo(string elConsecutivo)
        {
            return elConsecutivo.PadLeft(12, '0');
        }

        public string ComoTexto()
        {
            return $"{laFechaFormateada}{elCodigoDeClienteFormateado}{elCodigoDeSistemaFormateado}{elConsecutivoFormateado}";
        }
    }
}