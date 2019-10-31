using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon
{
    public class Paquete
    {
        

        public int idPaquete { get; set; }

        public int numPaquete { get; set; }

        public float peso { get; set; }
        
        public void Calcularpesoporpaquete(TipodeEnvio tipodeEnvio )
        {
            //public float CalcularCostoDeEnvioExpress(Paquete paquete, TipodeEnvio tipodeEnvio)
            //{
            //    float costoExtra = 0;
            //    if (paquete.peso > 2)
            //    {
            //         costoExtra = Math.Abs(2 - paquete.peso) * 20 / 1;
            //    }
            //    return tipoEnvio.costoDeEnvio + costoExtra;
            //}


            //public float CalcularCostoDeEnvioRapido(Paquete paquete, TipodeEnvio tipodeEnvio)
            //{
            //    float costoExtra = 0;
            //    if (paquete.peso > 2)
            //    {
            //        costoExtra = Math.Abs(2 - paquete.peso) * 50 / 1;
            //    }
            //    return tipoEnvio.costoDeEnvio + costoExtra;
            //}


            //public float CalcularCostoDeEnvioEstandar(Paquete paquete, TipodeEnvio tipodeEnvio)
            //{
            //    float costoExtra = 0;
            //    if (paquete.peso > 2)
            //    {
            //        costoExtra = Math.Abs(2 - paquete.peso) * 15 / 1;
            //    }
            //    return tipoEnvio.costoDeEnvio + costoExtra;
            //}
        }
    }
}
