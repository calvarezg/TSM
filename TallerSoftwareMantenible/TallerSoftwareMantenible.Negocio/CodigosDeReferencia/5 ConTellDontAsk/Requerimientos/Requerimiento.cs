namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConTellDontAsk
{
    public class Requerimiento
    {
        private string elCodigoDeClienteFormateado;
        private string elCodigoDeSistemaFormateado;
        private string elConsecutivoFormateado;
        private string laFechaFormateada;

        public Requerimiento(DatosDeReferencia losDatos)
        {
            laFechaFormateada = new FechaFormateada(losDatos).ComoTexto();
            elCodigoDeClienteFormateado = FormateeElCodigoDelCliente(losDatos);
            elCodigoDeSistemaFormateado = FormateeElCodigoDeSistema(losDatos);
            elConsecutivoFormateado = FormateeElConsecutivo(losDatos);            
        }

        private string FormateeElCodigoDelCliente(DatosDeReferencia losDatos)
        {
            return losDatos.CodigoDeClienteFormateado;
        }

        private string FormateeElCodigoDeSistema(DatosDeReferencia losDatos)
        {
            return losDatos.CodigoDeSistemaFormateado;
        }

        private string FormateeElConsecutivo(DatosDeReferencia losDatos)
        {
            return losDatos.ConsecutivoFormateado;
        }

        public string ComoTexto()
        {
            return $"{laFechaFormateada}{elCodigoDeClienteFormateado}{elCodigoDeSistemaFormateado}{elConsecutivoFormateado}";
        }
    }
}