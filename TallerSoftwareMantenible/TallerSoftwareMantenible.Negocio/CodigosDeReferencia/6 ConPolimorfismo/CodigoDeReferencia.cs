namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConPolimorfismo
{
    public class CodigoDeReferencia
    {
        private int elDigitoVerificador;
        private string elRequerimiento;

        public CodigoDeReferencia(DatosDeReferencia losDatos)
        {
            elRequerimiento = new Requerimiento(losDatos).ComoTexto();
            elDigitoVerificador = new DigitoVerificador(elRequerimiento).ComoNumero();
        }

        public string ComoTexto()
        {
            return $"{elRequerimiento}{elDigitoVerificador}";
        }
    }
}
