using ProjektBiblioteka.Repositories;
using ProjektBiblioteka.Models;
using System;
using Xunit;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using FluentAssertions;
namespace ProjektTestowy
{
    public class UnitTest1
    {
        [Test]
        public void Fake()
        {
            var userRepo = new FakeUserRepo();
            userRepo.AddUser(GetUzytkownicy()[0]);
            userRepo.AddUser(GetUzytkownicy()[1]);
            userRepo.AddUser(GetUzytkownicy()[2]);
            string nazwa = userRepo.GetUser(1).Nazwa;
            nazwa.Should()
                .Be("Maciek");

        }
        [Fact]
        public void TestMockKsiazka()
        {
            var mockksiazki = GetKsiazki();
            var mockKsiazkaRepository = new MockKsiazkaRepo().MockForBooks(mockksiazki);
            mockKsiazkaRepository.MockGetKsiazka(Times.Once());
        }
        private List<Ksiazka> GetKsiazki()
        {
            return new List<Ksiazka>()
        {
            new Ksiazka()
            {
                KsiazkaID =1,
                Ilosc = 3,
                Nazwa = "W pustyni i w puszczy",
                Ocena = 3,
                Opis = " aa"
            },
            new Ksiazka()
            {
                KsiazkaID =2,
                Ilosc = 2,
                Nazwa = "W pustyni i w puszczy2",
                Ocena = 3,
                Opis = " ba"
            },
            new Ksiazka()
            {
                KsiazkaID =3,
                Ilosc = 3,
                Nazwa = "W pustyni i w puszczy3",
                Ocena = 3,
                Opis = " ca"
            },
        };

        }
        private List<Uzytkownik> GetUzytkownicy()
        {
            return new List<Uzytkownik>()
            {
                new Uzytkownik()
                {
                    UzytkownikId = 1,
                    Nazwa = " Maciek",
                    Haslo = "Dobre"
                },
                 new Uzytkownik()
                {
                    UzytkownikId = 2,
                    Nazwa = " Maciek2",
                    Haslo = "Dobre2"
                },
                  new Uzytkownik()
                {
                    UzytkownikId = 3,
                    Nazwa = " Maciek2",
                    Haslo = "Dobre2"
                }

            };
        }
    }
    
}
