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
        private readonly LiteBDcontex db;
        public UsuarioController (LiteBDcontex db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}