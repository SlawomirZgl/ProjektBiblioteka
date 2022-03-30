using ProjektBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Repositories
{
    public class AutorRepo : IAutorRepo
    {
        DbBiblioteka _database;

        public AutorRepo(DbBiblioteka database)
        {
            _database = database;
        }

        public void AddAuthor(Autor autor)
        {
            _database.Autorzy.Add(autor);
        }

        public void AddBookToAuthor(Ksiazka ksiazka, int id)
        {
            _database.Autorzy.Where(a => a.AutorId == id).FirstOrDefault().Ksiazki.Add(ksiazka);
        }

        public bool DeleteAuthor(int id)
        {
            bool result = false;
            Autor a = GetAuthor(id);
            if (a != null)
            {
                _database.Autorzy.Remove(a);
                result = true;
            }
            return result;
            
            
        }

        public Autor GetAuthor(int id)
        {
           Autor a = _database.Autorzy.Where(a => a.AutorId == id).FirstOrDefault();
            return a;
        }

        public IEnumerable<Autor> GetAuthors()
        {
            return _database.Autorzy;
        }

        public IEnumerable<Ksiazka> GetBooksofAuthor(int id)
        {
            return GetAuthor(id).Ksiazki;
        }
    }
}
