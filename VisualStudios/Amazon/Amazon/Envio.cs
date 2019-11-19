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

      


       
        public void Enviar ()
        {
            this.remitente = new Usuario();
            this.destinatario = new Usuario();
            this.fechaEnvio = DateTime.Now;
            this.fechaLlegada = fechaLlegada;
            this.direccionDeDestino = String.Empty;
            this.numEnvio = 0;
            this.paquetes = new Paquete();
            this.TipodeEnvio = new TipodeEnvio();
            
        }
        public double CalcularCostoDeEnvio(Paquete paquete , TipodeEnvio tipodeEnvio)
        {
            double costext = 0;
            if (paquete.peso > 2)
            {
                costext = tipodeEnvio.costoDeEnvio +  Math.Abs(2 - paquete.peso) * tipodeEnvio.costodepesoextra / 1;
            }
            return costext;
        }

        public DateTime llegada ( TipodeEnvio tipodeEnvio)
        {
            DateTime l;
            l=  fechaEnvio.AddDays(tipodeEnvio.duracionDeEnvio);
            return l;
        }

    }
}
