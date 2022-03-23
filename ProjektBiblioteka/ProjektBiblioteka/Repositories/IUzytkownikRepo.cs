using ProjektBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Repositories
{
    public interface IUzytkownikRepo
    {
        void AddUser(Uzytkownik uzytkownik);
        IEnumerable<Uzytkownik> GetUsers();
        bool DeleteUser(int id);
        Uzytkownik GetUzytkownik(int id);
        void AddKsiazkatoUser(Ksiazka ksiazka,int id);
        IEnumerable<Ksiazka> GetBooksOfUser();


    }
}
