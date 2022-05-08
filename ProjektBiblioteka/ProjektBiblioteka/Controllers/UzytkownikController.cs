using Microsoft.AspNetCore.Mvc;
using ProjektBiblioteka.BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Controllers
{
    public class UzytkownikController : Controller
    {
        BLUzytkownik bLUzytkownik;
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Uzytkownicy()
        {
            var uzytkownicy = from a in bLUzytkownik.GetUsers()
                          orderby a.UzytkownikId
                          select a;
            return View(uzytkownicy);
        }
    }
}
