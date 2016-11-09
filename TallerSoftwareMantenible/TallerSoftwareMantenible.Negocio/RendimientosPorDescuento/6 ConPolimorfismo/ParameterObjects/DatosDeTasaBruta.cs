namespace TallerSoftwareMantenible.Negocio.RendimientosPorDescuento.ConPolimorfismo
{
    public abstract class DatosDeTasaBruta : DatosDeRendimiento
    {
        public double DiasAlVencimiento
        {
            get
            {
                return new PlazoDeVencimiento(this).EnDias();
            }
        }

        public double TasaNeta
        {
            get
            {
                return ((ValorFacial - ValorTransadoNeto) / (ValorTransadoNeto * (DiasAlVencimiento / 365))) * 100;
            }
        }

        public abstract double ValorTransadoBruto { get; }

        public abstract double Impuesto { get; }
    }
}
