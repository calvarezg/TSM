using System;

namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos
{
    public class Mes
    {
        private int elMes;

        public Mes(DateTime laFecha)
        {
            elMes = laFecha.Month;
        }        

        public string ComoTexto()
        {
            return elMes.ToString();
        }
    }
}
