namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConTellDonAsk
{
    public class DatosDeTasaBruta
    {
        public double ValorFacial { get; set; }
        public double ValorTransadoNeto { get; set; }
        public double TasaDeImpuesto { get; set; }
        public double DiasAlVencimiento { get; set; }
        public double TasaNeta
        {
            get
            {
                return ((ValorFacial - ValorTransadoNeto) / (ValorTransadoNeto * (DiasAlVencimiento / 365))) * 100;
            }
        }
    }
}
