using System;
namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConObjetos
{
    public class MesFormateado
    {
        private string elMesEnTexto;

        public MesFormateado(DateTime laFecha)
        {
            elMesEnTexto = new Mes(laFecha).ComoTexto();            
        }

        public string ComoTexto()
        {
            return elMesEnTexto.PadLeft(2, '0');
        }
    }
}
