﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon
{
    public class TipodeEnvio
    {
        public string codigo { get; set; }
        public int costoDeEnvio { get; set; }
        public int duracionDeEnvio { get; set; }
        public int id { get; set; }
        public int numTipodeEnvio { get; set; }

        public float costodepesoextra { get; set; }

        public void verificarcodigot (string codigox)
        {
            if (codigox == "R")
            {
                costoDeEnvio = 1;
                duracionDeEnvio = 3;
                costodepesoextra = 14;
            }
            else
            {
                if (codigox == "E" )
                {
                    costoDeEnvio = 1;
                    duracionDeEnvio = 3;
                    costodepesoextra = 14;
                }
                else
                {
                    if (codigox == "E")
                    {
                        costoDeEnvio = 1;
                        duracionDeEnvio = 3;
                        costodepesoextra = 14;
                    }
                }
            }
        }


        public TipodeEnvio ()
        {
            this.codigo = codigo;
            this.costoDeEnvio = costoDeEnvio;
            this.duracionDeEnvio = duracionDeEnvio;
            this.numTipodeEnvio = numTipodeEnvio;
            this.costodepesoextra = costodepesoextra;
        }
    }
}
