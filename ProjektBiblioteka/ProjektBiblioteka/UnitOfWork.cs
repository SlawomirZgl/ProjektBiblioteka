using ProjektBiblioteka.Models;
using ProjektBiblioteka.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbBiblioteka dbBiblioteka;

        public UnitOfWork(DbBiblioteka dbBiblioteka)
        {
            this.dbBiblioteka = dbBiblioteka;
        }
        private IAutorRepo _Autor;
        private IKategoriaRepo _Kategoria;
        private IKsiazkaRepo _Ksiazka;
        private IUzytkownikRepo _Uzytkownik;

        public IAutorRepo Author {
            get
            {
                if(this._Autor == null)
                {
                    this._Autor = new AutorRepo(dbBiblioteka);
                }
                return this._Autor;
            }
        }

        public IKategoriaRepo Category
        {
            get
            {
                if (this._Kategoria == null)
                {
                    this._Kategoria = new KategoriaRepo(dbBiblioteka);
                }
                return this._Kategoria;
            }
        }

        public IKsiazkaRepo Book
        {
            get
            {
                if (this._Ksiazka == null)
                {
                    this._Ksiazka = new KsiazkaRepo(dbBiblioteka);
                }
                return this._Ksiazka;
            }
        }

        public IUzytkownikRepo User
        {
            get
            {
                if (this._Uzytkownik == null)
                {
                    this._Uzytkownik = new UzytkownikRepo(dbBiblioteka);
                }
                return this._Uzytkownik;
            }
        }

        public int Complete()
        {
            return dbBiblioteka.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await dbBiblioteka.SaveChangesAsync();
        }
        public void Dispose() => dbBiblioteka.Dispose();
    }
}
