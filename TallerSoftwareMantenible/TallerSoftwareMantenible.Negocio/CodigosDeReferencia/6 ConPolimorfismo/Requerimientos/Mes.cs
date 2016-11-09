namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConPolimorfismo
{
    public class Mes
    {
        private int elMes;

        public Mes(DatosDeReferencia losDatos)
        {            
            elMes = losDatos.Mes;
        }        

        public string ComoTexto()
        {
            return elMes.ToString();
        }
    }
}
