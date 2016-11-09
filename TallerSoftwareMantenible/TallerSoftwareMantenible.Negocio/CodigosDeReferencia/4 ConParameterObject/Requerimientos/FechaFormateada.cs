namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConParameterObject
{
    public class FechaFormateada
    {
        private string elAñoEnTexto;
        private string elDiaFormateado;
        private string elMesFormateado;
        
        public FechaFormateada(DatosDeReferencia losDatos)
        {
            elAñoEnTexto = new Año(losDatos).ComoTexto();
            elMesFormateado = new MesFormateado(losDatos).ComoTexto();
            elDiaFormateado = new DiaFormateado(losDatos).ComoTexto();            
        }

        public string ComoTexto()
        {
            return $"{elAñoEnTexto}{elMesFormateado}{elDiaFormateado}";
        }
    }
}