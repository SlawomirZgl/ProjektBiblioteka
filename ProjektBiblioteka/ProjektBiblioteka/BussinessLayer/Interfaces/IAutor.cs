using ProjektBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.BussinessLayer
{
    public interface IAutor
    {
        Autor UpsertAutor(Autor author);
        IEnumerable<Autor> GetAuthors();
        bool DeleteAuthor(int authorId);
        bool AddAuthorsBook(int authorId, Ksiazka book);
        IEnumerable<Ksiazka> GetAuthorsBook(int authorId);
    }
}
