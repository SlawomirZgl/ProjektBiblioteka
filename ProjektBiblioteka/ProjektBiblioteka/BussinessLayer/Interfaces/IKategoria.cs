using ProjektBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.BussinessLayer.Interfaces
{
    interface IKategoria
    {
        Kategoria UpsertCategory(Kategoria category);
        IEnumerable<Kategoria> GetCategories();
        bool DeleteCategory(int categoryId);
        IEnumerable<Ksiazka> GetBooksByCategory(int categoryId);
    }
}
