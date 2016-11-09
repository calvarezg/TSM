namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConPolimorfismo
{
    public static class SumadorDePesos
    {
        public static int Calcule(string elRequerimiento, int elLargoDelRequerimiento)
        {
            int laSumaDePesos = 0;
            for (int laPosicionActual = 0; laPosicionActual <= elLargoDelRequerimiento; laPosicionActual++)
            {
                int elPeso = new Peso(elRequerimiento, laPosicionActual).ComoNumero();
                laSumaDePesos = Sume(laSumaDePesos, elPeso);
            }
            return laSumaDePesos;          
        }

        private static int Sume(int laSumaDePesos, int elPesoActual)
        {
            return laSumaDePesos + elPesoActual;
        }
    }
}
