using ProjektBiblioteka.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka
{
    public interface IUnitOfWork
    {
        IAutorRepo Author { get; }
        IKategoriaRepo Category { get; }
        IKsiazkaRepo Book { get; }
        IUzytkownikRepo User { get; }

        Task<int> CompleteAsync();
        int Complete();
    }
}
