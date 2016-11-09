using System;

namespace TallerSoftwareMantenible.Negocio.CodigosDeReferencia.ConFunciones
{
    public static class Calculos
    {
        public static string GenereElCodigoDeReferencia(
            DateTime laFecha,
            string elCodigoDeCliente,
            string elCodigoDeSistema,
            string elConsecutivo)
        {
            string elRequerimiento;
            elRequerimiento = ObtengaElRequerimiento(laFecha, elCodigoDeCliente, elCodigoDeSistema, elConsecutivo);

            int elDigitoVerificador;
            elDigitoVerificador = CalculeElDigitoVerificador(elRequerimiento);

            return FormateeElCodigoDeReferencia(elRequerimiento, elDigitoVerificador);
        }

        private static string ObtengaElRequerimiento(DateTime laFecha, string elCodigoDeCliente, string elCodigoDeSistema, string elConsecutivo)
        {
            string laFechaFormateada = ObtengaLaFechaFormateada(laFecha);
            string elCodigoDeClienteFormateado = FormateeElCodigoDelCliente(elCodigoDeCliente);
            string elCodigoDeSistemaFormateado = FormateeElCodigoDeSistema(elCodigoDeSistema);
            string elConsecutivoFormateado = FormateeElConsecutivo(elConsecutivo);

            return FormateeElRequerimiento(laFechaFormateada, elCodigoDeClienteFormateado, elCodigoDeSistemaFormateado, elConsecutivoFormateado);
        }

        private static string ObtengaLaFechaFormateada(DateTime laFecha)
        {
            string elAñoEnTexto = DevuelvaElAñoEnTexto(laFecha);
            string elMesFormateado = ObtengaElMesFormateado(laFecha);
            string elDiaFormateado = DevuelvaElDiaEnTexto(laFecha);
            return FormateeLaFecha(elAñoEnTexto, elMesFormateado, elDiaFormateado);
        }

        private static string DevuelvaElAñoEnTexto(DateTime laFecha)
        {
            int elAño = ObtengaElAño(laFecha);
            return ConviertaElAñoEnTexto(elAño);
        }

        private static int ObtengaElAño(DateTime laFecha)
        {
            return laFecha.Year;
        }

        private static string ConviertaElAñoEnTexto(int elAño)
        {
            return elAño.ToString();
        }

        private static string ObtengaElMesFormateado(DateTime laFecha)
        {
            string elMesEnTexto = ObtengaElMesEnTexto(laFecha);
            return PrecedaConDosCeros(elMesEnTexto);
        }

        private static string ObtengaElMesEnTexto(DateTime laFecha)
        {
            int elMes = ObtengaElMes(laFecha);
            return ConviertaElMesEnTexto(elMes);
        }

        private static int ObtengaElMes(DateTime laFecha)
        {
            return laFecha.Month;
        }

        private static string ConviertaElMesEnTexto(int elMes)
        {
            return elMes.ToString();
        }

        private static string PrecedaConDosCeros(string elMesEnTexto)
        {
            return elMesEnTexto.PadLeft(2, '0');
        }

        private static string DevuelvaElDiaEnTexto(DateTime laFecha)
        {
            string elDiaEnTexto = ObtengaElDiaEnTexto(laFecha);
            return PrecedaElDiaConDosCeros(elDiaEnTexto);
        }

        private static string ObtengaElDiaEnTexto(DateTime laFecha)
        {
            int elDia = ObtengaElDia(laFecha);
            return ConviertaElDiaEnTexto(elDia);
        }

        private static int ObtengaElDia(DateTime laFecha)
        {
            return laFecha.Day;
        }

        private static string ConviertaElDiaEnTexto(int elDia)
        {
            return elDia.ToString();
        }

        private static string PrecedaElDiaConDosCeros(string elDiaEnTexto)
        {
            return elDiaEnTexto.PadLeft(2, '0');
        }

        private static string FormateeLaFecha(string elAñoEnTexto, string elMesFormateado, string elDiaFormateado)
        {
            return $"{elAñoEnTexto}{elMesFormateado}{elDiaFormateado}";
        }

        private static string FormateeElCodigoDelCliente(string elCodigoDeCliente)
        {
            return elCodigoDeCliente.PadLeft(3, '0');
        }

        private static string FormateeElCodigoDeSistema(string elCodigoDeSistema)
        {
            return elCodigoDeSistema.PadLeft(2, '0');
        }

        private static string FormateeElConsecutivo(string elConsecutivo)
        {
            return elConsecutivo.PadLeft(12, '0');
        }

        private static string FormateeElRequerimiento(string laFechaFormateada, string elCodigoDeClienteFormateado, string elCodigoDeSistemaFormateado, string elConsecutivoFormateado)
        {
            return $"{laFechaFormateada}{elCodigoDeClienteFormateado}{elCodigoDeSistemaFormateado}{elConsecutivoFormateado}";
        }

        private static string FormateeElCodigoDeReferencia(string elRequerimiento, int elDigitoVerificador)
        {
            return $"{elRequerimiento}{elDigitoVerificador}";
        }

