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
            return View("Index");
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

            
            envios.Insert(envio);

          
            return RedirectToAction("Index", envios.FindAll());
        }

        public IActionResult Eliminar(int id)
        {
            var envios = db.Context.GetCollection<Envio>("nomina");

           
            envios.Delete(x => x.id == id);

            return RedirectToAction("Index", envios.FindAll());
        }




    }
}