namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConParameterObject
{
    public class CaracterDePeso
    {
        const string laHileraDePesos = "1234567891234567891234567";
        private int laPosicionDelDigitoDePesos;

        public CaracterDePeso(string elRequerimiento, int laPosicionActual)
        {
            laPosicionDelDigitoDePesos = new PosicionDeCaracterDePeso(elRequerimiento, laHileraDePesos, laPosicionActual).ComoNumero();
        }

        public string ComoCaracter()
        {
            return laHileraDePesos.Substring(laPosicionDelDigitoDePesos, 1);
        }
    }
}
