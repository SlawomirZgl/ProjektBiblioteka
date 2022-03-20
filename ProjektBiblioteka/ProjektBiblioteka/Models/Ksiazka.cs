using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Models
{
    public class Ksiazka
    {
        [Key]
        public int KsiazkaID { get; set; }
        [MaxLength(25)]
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public double Ocena { get; set; }
        public List<Autor> Autorzy { get; set; }
        public List<Kategoria> Kategorie { get; set; }
        public int Ilosc { get; set; }


    }
}
