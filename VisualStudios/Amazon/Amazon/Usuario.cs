using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon
{
    public class Usuario
    {
        
        public string nombre { get; set; }
        public  string apellido { get; set; }
        public string direccion { get; set; }
        public int id { get; set; }
        public int numCliente { get; set; }
        public int numTarjeta { get; set; }
        public int telefono { get; set; }

        public Usuario ()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.numCliente = numCliente;
            this.numTarjeta = numTarjeta;
            this.telefono = telefono;
        }
        


    }
}
