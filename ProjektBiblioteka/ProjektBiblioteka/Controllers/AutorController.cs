using Microsoft.AspNetCore.Mvc;
using ProjektBiblioteka.BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Controllers
{
    public class AutorController : Controller
    {

        BLAutor BLautorzy;
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Autorzy()
        {
            var autorzy = from a in BLautorzy.GetAuthors()
                          orderby a.AutorId
                          select a; 
            return View(autorzy);
        }
    }
}
