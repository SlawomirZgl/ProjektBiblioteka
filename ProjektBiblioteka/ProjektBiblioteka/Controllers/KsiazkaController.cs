using Microsoft.AspNetCore.Mvc;
using ProjektBiblioteka.BussinessLayer;
using ProjektBiblioteka.BussinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Controllers
{
    public class KsiazkaController : Controller
    {
        IKsiazka _ksiazka;

        public KsiazkaController (IKsiazka ksiazka)
        {
            _ksiazka = ksiazka;   
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Ksiazki()
        {
            var ksiazki = from a in _ksiazka.GetBooks()
                          orderby a.KsiazkaID
                          select a;
            return View(ksiazki);
        }

    }
}
