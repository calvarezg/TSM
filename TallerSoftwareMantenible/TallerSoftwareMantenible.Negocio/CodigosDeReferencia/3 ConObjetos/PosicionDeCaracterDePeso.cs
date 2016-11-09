namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos
{
    public class PosicionDeCaracterDePeso
    {
        private int laPosicionActual;
        private int elLargoDeLaHileraDePesos;
        private int elLargoDelRequerimiento;

        public PosicionDeCaracterDePeso(string elRequerimiento, string laHileraDePesos, int laPosicionActual)
        {
            this.laPosicionActual = laPosicionActual;
            elLargoDeLaHileraDePesos = elRequerimiento.Length;
            elLargoDelRequerimiento = laHileraDePesos.Length;
        }

        public int ComoNumero()
        {
            return elLargoDeLaHileraDePesos - elLargoDelRequerimiento + laPosicionActual;
        }
    }
}
