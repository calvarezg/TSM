using System;

namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConPolimorfismo
{
    public class DatosDeReferencia
    {
        public DateTime Fecha { get; set; }
        public string CodigoDeCliente { get; set; }
        public string CodigoDeSistema { get; set; }
        public string Consecutivo { get; set; }

        public string CodigoDeClienteFormateado
        {
            get
            {
                return CodigoDeCliente.PadLeft(3, '0');
            }
        }

        public string CodigoDeSistemaFormateado
        {
            get
            {
                return CodigoDeSistema.PadLeft(2, '0');
            }
        }

        public string ConsecutivoFormateado
        {
            get
            {
                return Consecutivo.PadLeft(12, '0');
            }
        }

        public int Año
        {
            get
            {
                return Fecha.Year;
            }
        }

        public int Dia
        {
            get
            {
                return Fecha.Day;
            }
        }

        public int Mes
        {
            get
            {
                return Fecha.Month;
            }
        }
    }
}