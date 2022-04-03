using ProjektBiblioteka.BussinessLayer.Interfaces;
using ProjektBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.BussinessLayer
{
    public class BLUztykownik : IUzytkownik
    {
        private readonly IUnitOfWork uow;

        public BLUztykownik(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public bool AddUsersBook(int userId, Ksiazka book) 
        {
            if (userId <= default(int))
                throw new ArgumentException("Invalid user id");
            if (book.KsiazkaID <= default(int))
                throw new ArgumentException("Invalid book id");

            if(book == null)
                throw new InvalidOperationException("Invalid book");
            if (uow.User.GetUser(userId) == null)
                throw new InvalidOperationException("Invalid user");

            var userBooks = uow.User.GetBooksOfUser(userId);

            if (userBooks.Any(up => up.KsiazkaID == book.KsiazkaID))
                throw new InvalidOperationException("Books are already mapped");

            uow.User.AddKsiazkatoUser(book, userId);
            uow.Complete();

            return true;
        }

        public bool DeleteUser(int userId)
        {
            if (userId <= default(int))
                throw new ArgumentException("Invalid user id");

            var isremoved = uow.User.DeleteUser(userId);
            if (isremoved)
                uow.Complete();

            return isremoved;
        }

        public IEnumerable<Uzytkownik> GetUsers()
        {
            return uow.User.GetUsers();
        }

        public IEnumerable<Ksiazka> GetUsersBook(int userId)
        {
            if (userId <= default(int))
                throw new ArgumentException("Invalid user id");

            return uow.User.GetBooksOfUser(userId);
        }

        public Uzytkownik UpsertUser(Uzytkownik user)
        {
            if (user == null)
                throw new ArgumentException("Invalid user");

            if (string.IsNullOrWhiteSpace(user.Nazwa))
                throw new ArgumentException("Invalid user name");

            Uzytkownik _user = uow.User.GetUser(user.UzytkownikId) ;
            if (_user == null)
            {
                _user = new Uzytkownik
                {
                    Nazwa = user.Nazwa,
                    Haslo = user.Haslo,
                    Ksiazki = user.Ksiazki,
                };
                uow.User.AddUser(_user);
            }
            else
            {
                _user.Nazwa = user.Nazwa;
                _user.Haslo = user.Haslo;
                _user.Ksiazki = user.Ksiazki;
            }

            uow.Complete();

            return _user;
        }
    }
}
