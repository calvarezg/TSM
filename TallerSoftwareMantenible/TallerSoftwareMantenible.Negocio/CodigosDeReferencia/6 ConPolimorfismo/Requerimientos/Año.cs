using System;

namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConPolimorfismo
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
