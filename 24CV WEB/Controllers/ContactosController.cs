﻿using _24CV_WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace _24CV_WEB.Controllers
{
    public class ContactosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            Persona persona = new Persona();
            persona.Nombre = "Sandoval";
            persona.Apellido = "Sandoval";
            persona.FechaNacimiento = DateTime.Now;
            return View(persona);
        }
    }
}
