using System;

namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos
{
    public class Año
    {
        private int elAño;

        public Año(DateTime laFecha)
        {
            elAño = laFecha.Year;
        }        

        public string ComoTexto()
        {
            return elAño.ToString();
        }
    }
}
