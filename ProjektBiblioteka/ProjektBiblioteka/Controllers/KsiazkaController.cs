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
        public ActionResult Ksiazki(string search)
        {
            var ksiazki = from a in _ksiazka.GetBooks() 
                          select a;
            if (!String.IsNullOrEmpty(search))
            {
                ksiazki = ksiazki.Where(s => s.Nazwa.Contains(search));
            }
            return View(ksiazki);
        }
        public ActionResult Details(int id)
        {
            var ksiazka = _ksiazka.GetBooks().Where(k => k.KsiazkaID == id).FirstOrDefault();

            return View(ksiazka);            
        }
    }
}
