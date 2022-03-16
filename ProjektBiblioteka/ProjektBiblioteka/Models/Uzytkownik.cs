using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Models
{
    public class Uzytkownik
    {
        [Key]
        public int UzytkownikId { get; set; }
        [MaxLength(10)]
        public string Nazwa { get; set; }
        public string Haslo { get; set; }
        public List<Ksiazka> Ksiazki { get; set; }

    }
}
