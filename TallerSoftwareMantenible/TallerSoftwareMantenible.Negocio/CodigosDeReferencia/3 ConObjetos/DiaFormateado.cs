using System;

namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos
{
    public class DiaFormateado
    {
        private static string elDiaEnTexto;

        public DiaFormateado(DateTime laFecha)
        {
            elDiaEnTexto = new Dia(laFecha).ComoTexto();
        }

        public string ComoTexto()
        {
            return elDiaEnTexto.PadLeft(2, '0');
        }
    }
}
