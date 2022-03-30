﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjektBiblioteka.Models;

namespace ProjektBiblioteka.Migrations
{
    [DbContext(typeof(DbBiblioteka))]
    [Migration("20220330065142_3")]
    partial class _3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutorKsiazka", b =>
                {
                    b.Property<int>("AutorzyAutorId")
                        .HasColumnType("int");

                    b.Property<int>("KsiazkiKsiazkaID")
                        .HasColumnType("int");

                    b.HasKey("AutorzyAutorId", "KsiazkiKsiazkaID");

                    b.HasIndex("KsiazkiKsiazkaID");

                    b.ToTable("AutorKsiazka");
                });

            modelBuilder.Entity("KategoriaKsiazka", b =>
                {
                    b.Property<int>("KategorieKategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("KsiazkiKsiazkaID")
                        .HasColumnType("int");

                    b.HasKey("KategorieKategoriaId", "KsiazkiKsiazkaID");

                    b.HasIndex("KsiazkiKsiazkaID");

                    b.ToTable("KategoriaKsiazka");
                });

            modelBuilder.Entity("ProjektBiblioteka.Models.Autor", b =>
                {
                    b.Property<int>("AutorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Nazwisko")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("AutorId");

                    b.ToTable("Autorzy");
                });

            modelBuilder.Entity("ProjektBiblioteka.Models.Kategoria", b =>
                {
                    b.Property<int>("KategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nazwa")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("KategoriaId");

                    b.ToTable("Kategorie");
                });

            modelBuilder.Entity("ProjektBiblioteka.Models.Ksiazka", b =>
                {
                    b.Property<int>("KsiazkaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ilosc")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<double>("Ocena")
                        .HasColumnType("float");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UzytkownikId")
                        .HasColumnType("int");

                    b.HasKey("KsiazkaID");

                    b.HasIndex("UzytkownikId");

                    b.ToTable("Ksiazki");
                });

            modelBuilder.Entity("ProjektBiblioteka.Models.Uzytkownik", b =>
                {
                    b.Property<int>("UzytkownikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Haslo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwa")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("UzytkownikId");

                    b.ToTable("Uzytkownicy");
                });

            modelBuilder.Entity("AutorKsiazka", b =>
                {
                    b.HasOne("ProjektBiblioteka.Models.Autor", null)
                        .WithMany()
                        .HasForeignKey("AutorzyAutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjektBiblioteka.Models.Ksiazka", null)
                        .WithMany()
                        .HasForeignKey("KsiazkiKsiazkaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KategoriaKsiazka", b =>
                {
                    b.HasOne("ProjektBiblioteka.Models.Kategoria", null)
                        .WithMany()
                        .HasForeignKey("KategorieKategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjektBiblioteka.Models.Ksiazka", null)
                        .WithMany()
                        .HasForeignKey("KsiazkiKsiazkaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjektBiblioteka.Models.Ksiazka", b =>
                {
                    b.HasOne("ProjektBiblioteka.Models.Uzytkownik", null)
                        .WithMany("Ksiazki")
                        .HasForeignKey("UzytkownikId");
                });

            modelBuilder.Entity("ProjektBiblioteka.Models.Uzytkownik", b =>
                {
                    b.Navigation("Ksiazki");
                });
#pragma warning restore 612, 618
        }
    }
}
