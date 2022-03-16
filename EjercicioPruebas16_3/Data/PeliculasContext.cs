using EjercicioPruebas16_3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioPruebas16_3.Data
{
    public class PeliculasContext : DbContext
    {
        public PeliculasContext(DbContextOptions<PeliculasContext> options) : base(options)
        {

        }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Nacionalidad> Nacionalidades { get; set; }
    }
}
