using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Web.Models
{
    public class TipodeEnvio
    {
        public string codigo { get; set; }
        public int costoDeEnvio { get; set; }
        public int duracionDeEnvio { get; set; }
        public int id { get; set; }
        public int numTipodeEnvio { get; set; }
    }
}
