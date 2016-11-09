using System;

namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConPolimorfismo
{
    public class DatosDeRendimiento
    {
        public double ValorFacial { get; set; }
        public double ValorTransadoNeto { get; set; }
        public double TasaDeImpuesto { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public DateTime FechaActual { get; set; }        
        public TimeSpan DiferenciaDeFechas
        {
            get
            {
                return FechaDeVencimiento - FechaActual;
            }
        }
    }
}
