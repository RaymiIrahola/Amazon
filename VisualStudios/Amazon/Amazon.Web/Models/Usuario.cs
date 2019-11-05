using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Web.Models
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public int idUsuario { get; set; }
        public int numCliente { get; set; }
        public int numTarjeta { get; set; }
        public int telefono { get; set; }
    }
}
