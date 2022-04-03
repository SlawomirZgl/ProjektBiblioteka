using ProjektBiblioteka.BussinessLayer.Interfaces;
using ProjektBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.BussinessLayer
{
    public class BLKategoria : IKategoria
    {
        private readonly IUnitOfWork uow;

        public BLKategoria(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public bool DeleteCategory(int categoryId)
        {
            if (categoryId <= default(int))
                throw new ArgumentException("Invalid category id");

            var isremoved = uow.Category.DeleteCategory(categoryId);
            if (isremoved)
                uow.Complete();

            return isremoved;
        }

        public IEnumerable<Ksiazka> GetBooksByCategory(int categoryId)
        {
            return uow.Category.GetBooksOfCategory(categoryId);
        }

        public IEnumerable<Kategoria> GetCategories()
        {
            return uow.Category.GetCategories();
        }

        public Kategoria UpsertCategory(Kategoria category)
        {
            if (category == null)
                throw new ArgumentException("Invalid category");

            if (string.IsNullOrWhiteSpace(category.Nazwa))
                throw new ArgumentException("Invalid category name");

            Kategoria _category = uow.Category.GetCategory(category.KategoriaId);
            if (_category == null)
            {
                _category = new Kategoria
                {
                    Nazwa = category.Nazwa,
                    Ksiazki = category.Ksiazki,
                };
                uow.Category.AddCategory(_category);
            }
            else
            {
                _category.Nazwa = category.Nazwa;
                _category.Ksiazki = category.Ksiazki;
            }

            uow.Complete();

            return _category;
        }
    }
}
