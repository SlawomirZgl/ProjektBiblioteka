using Microsoft.AspNetCore.Mvc;
using ProjektBiblioteka.BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Controllers
{
    public class KsiazkaController : Controller
    {
        BLKsiazka BLksiazka;
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Ksiazki()
        {
            var ksiazki = from a in BLksiazka.GetBooks()
                          orderby a.KsiazkaID
                          select a;
            return View(ksiazki);
        }

    }
}
