using ProjektBiblioteka.Models;
using ProjektBiblioteka.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektTestowy
{
    class FakeUserRepo : IUzytkownikRepo
    {
        private List<Uzytkownik> _users = new List<Uzytkownik>();
        public void AddKsiazkatoUser(Ksiazka ksiazka, int id)
        {
            throw new NotImplementedException();
        }

        public void AddUser(Uzytkownik uzytkownik)
        {
            _users.Add(uzytkownik);
        }

        public bool DeleteUser(int id)
        {
            bool temp1 = false;
            Uzytkownik temp = _users.Where(u => u.UzytkownikId == id).FirstOrDefault();
            if(temp != null)
            {
                temp1 = true;
                _users.Remove(temp);
            }
            return temp1;
        }

        public IEnumerable<Ksiazka> GetBooksOfUser(int id)
        {
            throw new NotImplementedException();
        }

        public Uzytkownik GetUser(int id)
        {
            return _users.Where(u => u.UzytkownikId == id).FirstOrDefault();
        }

        public IEnumerable<Uzytkownik> GetUsers()
        {
            return _users;
        }

        public void RemoveBookFromUser(Ksiazka ksiazka, int id)
        {
            throw new NotImplementedException();
        }
    }
}
