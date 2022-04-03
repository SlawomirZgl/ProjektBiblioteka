using ProjektBiblioteka.BussinessLayer.Interfaces;
using ProjektBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.BussinessLayer
{
    public class BLKsiazka : IKsiazka
    {
        private readonly IUnitOfWork uow;
        
        public BLKsiazka(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public bool AddBookAuthors(int bookId, Autor author)    
        {
            if (bookId <= default(int))
                throw new ArgumentException("Invalid book id");
            if (author.AutorId <= default(int))
                throw new ArgumentException("Invalid author id");

            if (uow.Book.GetBook(bookId) == null)
                throw new InvalidOperationException("Invalid product");

            if (author == null)
                throw new InvalidOperationException("Invalid authors");

            var booksAuthors = uow.Book.GetAuthorsOfBook(bookId);

            if(booksAuthors.Any(up => up.AutorId == author.AutorId))
                throw new InvalidOperationException("Authors are already mapped");

            uow.Book.AddAuthorsToBook(author, bookId);
            uow.Complete();

            return true;
        }
        //Zmienic podobnie kategorie na idkategorii
        public bool AddBookCategory(Kategoria category, int bookId)
        {
            if (bookId <= default(int))
                throw new ArgumentException("Invalid book id");
            if (category.KategoriaId <= default(int))
                throw new ArgumentException("Invalid author id");

            if (uow.Book.GetBook(bookId) == null)
                throw new InvalidOperationException("Invalid product");

            if (uow.User.GetUser(category.KategoriaId) == null)  
                throw new InvalidOperationException("Invalid authors");

            var booksCategories = uow.Book.GetCategoriesOfBook(bookId);

            if (booksCategories.Any(up => up.KategoriaId== category.KategoriaId))
                throw new InvalidOperationException("CategORY already mapped");

            uow.Book.AddCategoryToBook(category, bookId);
            uow.Complete();

            return true;
        }

        public void AddBookRate(int bookId, double rate)
        {
            throw new NotImplementedException();
        }

        public bool DeleteBook(int bookId)
        {
            if (bookId <= default(int))
                throw new ArgumentException("Invalid book id");

            var isremoved = uow.Book.DeletBook(bookId);
            if (isremoved)
                uow.Complete();

            return isremoved;
        }

        public IEnumerable<Autor> GetBookAuthors(int bookId)
        {
            if (bookId <= default(int))
                throw new ArgumentException("Invalid book id");
            return uow.Book.GetAuthorsOfBook(bookId);
        }

        public IEnumerable<Kategoria> GetBookCategories(int bookId)
        {
            if (bookId <= default(int))
                throw new ArgumentException("Invalid book id");
            return uow.Book.GetCategoriesOfBook(bookId);
        }

        public IEnumerable<Ksiazka> GetBooks()
        {
            return uow.Book.GetBooks();
        }

        public Ksiazka UpsertBook(Ksiazka book)
        {
            if (book == null)
                throw new ArgumentException("Invalid book");

            if (string.IsNullOrWhiteSpace(book.Nazwa))
                throw new ArgumentException("Invalid book name");

            Ksiazka _book = uow.Book.GetBook(book.KsiazkaID);
            if (_book == null)
            {
                _book = new Ksiazka
                {
                    Nazwa = book.Nazwa,
                    Ilosc = book.Ilosc,
                    Opis = book.Opis,
                    Autorzy = book.Autorzy,
                    Kategorie = book.Kategorie,
                    Ocena = book.Ocena,
                };
                
                uow.Book.AddBook(_book);
            }
            else
            {
                _book.Nazwa = book.Nazwa;
                _book.Ilosc = book.Ilosc;
                _book.Opis = book.Opis;
                _book.Autorzy = book.Autorzy;
                _book.Kategorie = book.Kategorie;
                _book.Ocena = book.Ocena;
            }

            uow.Complete();

            return _book;
        }
    }
}
