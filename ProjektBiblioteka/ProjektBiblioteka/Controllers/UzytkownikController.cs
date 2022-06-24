using Microsoft.AspNetCore.Mvc;
using ProjektBiblioteka.BussinessLayer;
using ProjektBiblioteka.BussinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Controllers
{
    public class UzytkownikController : Controller
    {
        IUzytkownik _uzytkownik;

        public UzytkownikController (IUzytkownik uzytkownik)
        {
            _uzytkownik = uzytkownik;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Uzytkownicy()
        {
            var uzytkownicy = from a in _uzytkownik.GetUsers()
                          orderby a.UzytkownikId
                          select a;
            return View(uzytkownicy);
        }
    }
}
