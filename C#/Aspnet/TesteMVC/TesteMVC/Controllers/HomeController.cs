using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteMVC.Models;

namespace TesteMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var p = new Produto()
            {
                ProdutoId = 1,
                Preco = 10,
                Nome = "Produto 1"
            };

            return View(p);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Salvar(Usuario usuario)
        {
            return View("Formulario");
        }
    }
}
