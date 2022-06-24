using ProjektBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.BussinessLayer.Interfaces
{
    public interface IUzytkownik
    {
        Uzytkownik UpsertUser(Uzytkownik user);
        IEnumerable<Uzytkownik> GetUsers();
        bool DeleteUser(int userId);
        IEnumerable<Ksiazka> GetUsersBook(int userId);
        bool AddUsersBook(int userId, Ksiazka book);
    }
}