        public static int CalculeElDigitoVerificador(string elRequerimiento)
        {
            int elResiduo = ObtengaElResiduo(elRequerimiento);
            return CalculeElDigitoVerificadorDeAcuerdoAlResiduo(elResiduo);
        }

        private static int ObtengaElResiduo(string elRequerimiento)
        {
            int laSumaDePesos = ObtengaLaSumaDePesos(elRequerimiento);
            return CalculeElResiduo(laSumaDePesos);
        }

        private static int ObtengaLaSumaDePesos(string elRequerimiento)
        {
            int elLargoDelRequerimiento = CalculeElLargoDelRequerimiento(elRequerimiento);
            return CalculeLaSumaDePesos(elRequerimiento, elLargoDelRequerimiento);
        }

        private static int CalculeLaSumaDePesos(string elRequerimiento, int elLargoDelRequerimiento)
        {
            int laSumaDePesos = 0;
            for (int laPosicionActual = 0; laPosicionActual <= elLargoDelRequerimiento - 1; laPosicionActual++)
            {
                int elPeso = ObtengaElPeso(elRequerimiento, laPosicionActual);
                laSumaDePesos = Sume(laSumaDePesos, elPeso);
            }

            return laSumaDePesos;
        }

        private static int CalculeElLargoDelRequerimiento(string elRequerimiento)
        {
            return elRequerimiento.Length;
        }

        private static int ObtengaElPeso(string elRequerimiento, int laPosicionActual)
        {
            short elDigitoActual = ObtengaElDigitoActual(elRequerimiento, laPosicionActual);
            short elDigitoDePeso = ObtengaElDigitoDePeso(elRequerimiento, laPosicionActual);

            return CalculeElPeso(elDigitoActual, elDigitoDePeso);
        }

        private static short ObtengaElDigitoActual(string elRequerimiento, int laPosicionActual)
        {
            string elCaracterActual = ExtraigaElDigitoActual(elRequerimiento, laPosicionActual);
            return ConviertaElDigitoActualANumero(elCaracterActual);
        }

        private static string ExtraigaElDigitoActual(string elRequerimiento, int laPosicion)
        {
            return elRequerimiento.Substring(laPosicion, 1);
        }

        private static short ConviertaElDigitoActualANumero(string elCaracterActual)
        {
            return short.Parse(elCaracterActual);
        }

        private static short ObtengaElDigitoDePeso(string elRequerimiento, int laPosicionActual)
        {
            string elCaracterDePeso = ObtengaElCaracterDePeso(elRequerimiento, laPosicionActual);
            return ConviertaElDigitoDePesoANumero(elCaracterDePeso);
        }

        private static string ObtengaElCaracterDePeso(string elRequerimiento, int laPosicionActual)
        {
            const string laHileraDePesos = "1234567891234567891234567";
            int laPosicionDelDigitoDePesos = ObtengaLaPosicionDelDigitoDePeso(elRequerimiento, laHileraDePesos, laPosicionActual);
            return ExtraigaElCaracterDePesos(laHileraDePesos, laPosicionDelDigitoDePesos);
        }

        private static int ObtengaLaPosicionDelDigitoDePeso(string elRequerimiento, string laHileraDePesos, int laPosicionActual)
        {
            int elLargoDeLaHileraDePesos = CalculeElLargoDeLaHileraDePesos(laHileraDePesos);
            int elLargoDelRequerimiento = CalculeElLargoDelRequerimiento(elRequerimiento);
            return CalculeLaPosicionDelDigitoDePeso(laPosicionActual, elLargoDeLaHileraDePesos, elLargoDelRequerimiento);
        }

        private static int CalculeElLargoDeLaHileraDePesos(string laHileraDePesos)
        {
            return laHileraDePesos.Length;
        }

        private static int CalculeLaPosicionDelDigitoDePeso(int laPosicionActual, int elLargoDeLaHileraDePesos, int elLargoDelRequerimiento)
        {
            return elLargoDeLaHileraDePesos - elLargoDelRequerimiento + laPosicionActual;
        }

        private static string ExtraigaElCaracterDePesos(string laHileraDePesos, int laPosicion)
        {
            return laHileraDePesos.Substring(laPosicion, 1);
        }

        private static short ConviertaElDigitoDePesoANumero(string elCaracterActual)
        {
            return short.Parse(elCaracterActual);
        }

        private static int CalculeElPeso(short elDigitoActualComoNumero, short elDigitoDePesosComoNumero)
        {
            return elDigitoActualComoNumero * elDigitoDePesosComoNumero;
        }

        private static int Sume(int laSumaDePesos, int elPesoActual)
        {
            return laSumaDePesos + elPesoActual;
        }

        private static int CalculeElResiduo(int laSumaDePesos)
        {
            return laSumaDePesos % 11;
        }

        private static int CalculeElDigitoVerificadorDeAcuerdoAlResiduo(int elResiduo)
        {
            if (elResiduo == 10)
                return 1;
            else
                return elResiduo;
        }
    }
}
