using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon
{
    public class Paquete: Envio
    {
        public Paquete(UsuarioDestinatario usuarioDestinatario, UsuarioRemitente usuarioRemitente, TipodeEnvio tipodeEnvioa) : base(usuarioDestinatario, usuarioRemitente, tipodeEnvioa)
        {
        }

        public int idPaquete { get; set; }

        public int numPaquete { get; set; }

        public float peso { get; set; }
    }
}
