﻿namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConTellDontAsk
{
    public class DigitoDePeso
    {
        private string elCaracterDePeso;

        public DigitoDePeso(string elRequerimiento, int laPosicionActual)
        {
            elCaracterDePeso = new CaracterDePeso(elRequerimiento, laPosicionActual).ComoCaracter();            
        }

        public short ComoNumero()
        {
            return short.Parse(elCaracterDePeso);
        }
    }
}