﻿using System;

namespace TallerSoftwareMantenible.Negocio.ValoracionesPorISIN.ParameterObject
{
    public class PorcentajeDeCoberturaRevisado
    {
        private double losDiasAlVencimiento;
        private int losDiasMinimosAlVencimientoDelEmisor;
        private decimal elPorcentajeCobertura;

        public PorcentajeDeCoberturaRevisado(DatosDeValoracion losDatos)
        {
            // TODO: Mas de una operacion
            losDiasMinimosAlVencimientoDelEmisor = losDatos.DiasMinimosAlVencimientoDelEmisor;
            elPorcentajeCobertura = losDatos.PorcentajeCobertura;
            losDiasAlVencimiento = new PlazoAlVencimiento(losDatos).EnDias();
        }

        private bool LosDiasAlVencimientoSonMenosQueLosPermitidos()
        {
            return losDiasAlVencimiento < losDiasMinimosAlVencimientoDelEmisor;
        }

        public decimal ComoNumero()
        {
            if (LosDiasAlVencimientoSonMenosQueLosPermitidos())
                return 0;
            else
                return elPorcentajeCobertura;
        }
    }
}
