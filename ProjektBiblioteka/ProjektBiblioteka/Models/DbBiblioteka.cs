using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBiblioteka.Models
{
    public class DbBiblioteka: DbContext

    {
        public DbSet<Autor> Autorzy { get; set; }
        public DbSet<Ksiazka> Ksiazki { get; set; }
        public DbSet<Uzytkownik> Uzytkownicy { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("C:\\Users\\Dawid\\Desktop\\szkolka\\PK\\ProjektBiblioteka\\ProjektBiblioteka\\ProjektBiblioteka\\Models\\DataBase.db");
            optionsBuilder.UseSqlite("Data source=D:\\ProjektBiblioteka\\ProjektBiblioteka\\ProjektBiblioteka\\Models\\DataBase.db");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
