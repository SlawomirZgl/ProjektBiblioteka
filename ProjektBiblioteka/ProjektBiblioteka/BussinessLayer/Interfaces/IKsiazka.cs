using ProjektBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.BussinessLayer.Interfaces
{
    interface IKsiazka
    {
        Ksiazka UpsertBook(Ksiazka book);
        IEnumerable<Ksiazka> GetBooks();
        bool DeleteBook(int bookId);
        bool AddBookCategory(Kategoria category, int bookId);
        IEnumerable<Kategoria> GetBookCategories(int bookId);
        bool AddBookAuthors(int bookId, Autor author);
        IEnumerable<Autor> GetBookAuthors(int bookId);
        void AddBookRate(int bookId, double rate);
    }
}
