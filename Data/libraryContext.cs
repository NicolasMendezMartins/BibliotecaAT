using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using library.Models;

namespace library.Data
{
    public class libraryContext : DbContext
    {
        public libraryContext (DbContextOptions<libraryContext> options)
            : base(options)
        {
        }

        public DbSet<library.Models.Autor> Autor { get; set; } = default;

        public DbSet<library.Models.Livro> Livro { get; set; }

        public DbSet<library.Models.Genero> Genero { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Genero[] generos = new Genero[]{
                new Genero() { Id = 1, Name = "Terror"},
                new Genero() { Id = 2, Name = "Ação" },
                new Genero() { Id = 3, Name = "Aventura" },
                new Genero() { Id = 4, Name = "Suspense" },
                new Genero() { Id = 5, Name = "Romance" },
                new Genero() { Id = 6, Name = "Erotico" },
                new Genero() { Id = 7, Name = "Misterio" },
                new Genero() { Id = 8, Name = "Cronica" },
                new Genero() { Id = 9, Name = "Historico"},
                new Genero() { Id = 10,Name = "Filosofia" },
                new Genero() { Id = 11,Name = "Quadrinhos" },
                new Genero() { Id = 12,Name = "Culinaria" }
                
            };
            
            Autor[] autores = new Autor[]{
                new Autor(){
                    Id = 18,
                    FirstName = "David",
                    LastName = "Coimbra",
                    birth = new DateTime(1962, 4, 28),
                    ImageFile = "0David_Coimbra_(2013).png"
                  
                },
                
            };
        
            modelBuilder.Entity<Genero>().HasData(generos);
            modelBuilder.Entity<Autor>().HasData(autores);

            modelBuilder.Entity<Livro>().HasData(
                new Livro()
                {
                    Id = 18,
                    ISBN = "9788525427144",
                    Name = "Uma História do Mundo",
                    DataDePublicacao = new DateTime(2012, 9, 26),
                    AutorId = 18,
                    GeneroId = 9
                });
               
        }

    }
}
