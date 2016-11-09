namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos
{
    public class Residuo
    {
        private int laSumaDePesos;

        public Residuo(string elRequerimiento)
        {
            laSumaDePesos = new SumaDePesos(elRequerimiento).ComoNumero();            
        }

        public int ComoNumero()
        {
            return laSumaDePesos % 11;
        }
    }
}
