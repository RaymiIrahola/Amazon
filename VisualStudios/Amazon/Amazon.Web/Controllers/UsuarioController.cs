﻿using System;
using System.Collections.Generic;
using LiteDB;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Amazon.Web.Models;


namespace Amazon.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly LiteBDcontext db;
        public UsuarioController(LiteBDcontext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var usuarios = db.Context.GetCollection<Usuario>("usuarios");

            ViewBag.cantidaddeusuarios = usuarios.Count();

            return View("Index", usuarios.FindAll());
        }

        [HttpGet]
        public IActionResult Agregar()
        {

            return View("Agregar");
        }

        [HttpPost]
        public IActionResult Agregar(Usuario usuario)
        {
            var usuarios = db.Context.GetCollection<Usuario>("usuarios");


            usuarios.Insert(usuario);


            return RedirectToAction("Index", usuarios.FindAll());
        }

        public IActionResult Eliminar(int id)
        {
            var usuarios = db.Context.GetCollection<Usuario>("usuarios");


            usuarios.Delete(x => x.id == id);

            return RedirectToAction("Index", usuarios.FindAll());
        }
    }
}