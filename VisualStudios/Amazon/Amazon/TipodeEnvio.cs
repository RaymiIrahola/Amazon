using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon
{
    public class TipodeEnvio
    {
        public string codigo { get; set; }
        public int costoDeEnvio { get; set; }
        public int duracionDeEnvio { get; set; }
        public int id { get; set; }
        public int numTipodeEnvio { get; set; }

        public TipodeEnvio ()
        {
            this.codigo = codigo;
            this.costoDeEnvio = costoDeEnvio;
            this.duracionDeEnvio = duracionDeEnvio;
            this.numTipodeEnvio = numTipodeEnvio;
        }
    }
}
