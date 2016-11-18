namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.Polimorfismo
{

    public class DatosDeISINNoAnotadoEnUDES : DatosDeISINEnUDES
    {
        public override decimal MontoConvertido
        {
            get
            {
                return MontoNominalDelSaldo;
            }
        }
    }
}
