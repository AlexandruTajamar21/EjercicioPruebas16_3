using EjercicioPruebas16_3.Data;
using EjercicioPruebas16_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioPruebas16_3.Repositories
{
    public class RepositoryPeliculas
    {
        private PeliculasContext context;

        public RepositoryPeliculas(PeliculasContext context)
        {
            this.context = context;
        }
        public List<Pelicula> GetPeliculasCompleto()
        {
            return this.context.Peliculas.ToList();
        }
        public List<Pelicula> GetPeliculasNacionalidad(int idNacionalidad)
        {
            return this.context.Peliculas.Where(x => x.IdNacionalidad == idNacionalidad).ToList();
        }

        public List<Pelicula> GetPeliculasGenero(int idGenero)
        {
            return this.context.Peliculas.Where(x => x.IdGenero == idGenero).ToList();
        }

        public Pelicula FindPelicula(int idPelicula)
        {
            return this.context.Peliculas.Where(x => x.IdPelicula == idPelicula).FirstOrDefault();
        }

        public void InsertPelicula(int idPelicula, int idDistribuidor, int idGenero,
                                    string Titulo, int idNacionalidad, string Argumento
                                    ,string Foto, DateTime FechaEstreno, string Actores, string Duracion)
        {
            Pelicula pelicula = new Pelicula
            {
                IdPelicula = idPelicula,
                IdDistribuidor = idDistribuidor,
                IdGenero = idGenero,
                Titulo = Titulo,
                IdNacionalidad = idNacionalidad,
                Argumento = Argumento,
                Foto = Foto,
                FechaEstreno = FechaEstreno,
                Actores = Actores,
                Duracion = Duracion
            };
            this.context.Peliculas.Add(pelicula);
            this.context.SaveChanges();
        }
        public void UpdatePelicula(int idPelicula, int idDistribuidor, int idGenero,
                            string Titulo, int idNacionalidad, string Argumento
                            , string Foto, DateTime FechaEstreno, string Actores, string Duracion)
        {
            Pelicula pelicula = this.FindPelicula(idPelicula);
            pelicula.IdDistribuidor = idDistribuidor;
            pelicula.IdGenero = idGenero;
            pelicula.Titulo = Titulo;
            pelicula.IdNacionalidad = idNacionalidad;
            pelicula.Argumento = Argumento;
            pelicula.Foto = Foto;
            pelicula.FechaEstreno = FechaEstreno;
            pelicula.Actores = Actores;
            pelicula.Duracion = Duracion;
            this.context.SaveChanges();
        }

        public void DeletePelicula(int idPelicula)
        {
            Pelicula pelicula = this.FindPelicula(idPelicula);
            this.context.Peliculas.Remove(pelicula);
        }
    }
}
