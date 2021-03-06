﻿namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConPolimorfismo
{
    public class DiaFormateado
    {
        private static string elDiaEnTexto;

        public DiaFormateado(DatosDeReferencia losDatos)
        {
            elDiaEnTexto = new Dia(losDatos).ComoTexto();
        }

        public string ComoTexto()
        {
            return elDiaEnTexto.PadLeft(2, '0');
        }
    }
}
