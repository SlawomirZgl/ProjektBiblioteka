using Microsoft.AspNetCore.Mvc;
using ProjektBiblioteka.BussinessLayer;
using ProjektBiblioteka.BussinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Controllers
{
    public class KategoriaController : Controller
    {
        IKategoria _kategoria;

        public KategoriaController(IKategoria kategoria)
        {
            _kategoria = kategoria;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Kategorie()
        {
            var kategorie = from a in _kategoria.GetCategories()
                          orderby a.KategoriaId
                          select a;
            return View(kategorie);
        }
    }
}
