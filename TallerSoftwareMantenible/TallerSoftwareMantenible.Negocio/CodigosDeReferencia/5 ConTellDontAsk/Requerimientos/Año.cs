using System;

namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConTellDontAsk
{
    public class Año
    {
        private int elAño;

        public Año(DatosDeReferencia losDatos)
        {
            elAño = losDatos.Año;
        }

        public string ComoTexto()
        {
            return elAño.ToString();
        }
    }
}
