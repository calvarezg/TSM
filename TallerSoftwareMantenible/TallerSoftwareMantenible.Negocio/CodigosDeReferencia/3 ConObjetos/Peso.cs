namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos
{
    public class Peso
    {
        private short elDigitoActual;
        private short elDigitoDePeso;

        public Peso(string elRequerimiento, int laPosicion)
        {
            elDigitoActual = new DigitoDeRequerimiento(elRequerimiento, laPosicion).ComoNumero();
            elDigitoDePeso = new DigitoDePeso(elRequerimiento, laPosicion).ComoNumero();            
        }

        public int ComoNumero()
        {
            return elDigitoActual * elDigitoDePeso;
        }
    }
}
