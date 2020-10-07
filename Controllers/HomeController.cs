using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Solicitacao_de_orcamento.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Solucoes()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contatos()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}