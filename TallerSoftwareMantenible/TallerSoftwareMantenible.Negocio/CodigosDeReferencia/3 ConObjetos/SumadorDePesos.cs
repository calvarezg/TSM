namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos
{
    public class SumaDePesos
    {
        private int elLargoDelRequerimiento;
        private string elRequerimiento;

        public SumaDePesos(string elRequerimiento)
        {
            this.elRequerimiento = elRequerimiento;
            elLargoDelRequerimiento = elRequerimiento.Length;            
        }

        public int ComoNumero()
        {
            return SumadorDePesos.Calcule(elRequerimiento, elLargoDelRequerimiento);
        }       
    }
}