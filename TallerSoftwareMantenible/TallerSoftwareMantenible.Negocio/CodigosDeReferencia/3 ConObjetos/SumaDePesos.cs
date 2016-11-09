namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos
{
    public static class SumadorDePesos
    {
        public static int Calcule(string elRequerimiento, int elLargoDelRequerimiento)
        {
            int laSumaDePesos = 0;
            for (int laPosicionActual = 0; laPosicionActual <= elLargoDelRequerimiento - 1; laPosicionActual++)
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
