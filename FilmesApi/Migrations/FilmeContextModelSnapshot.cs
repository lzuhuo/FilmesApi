﻿// <auto-generated />
using FilmesApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FilmesApi.Migrations
{
    [DbContext(typeof(FilmeContext))]
    partial class FilmeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("FilmesApi.Models.Filme", b =>
                {
                    b.Property<int>("CD_FILME")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DS_DESCRICAO")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DS_GENERO")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("NM_FILME")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NR_DURACAO")
                        .HasColumnType("int");

                    b.HasKey("CD_FILME");

                    b.ToTable("Filmes");
                });
#pragma warning restore 612, 618
        }
    }
}
