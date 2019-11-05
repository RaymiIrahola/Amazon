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

        public Paquete paquetes { get; set; }

        public UsuarioRemitente remitente { get; set; }

        public TipodeEnvio tipoEnvio { get; set; }


       
        public void Enviar (UsuarioDestinatario usuarioDestinatario, UsuarioRemitente usuarioRemitente, TipodeEnvio tipodeEnvio , Paquete paquete)
        {
            this.remitente = usuarioRemitente;
            this.destinatario = usuarioDestinatario;
            this.tipoEnvio = tipodeEnvio;
            this.fechaEnvio = DateTime.Now;
            this.fechaLlegada = fechaEnvio.AddDays(tipodeEnvio.duracionDeEnvio);
            this.direccionDeDestino = direccionDeDestino;
            this.numEnvio = numEnvio;
            this.paquetes = paquete;
            usuarioDestinatario.recibir(this);
        }
        public float CalcularCostoDeEnvioExpress(Paquete paquete, TipodeEnvio tipodeEnvio)
        {
            float costext = 0;
            if (paquete.peso > 2)
            {
                costext = Math.Abs(2 - paquete.peso) * tipodeEnvio.costoExtra / 1;
            }
            return tipoEnvio.costoDeEnvio + costext;
        }




    }
}
