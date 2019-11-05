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
        public byte duracionDeEnvio { get; set; }
        public int idTipodeEnvio { get; set; }
        public int numTipodeEnvio { get; set; }
        public byte costoExtra { get; set; }
    }
}
