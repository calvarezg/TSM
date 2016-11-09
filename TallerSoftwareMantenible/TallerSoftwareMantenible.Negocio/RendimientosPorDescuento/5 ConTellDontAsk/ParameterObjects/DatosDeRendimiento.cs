using TallerSoftwareMantenible.Negocio.Impuestos.ConTellDontAsk;
using System;

namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConTellDonAsk
{
    public class DatosDeRendimiento
    {
        public double ValorFacial { get; set; }
        public double ValorTransadoNeto { get; set; }
        public double TasaDeImpuesto { get; set; }
        public DateTime FechaDeVencimiento { get; set; }
        public DateTime FechaActual { get; set; }
        public bool TieneTratamientoFiscal { get; set; }
        public double ValorTransadoBruto
        {
            get
            {
                if (TieneTratamientoFiscal)
                    return new ValorTransadoBruto(this).ComoNumero();
                else
                    return ValorTransadoNeto;
            }
        }
        public double Impuesto
        {
            get
            {
                if (TieneTratamientoFiscal)
                {
                    return new ImpuestoRedondeado(this).ConCuatroDecimales();
                }
                else
                {
                    return 0;
                }
            }
        }

        public TimeSpan DiferenciaDeFechas
        {
            get
            {
                return FechaDeVencimiento - FechaActual;
            }
        }
    }
}
