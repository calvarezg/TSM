using System;

namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConParameterObject
{
    public class DatosDeReferencia
    {
        public DateTime Fecha { get; set; }
        public string CodigoDeCliente { get; set; }
        public string CodigoDeSistema { get; set; }
        public string Consecutivo { get; set; }
    }
}