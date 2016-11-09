namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConTellDontAsk
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
