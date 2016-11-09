using System;

namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos
{
    public class FechaFormateada
    {
        private string elAñoEnTexto;
        private string elDiaFormateado;
        private string elMesFormateado;
        
        public FechaFormateada(DateTime laFecha)
        {
            elAñoEnTexto = new Año(laFecha).ComoTexto();
            elMesFormateado = new MesFormateado(laFecha).ComoTexto();
            elDiaFormateado = new DiaFormateado(laFecha).ComoTexto();            
        }

        public string ComoTexto()
        {
            return $"{elAñoEnTexto}{elMesFormateado}{elDiaFormateado}";
        }
    }
}