namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConTellDontAsk
{
    public class PosicionDeCaracterDePeso
    {
        private int laPosicion;

        public PosicionDeCaracterDePeso(string elRequerimiento, string laHileraDePesos, int laPosicionActual)
        {
            int elLargoDeLaHileraDePesos = CalculeElLargoDeLaHileraDePesos(laHileraDePesos);
            int elLargoDelRequerimiento = CalculeElLargoDelRequerimiento(elRequerimiento);
            laPosicion = CalculeLaPosicionDelDigitoDePeso(laPosicionActual, elLargoDeLaHileraDePesos, elLargoDelRequerimiento);
        }

        private int CalculeElLargoDelRequerimiento(string elRequerimiento)
        {
            return elRequerimiento.Length;
        }

        private static int CalculeElLargoDeLaHileraDePesos(string laHileraDePesos)
        {
            return laHileraDePesos.Length;
        }

        private int CalculeLaPosicionDelDigitoDePeso(int laPosicionActual, int elLargoDeLaHileraDePesos, int elLargoDelRequerimiento)
        {
            return elLargoDeLaHileraDePesos - elLargoDelRequerimiento + laPosicionActual;
        }

        public int ComoNumero()
        {
            return laPosicion;
        }
    }
}
