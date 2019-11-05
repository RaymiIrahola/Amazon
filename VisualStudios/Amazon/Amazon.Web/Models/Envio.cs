using System;
using System.Collections.Generic;
using System.Text;
namespace Amazon.Web.Models
{
    public class Envio
    {
        public UsuarioDestinatario destinatario { get; set; }

        public string direccionDeDestino { get; set; }

        public DateTime fechaEnvio { get; set; }

        public DateTime fechaLlegada { get; set; }

        public int idEnvio { get; set; }

        public int numEnvio { get; set; }

        public Paquete paquetes { get; set; }

        public UsuarioRemitente remitente { get; set; }

        public TipodeEnvio tipoEnvio { get; set; }
    }
}
