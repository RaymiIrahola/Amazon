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
            envio.fechaLlegada = envio.llegada(envio.TipodeEnvio);

            envio.costodelenvio = envio.CalcularCostoDeEnvio(envio.paquetes , envio.TipodeEnvio);
            
            envios.Insert(envio);

          
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