namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConParameterObject
{
    public class Mes
    {
        private int elMes;

        public Mes(DatosDeReferencia losDatos)
        {
            // TODO: No cumple ley de Demeter
            elMes = losDatos.Fecha.Month;
        }        

        public string ComoTexto()
        {
            return elMes.ToString();
        }
    }
}
