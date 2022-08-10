using Microsoft.AspNetCore.Mvc;
using ProjektBiblioteka.BussinessLayer;
using ProjektBiblioteka.BussinessLayer.Interfaces;
using ProjektBiblioteka.Models;
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
        [HttpGet]
        public ActionResult GetListOfBooks()
        {
            var ksiazki = from a in _ksiazka.GetBooks()
                          orderby a.KsiazkaID
                          select a;
            ViewBag.ksiazki = ksiazki;
            return View();
        }
        public ActionResult Details(int id)
        {
            var ksiazka = _ksiazka.GetBooks().Where(k => k.KsiazkaID == id).FirstOrDefault();

            return View(ksiazka);            
        }
    }
}
