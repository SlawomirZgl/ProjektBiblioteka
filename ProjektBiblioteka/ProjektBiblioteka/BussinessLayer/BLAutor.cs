using ProjektBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.BussinessLayer
{
    public class BLAutor : IAutor
    {
        private readonly IUnitOfWork uow;

        public BLAutor(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        
        public bool AddAuthorsBook(int authorId, Ksiazka book)
        {
            if (authorId <= default(int))
                throw new ArgumentException("Invalid author id");
            if (book.KsiazkaID <= default(int))
                throw new ArgumentException("Invalid book id");

            if (book == null)
                throw new InvalidOperationException("Invalid book");
            if (uow.User.GetUser(authorId) == null)
                throw new InvalidOperationException("Invalid author");

            var authorsBooks = uow.Author.GetBooksofAuthor(authorId);
            
            if (authorsBooks.Any(up => up.KsiazkaID == book.KsiazkaID))
                throw new InvalidOperationException("Books are already mapped");

            uow.User.AddKsiazkatoUser(book, authorId);
            uow.Complete();

            return true; ;
        }

        public bool DeleteAuthor(int authorId)
        {
            if (authorId <= default(int))
                throw new ArgumentException("Invalid author id");

            var isremoved = uow.Author.DeleteAuthor(authorId);
            if (isremoved)
                uow.Complete();

            return isremoved;
        }

        public IEnumerable<Autor> GetAuthors()
        {
            return uow.Author.GetAuthors();
        }

        public IEnumerable<Ksiazka> GetAuthorsBook(int authorId)
        {
            if (authorId <= default(int))
                throw new ArgumentException("Invalid author id");

            return uow.Author.GetBooksofAuthor(authorId);
        }

        public Autor UpsertAutor(Autor author)
        {
            if (author == null)
                throw new ArgumentException("Invalid user");

            if (string.IsNullOrWhiteSpace(author.Imie))
                throw new ArgumentException("Invalid user name");
            if (string.IsNullOrWhiteSpace(author.Nazwisko))
                throw new ArgumentException("Invalid user surname");

            Autor _author = uow.Author.GetAuthor(author.AutorId);
            if (_author == null)
            {
                _author = new Autor
                {
                    Imie = author.Imie,
                    Nazwisko = author.Nazwisko,
                    Ksiazki = author.Ksiazki
                };
                uow.Author.AddAuthor(_author);
            }
            else
            {
                _author.Imie = author.Imie;
                _author.Nazwisko = author.Nazwisko;
                _author.Ksiazki = author.Ksiazki;
            }

            uow.Complete();

            return _author;
        }
    }
}
