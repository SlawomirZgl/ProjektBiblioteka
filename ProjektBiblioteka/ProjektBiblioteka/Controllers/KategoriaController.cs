using Microsoft.AspNetCore.Mvc;
using ProjektBiblioteka.BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Controllers
{
    public class KategoriaController : Controller
    {
        BLKategoria bLKategoria;
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Kategorie()
        {
            var kategorie = from a in bLKategoria.GetCategories()
                          orderby a.KategoriaId
                          select a;
            return View(kategorie);
        }
    }
}
