using ProjektBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Repositories
{
    public class KategoriaRepo : IKategoriaRepo
    {
        DbBiblioteka _database;

        public KategoriaRepo(DbBiblioteka database)
        {
            _database = database;
        }

        public void AddCategory(Kategoria kategoria)
        {
            _database.Kategorie.Add(kategoria);
        }

        public bool DeleteCategory(int id)
        {
            bool result = false; 
            Kategoria k = GetCategory(id); 
            if(k != null )
            {
                _database.Kategorie.Remove(k);
                result = true;
            }
            return result;
                 
        }

        public IEnumerable<Ksiazka> GetBooksOfCategory(int id)
        {
            return GetCategory(id).Ksiazki;
        }

        public IEnumerable<Kategoria> GetCategories()
        {
            return _database.Kategorie;
        }

        public Kategoria GetCategory(int id)
        {
            return _database.Kategorie.Where(k => k.KategoriaId == id).FirstOrDefault();
        }
    }
}
