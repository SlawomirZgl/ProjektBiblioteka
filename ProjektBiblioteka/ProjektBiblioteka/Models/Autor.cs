using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Models
{
    public class Autor
    {
        [Key]
        public int AutorId { get; set; }
        [MaxLength(25)]
        [RegularExpression("^[A-Z][a-z]+$", ErrorMessage = "Zly format")]
        public string Imie { get; set; }
        [MaxLength(25)]
        [RegularExpression("^[A-Z][a-z]+$", ErrorMessage = "Zly format")]
        public string Nazwisko { get; set; }
        public List<Ksiazka> Ksiazki { get; set; }
    }
}
