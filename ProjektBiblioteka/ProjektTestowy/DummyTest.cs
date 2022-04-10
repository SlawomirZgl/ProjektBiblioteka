using ProjektBiblioteka;
using ProjektBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjektTestowy
{
    public class DummyTest
    {
        [Fact]
        public void UnitOfWorkConstructorNullExceptionTest()
        {
            DbBiblioteka db = null;
            Assert.Throws<ArgumentNullException>(() => new UnitOfWork(db));
        }
    }
}
