namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConParameterObject
{
    public class Dia
    {
        private int elDia;

        public Dia(DatosDeReferencia losDatos)
        {
            // TODO: No cumple ley de Demeter
            elDia = losDatos.Fecha.Day;
        }        

        public string ComoTexto()
        {
            return elDia.ToString();
        }
    }
}
