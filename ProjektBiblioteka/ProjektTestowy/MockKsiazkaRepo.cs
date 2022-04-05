using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using ProjektBiblioteka.Repositories;
using ProjektBiblioteka.Models;
namespace ProjektTestowy
{
    class MockKsiazkaRepo : Mock<IKsiazkaRepo>
    {
        public MockKsiazkaRepo MockGetKsiazkaInvalid(Ksiazka wynik)
        {
            Setup(x => x.GetBook(It.IsAny<int>())).Returns(wynik);
            return this;
        }
        public MockKsiazkaRepo MockGetKsiazka(Times times)
        {
            Verify(x => x.GetBook(It.IsAny<int>()), times);

            return this;
        }
        public MockKsiazkaRepo MockForBooks(List<Ksiazka> results)
        {
            Setup(x => x.GetBooks())
                .Returns(results);

            return this;
        }
    }
}
