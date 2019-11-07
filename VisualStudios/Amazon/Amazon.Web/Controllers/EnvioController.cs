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
            /*
               Retorna la vista con nombre "Agregar" la cual permite la carga de datos de un empleado
            */
            return View("Agregar");
        }

        [HttpPost]
        public IActionResult Agregar(Envio envio)
        {
            var envios = db.Context.GetCollection<Envio>("amazon");

            /*
                Insert: método propio de la biblioteca LiteDB, permite guardar un objeto de tipo Empleado
                en la base de datos
             */
            envios.Insert(envio);

            /*
                Redirecciona la vista "Index" con el contenido de la lista empleados con tipo de datos
                IEnumerable, se usa este método de redireccionamiento en vez de View() para que cambie 
                la refencia en la barra de direcciones
             */
            return RedirectToAction("Index", envios.FindAll());
        }

        public IActionResult Eliminar(int id)
        {
            var envios = db.Context.GetCollection<Envio>("nomina");

            /*
               Delete: método propio de la biblioteca LiteDB, permite eliminar un objeto de tipo Empleado
               en la base de datos, en este caso como se tiene el objeto, pero si el Id y como este es unico
               procedo a borrar todos los objetos que posean el mismo Id.
            */
            envios.Delete(x => x.id == id);

            return RedirectToAction("Index", envios.FindAll());
        }




    }
}