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

        public float CalcularCostoDeEnvioExpress(Paquete paquete, TipodeEnvio tipodeEnvio)
        {
            float costoExtra = 0;
            if (paquete.peso > 2)
            {
                 costoExtra = Math.Abs(2 - paquete.peso) * 20 / 1;
            }
            return tipoEnvio.costoDeEnvio + costoExtra;
        }
        public float CalcularCostoDeEnvioRapido(Paquete paquete, TipodeEnvio tipodeEnvio)
        {
            float costoExtra = 0;
            if (paquete.peso > 2)
            {
                costoExtra = Math.Abs(2 - paquete.peso) * 50 / 1;
            }
            return tipoEnvio.costoDeEnvio + costoExtra;
        }
        public float CalcularCostoDeEnvioEstandar(Paquete paquete, TipodeEnvio tipodeEnvio)
        {
            float costoExtra = 0;
            if (paquete.peso > 2)
            {
                costoExtra = Math.Abs(2 - paquete.peso) * 15 / 1;
            }
            return tipoEnvio.costoDeEnvio + costoExtra;
        }

       
        
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
        }
       



    }
}
