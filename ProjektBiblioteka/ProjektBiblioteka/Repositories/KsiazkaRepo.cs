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
            if (!database.Ksiazki.Any())
            {
                database.AddRange(new List<Ksiazka>
                {
                    new Ksiazka {Ilosc = 1, Nazwa = "Ksiazka 1", Ocena = 3, Opis = "Opis ksiazka1"},
                    new Ksiazka {Ilosc = 2, Nazwa = "Ksiazka 2", Ocena = 4, Opis = "Opis ksiazka2"},
                    new Ksiazka {Ilosc = 3, Nazwa = "Ksiazka 3", Ocena = 5, Opis = "Opis ksiazka3"},
                    new Ksiazka {Ilosc = 4, Nazwa = "Ksiazka 4", Ocena = 6, Opis = "Opis ksiazka4"},
                    new Ksiazka {Ilosc = 5, Nazwa = "Ksiazka 5", Ocena = 7, Opis = "Opis ksiazka5"},
                });
            }
            database.SaveChanges();
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
