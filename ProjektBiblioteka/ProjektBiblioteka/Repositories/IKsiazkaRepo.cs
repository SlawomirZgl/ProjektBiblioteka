﻿using ProjektBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Repositories
{
    interface IKsiazkaRepo
    {
        void AddBook(Ksiazka ksiazka);
        IEnumerable<Ksiazka> GetBooks();
        bool DeletBook(int id);
        Ksiazka GetBook(int id);
        void AddCategoryToBook(Kategoria kategoria,int id);
        IEnumerable<Kategoria> GetCategoriesOfBook();
        void AddAuthorsToBook(Autor autor, int id);
        IEnumerable<Autor> GetAuthorsOfBook();
    }
}
