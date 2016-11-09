namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConParameterObject
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
            // TODO: No cumple ley de Demeter
            return losDatos.CodigoDeCliente.PadLeft(3, '0');
        }

        private string FormateeElCodigoDeSistema(DatosDeReferencia losDatos)
        {
            // TODO: No cumple ley de Demeter
            return losDatos.CodigoDeSistema.PadLeft(2, '0');
        }

        private string FormateeElConsecutivo(DatosDeReferencia losDatos)
        {
            // TODO: No cumple ley de Demeter
            return losDatos.Consecutivo.PadLeft(12, '0');
        }

        public string ComoTexto()
        {
            return $"{laFechaFormateada}{elCodigoDeClienteFormateado}{elCodigoDeSistemaFormateado}{elConsecutivoFormateado}";
        }
    }
}