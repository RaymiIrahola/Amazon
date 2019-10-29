using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon
{
    public class Envio
    {
        public UsuarioDestinatario destinatario { get; set; }

        public string direccionDeDestino { get; set; }

        public  DateTime fechaEnvio { get; set; }

        public DateTime fechaLlegada { get; set; }

        public int idEnvio { get; set; }

        public int numEnvio { get; set; }

        public Paquete paquete { get; set; }

        public UsuarioRemitente remitente { get; set; }

        public TipodeEnvio tipoEnvio { get; set; }

        public float CalcularEnvioDePeso(Paquete paquete)
        {

        }

        public Envio(UsuarioDestinatario usuarioDestinatario, UsuarioRemitente usuarioRemitente, TipodeEnvio tipodeEnvioa)
        {
            remitente = usuarioRemitente;
            destinatario = usuarioDestinatario;
            tipoEnvio = tipodeEnvioa;
            fechaEnvio = DateTime.Now;
            fechaLlegada = tipoEnvio.calcularfechadellegada;
            direccionDeDestino = direccionDeDestino;
            numEnvio = numEnvio;
        }



    }
}
