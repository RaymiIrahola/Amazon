using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon
{
    public class Paquete: Envio
    {
        public int idPaquete { get; set; }

        public int numPaquete { get; set; }

        public float peso { get; set; }
    }
}
