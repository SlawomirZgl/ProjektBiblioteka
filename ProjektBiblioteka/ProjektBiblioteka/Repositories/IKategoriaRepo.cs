using ProjektBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Repositories
{
    public interface IKategoriaRepo
    {
        void AddCategory(Kategoria kategoria);
        IEnumerable<Kategoria> GetCategories();
        bool DeleteCategory(int id);
        Kategoria GetCategory(int id);
        IEnumerable<Ksiazka> GetBooksOfCategory(int id);

    }
}
