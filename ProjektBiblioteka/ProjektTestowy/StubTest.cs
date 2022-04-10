using Moq;
using ProjektBiblioteka.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjektTestowy
{
    public class StubTest
    {
        [Fact]
        public void test()
        {
            var ksiazka = Mock.Of<IKsiazkaRepo>(k => k.DeletBook(1) == true);
            var validator = new KsiazkaValidator();

            bool validate = validator.validate(ksiazka);
            Assert.True(validate);
        }
    }
    public class KsiazkaValidator
    {
        internal bool validate(IKsiazkaRepo ksiazka)
        {
            return ksiazka.DeletBook(1) == true;
        }
    }
}
