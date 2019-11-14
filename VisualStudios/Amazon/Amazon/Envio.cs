using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Amazon
{
    public class Envio
    {
        public Usuario destinatario { get; set; }

        public string direccionDeDestino { get; set; }

        public  DateTime fechaEnvio { get; set; }

        public DateTime fechaLlegada { get; set; }

        public int id { get; set; }

        public int numEnvio { get; set; }

        public Paquete paquetes { get; set; }

        public Usuario remitente { get; set; }

        public TipodeEnvio TipodeEnvio { get; set; }

        public double costodelenvio { get; set; }

      


       
        public void Enviar (Usuario usuarioDestinatario, Usuario usuarioRemitente, Paquete paquete, TipodeEnvio tipodeEnvio)
        {
            this.remitente = usuarioRemitente;
            this.destinatario = usuarioDestinatario;
            this.fechaEnvio = DateTime.Now;
            this.fechaLlegada = fechaEnvio.AddDays(TipodeEnvio.duracionDeEnvio);
            this.direccionDeDestino = direccionDeDestino;
            this.numEnvio = numEnvio;
            this.paquetes = paquete;
            this.TipodeEnvio = TipodeEnvio;
            this.costodelenvio = costodelenvio;
            
        }
        public double CalcularCostoDeEnvio(Paquete paquete , TipodeEnvio tipodeEnvio)
        {
            double costext = 0;
            if (paquete.peso > 2)
            {
                costext = Math.Abs(2 - paquete.peso) * tipodeEnvio.costodepesoextra / 1;
            }
            return costext;
        }

    }
}
