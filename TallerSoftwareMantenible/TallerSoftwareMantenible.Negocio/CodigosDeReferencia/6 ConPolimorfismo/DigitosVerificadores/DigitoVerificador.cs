namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConPolimorfismo
{
    public class DigitoVerificador
    {
        private int elResiduo;

        public DigitoVerificador(string elRequerimiento)
        {
            elResiduo = new Residuo(elRequerimiento).ComoNumero();            
        }

        public int ComoNumero()
        {
            if (elResiduo == 10)
                return 1;
            else
                return elResiduo;
        }
    }
}
