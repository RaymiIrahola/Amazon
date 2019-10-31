using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace Amazon
{
    public class UsuarioDestinatario : Usuario
    {
        public List<Envio> ListadePaquetes { get; set; }

        public void recibir (Envio envio)
        {
            ListadePaquetes.Add(envio);
        }
    }
}
