﻿using ProjektBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Repositories
{
    public class UzytkownikRepo : IUzytkownikRepo
    {
        DbBiblioteka _database;

        public UzytkownikRepo(DbBiblioteka database)
        {
            _database = database;
            if (!database.Uzytkownicy.Any())
            {
                database.AddRange(new List<Uzytkownik>
                {
                    new Uzytkownik {Nazwa = "Uzytkownik 1", Haslo ="Haslo1"},
                    new Uzytkownik {Nazwa = "Uzytkownik 2", Haslo ="Haslo2"},
                    new Uzytkownik {Nazwa = "Uzytkownik 3", Haslo ="Haslo3"},
                    new Uzytkownik {Nazwa = "Uzytkownik 4", Haslo ="Haslo4"},
                    new Uzytkownik {Nazwa = "Uzytkownik 5", Haslo ="Haslo5"},
                });
            }
            database.SaveChanges();
        }

        public void AddKsiazkatoUser(Ksiazka ksiazka, int id)
        {
            _database.Uzytkownicy.Where(u => u.UzytkownikId == id).FirstOrDefault().Ksiazki.Add(ksiazka);
        }
        public void RemoveBookFromUser(Ksiazka ksiazka, int id)
        {
            _database.Uzytkownicy.Where(u => u.UzytkownikId == id).FirstOrDefault().Ksiazki.Remove(ksiazka);
        }

        public void AddUser(Uzytkownik uzytkownik)
        {
            _database.Uzytkownicy.Add(uzytkownik);
        }

        public bool DeleteUser(int id)
        {
            bool result = false;
            Uzytkownik u = GetUser(id);
            
            if (u != null)
            {
                _database.Uzytkownicy.Remove(u);
                result = true;
            }
            return result;
        }

        public IEnumerable<Ksiazka> GetBooksOfUser(int id)
        {
            return _database.Uzytkownicy.Where(u => u.UzytkownikId == id).FirstOrDefault().Ksiazki;
        }

        public Uzytkownik GetUser(int id)
        {
           return _database.Uzytkownicy.Where(u => u.UzytkownikId == id).FirstOrDefault();
        }

        public IEnumerable<Uzytkownik> GetUsers()
        {
            return _database.Uzytkownicy;
        }
    }
}
