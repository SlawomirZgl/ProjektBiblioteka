using ProjektBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Repositories
{
    interface IAutorRepo
    {
        void AddAuthor(Autor autor);
        IEnumerable<Autor> GetAuthors();
        bool DeleteAuthor(int id);
        Autor GetAuthor(int id);
        void AddBookToAuthor(Ksiazka ksiazka,int id);
        IEnumerable<Ksiazka> GetBooksofAuthor(int id);

    }
}
