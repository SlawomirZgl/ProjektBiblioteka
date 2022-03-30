using ProjektBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Repositories
{
    public class KsiazkaRepo : IKsiazkaRepo
    {
        DbBiblioteka _database;

        public KsiazkaRepo(DbBiblioteka database)
        {
            _database = database;
        }

        public void AddAuthorsToBook(Autor autor, int id)
        {
            _database.Ksiazki.Where(k => k.KsiazkaID == id).FirstOrDefault().Autorzy.Add(autor);
        }

        public void AddBook(Ksiazka ksiazka)
        {
            _database.Ksiazki.Add(ksiazka);
        }

        public void AddCategoryToBook(Kategoria kategoria, int id)
        {
            _database.Ksiazki.Where(k => k.KsiazkaID == id).FirstOrDefault().Kategorie.Add(kategoria);
        }

        public bool DeletBook(int id)
        {
            bool result = false;
            Ksiazka k = GetBook(id);
            if (k != null)
            {
                _database.Ksiazki.Remove(k);
                result = true;
            }
            return result;
        }

        public IEnumerable<Autor> GetAuthorsOfBook(int id)
        {
             return _database.Ksiazki.Where(k => k.KsiazkaID == id).FirstOrDefault().Autorzy;
        }

        public Ksiazka GetBook(int id)
        {
            return _database.Ksiazki.Where(k => k.KsiazkaID == id).FirstOrDefault();
        }

        public IEnumerable<Ksiazka> GetBooks()
        {
            return _database.Ksiazki;
        }

        public IEnumerable<Kategoria> GetCategoriesOfBook(int id)
        {
            return _database.Ksiazki.Where(k => k.KsiazkaID == id).FirstOrDefault().Kategorie;
        }
    }
}
