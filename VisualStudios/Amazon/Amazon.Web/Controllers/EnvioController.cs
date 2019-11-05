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
        private readonly LiteBDcontex db;
        public EnvioController (LiteBDcontex db)
        {
            this.db = db;
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


    }
}