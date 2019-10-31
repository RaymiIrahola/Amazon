
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

//Using esenciales


namespace Amazon
{
    public class UsuarioRemitente : Usuario
    {
        public List<Envio> ListadeEnvios { get; set; }
        public void Realizarenvio(Envio envio, UsuarioDestinatario usuarioDestinatario, UsuarioRemitente usuarioRemitente,Paquete paquete , TipodeEnvio tipodeEnvio)
        {
            ListadeEnvios.Add(envio);
            envio.Enviar(usuarioDestinatario, usuarioRemitente  , tipodeEnvio, paquete);
        }

    }
}
