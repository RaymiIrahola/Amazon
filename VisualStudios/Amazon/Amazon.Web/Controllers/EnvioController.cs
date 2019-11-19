using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LiteDB;
using Amazon.Web.Models;

namespace Amazon.Web.Controllers
{
    public class EnvioController : Controller
    {
        private readonly LiteBDcontext db;
        public EnvioController (LiteBDcontext db)
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var eenvios = db.Context.GetCollection<Envio>("amazon");
           
            ViewBag.CantidadUsuarios = eenvios.Count();
           
            return View("Index", eenvios.FindAll());
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            
            return View("Agregar");
        }

        [HttpPost]
        public IActionResult Agregar(Envio envio)
        {            
            var envios = db.Context.GetCollection<Envio>("amazon");

            var usuarios = db.Context.GetCollection<Usuario>("usuarios");

            //var Envio = envios.FindAll().FirstOrDefault();
            //Envio.
            Envio nuevoenvio = new Envio();
            var tipoenvio = new TipodeEnvio ();
            var paquetel = new Paquete();

            paquetel.peso = envio.paquetes.peso;
            paquetel.numPaquete = envio.paquetes.numPaquete;
            tipoenvio.codigo = envio.TipodeEnvio.codigo;


            tipoenvio.verificarcodigot(envio.TipodeEnvio.codigo);

            nuevoenvio.fechaEnvio = DateTime.Now;            

            nuevoenvio.destinatario = usuarios.FindAll().FirstOrDefault(x => x.numCliente == envio.destinatario.numCliente);

            nuevoenvio.remitente = usuarios.FindAll().FirstOrDefault(x => x.numCliente == envio.remitente.numCliente);

            nuevoenvio.direccionDeDestino = nuevoenvio.direccionDeDestino;

            nuevoenvio.numEnvio = envio.numEnvio;

            nuevoenvio.paquetes = paquetel;

            nuevoenvio.TipodeEnvio = tipoenvio;

            nuevoenvio.costodelenvio = nuevoenvio.CalcularCostoDeEnvio(paquetel, tipoenvio);

            nuevoenvio.fechaLlegada = nuevoenvio.llegada(tipoenvio);


           

            envios.Insert(nuevoenvio);

          
            return RedirectToAction("Index", envios.FindAll());
        }

        public IActionResult Eliminar(int id)
        {
            var envios = db.Context.GetCollection<Envio>("amazon");

           
            envios.Delete(x => x.id == id);

            return RedirectToAction("Index", envios.FindAll());
        }

       
        






    }
}