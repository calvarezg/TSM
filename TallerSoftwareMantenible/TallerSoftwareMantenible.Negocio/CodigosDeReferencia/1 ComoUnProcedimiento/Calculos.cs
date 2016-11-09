using System;

namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ComoUnProcedimiento
{
    public static class Calculos
    {
        public static string GenereElCodigoDeReferencia(
            DateTime laFecha,
            string elCodigoDeCliente,
            string elCodigoDeSistema,
            string elConsecutivo)
        {
            int elAño = laFecha.Year;
            string elAñoEnTexto = elAño.ToString();

            int elMes = laFecha.Month;
            string elMesEnTexto = elMes.ToString();
            string elMesFormateado = elMesEnTexto.PadLeft(2, '0');

            int elDia = laFecha.Day;
            string elDiaEnTexto = elDia.ToString();
            string elDiaFormateado = elDiaEnTexto.PadLeft(2, '0');

            string laFechaFormateada = $"{elAñoEnTexto}{elMesFormateado}{elDiaFormateado}";

            string elCodigoDeClienteFormateado = elCodigoDeCliente.PadLeft(3, '0');
            string elCodigoDeSistemaFormateado = elCodigoDeSistema.PadLeft(2, '0');
            string elConsecutivoFormateado = elConsecutivo.PadLeft(12, '0');

            string elRequerimiento = $"{laFechaFormateada}{elCodigoDeClienteFormateado}{elCodigoDeSistemaFormateado}{elConsecutivoFormateado}";
            int elDigitoVerificador = CalculeElDigitoVerificador(elRequerimiento);

            string elCodigoDeReferencia = $"{elRequerimiento}{elDigitoVerificador}";
            return elCodigoDeReferencia;
        }

        public static int CalculeElDigitoVerificador(string elRequerimiento)
        {
            const string laHileraDePesos = "1234567891234567891234567";

            int elLargoDelRequerimiento = elRequerimiento.Length;
            int laSumaDePesos = 0;
            for (int laPosicionActual = 0; laPosicionActual <= elLargoDelRequerimiento - 1; laPosicionActual++)
            {
                string elDigitoActual = elRequerimiento.Substring(laPosicionActual, 1);
                short elDigitoActualComoNumero = short.Parse(elDigitoActual);

                int elLargoDeLaHileraDePesos = laHileraDePesos.Length;                
                int laPosicionDelDigitoDePesos = elLargoDeLaHileraDePesos - elLargoDelRequerimiento + laPosicionActual;
                var elDigitoDePesosComoTexto = laHileraDePesos.Substring(laPosicionDelDigitoDePesos, 1);
                var elDigitoDePesosComoNumero = short.Parse(elDigitoDePesosComoTexto);

                int elPesoActual = elDigitoActualComoNumero * elDigitoDePesosComoNumero;

                laSumaDePesos = laSumaDePesos + elPesoActual;
            }

            int elResiduo = laSumaDePesos % 11;

            int elDigito;
            if (elResiduo == 10)
                elDigito = 1;
            else
                elDigito = elResiduo;

            return elDigito;
        }
    }
}
