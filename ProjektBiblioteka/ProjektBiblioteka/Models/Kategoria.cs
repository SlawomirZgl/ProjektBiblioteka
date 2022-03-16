using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Models
{
    public class Kategoria
    {
        [Key]
        public int KategoriaId { get; set; }
        [MaxLength(25)]
        public string Nazwa { get; set; }

    }
}
