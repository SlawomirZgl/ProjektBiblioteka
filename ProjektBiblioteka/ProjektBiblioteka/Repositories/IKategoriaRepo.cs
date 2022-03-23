using ProjektBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Repositories
{
    interface IKategoriaRepo
    {
        void AddCategory(Kategoria kategoria);
        IEnumerable<Kategoria> GetCategories();
        bool DeleteCategory(int id);
        Autor GetCategory(int id);
        
    }
}
