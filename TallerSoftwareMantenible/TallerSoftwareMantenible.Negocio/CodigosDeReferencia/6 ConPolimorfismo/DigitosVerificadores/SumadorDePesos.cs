namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConPolimorfismo
{
    public class SumaDePesos
    {
        private int elLargoDelRequerimiento;
        private string elRequerimiento;

        public SumaDePesos(string elRequerimiento)
        {
            this.elRequerimiento = elRequerimiento;
            elLargoDelRequerimiento = elRequerimiento.Length - 1;            
        }

        public int ComoNumero()
        {
            return SumadorDePesos.Calcule(elRequerimiento, elLargoDelRequerimiento);
        }       
    }
}