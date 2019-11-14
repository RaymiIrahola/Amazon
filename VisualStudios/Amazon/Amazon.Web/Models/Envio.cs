using System;
using System.Collections.Generic;
using System.Text;
namespace Amazon.Web.Models
{
    public class Envio
    {
        public Usuario remitente { get; set; }

        public string direccionDeDestino { get; set; }

        public DateTime fechaEnvio { get; set; }

        public DateTime fechaLlegada { get; set; }

        public int id { get; set; }

        public int numEnvio { get; set; }

        public Paquete paquetes { get; set; }

        public Usuario destinatario { get; set; }

        public TipodeEnvio tipodeEnvio { get; set; }

        
    }
}
