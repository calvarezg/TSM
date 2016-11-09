using System;

namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos
{
    public class Dia
    {
        private int elDia;

        public Dia(DateTime laFecha)
        {
            elDia = laFecha.Day;
        }        

        public string ComoTexto()
        {
            return elDia.ToString();
        }
    }
}
