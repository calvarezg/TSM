using System;

namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConParameterObject
{
    public class Año
    {
        private int elAño;

        public Año(DatosDeReferencia losDatos)
        {
            // TODO: no cumple Demeter
            elAño = losDatos.Fecha.Year;
        }

        public string ComoTexto()
        {
            return elAño.ToString();
        }
    }
}
