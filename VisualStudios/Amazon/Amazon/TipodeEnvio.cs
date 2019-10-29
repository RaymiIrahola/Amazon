using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon
{
    public class TipodeEnvio
    {
        public string codigo { get; set; }
        public int costoDeEnvio { get; set; }
        public DateTime duracionDeEnvio { get; set; }
        public int idTipodeEnvio { get; set; }
        public int numTipodeEnvio { get; set; }

        public DateTime calcularfechadellegada(Envio envio)
        {
            TimeSpan fehca = duracionDeEnvio(dtpDesde.Value);
        }
    }
}
