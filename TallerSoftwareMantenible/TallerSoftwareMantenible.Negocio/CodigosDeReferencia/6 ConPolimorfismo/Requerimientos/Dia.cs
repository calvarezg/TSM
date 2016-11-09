namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConPolimorfismo
{
    public class Dia
    {
        private int elDia;

        public Dia(DatosDeReferencia losDatos)
        {
            elDia = losDatos.Dia;
        }        

        public string ComoTexto()
        {
            return elDia.ToString();
        }
    }
}
