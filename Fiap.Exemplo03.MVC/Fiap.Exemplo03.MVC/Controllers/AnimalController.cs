using Fiap.Exemplo03.MVC.Models;
using Fiap.Exemplo03.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo03.MVC.Controllers
{
    public class AnimalController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Animal animal)
        {
            var context = new ZooContext();
            context.Animais.Add(animal);
            context.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var context = new ZooContext();
            List<Animal> animais = context.Animais.ToList();
            return View(animais);
        }

    }
}