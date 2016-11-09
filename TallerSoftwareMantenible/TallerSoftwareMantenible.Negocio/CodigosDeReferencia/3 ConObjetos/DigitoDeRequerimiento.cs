namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos
{
    public class DigitoDeRequerimiento
    {
        private string elCaracterActual;

        public DigitoDeRequerimiento(string elRequerimiento, int laPosicion)
        {
            elCaracterActual = elRequerimiento.Substring(laPosicion, 1);
        }
        
        public short ComoNumero()
        {
            return short.Parse(elCaracterActual);
        }
    }
}
