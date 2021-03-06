﻿namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConPolimorfismo
{
    public class MesFormateado
    {
        private string elMesEnTexto;

        public MesFormateado(DatosDeReferencia losDatos)
        {
            elMesEnTexto = new Mes(losDatos).ComoTexto();            
        }

        public string ComoTexto()
        {
            return elMesEnTexto.PadLeft(2, '0');
        }
    }
}
