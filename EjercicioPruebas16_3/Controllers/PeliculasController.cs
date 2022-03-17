using EjercicioPruebas16_3.Models;
using EjercicioPruebas16_3.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioPruebas16_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        private RepositoryPeliculas repo;
        public PeliculasController(RepositoryPeliculas repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public ActionResult<List<Pelicula>> GetPeliculas()
        {
            List<Pelicula> peliculas = this.repo.GetPeliculasCompleto();
            return peliculas;
        }

        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Genero>> GetGeneros()
        {
            List<Genero> generos = this.repo.GetGeneros();
            return generos;
        }
        [HttpGet]
        [Route("[action]")]
        public ActionResult<List<Nacionalidad>> GetNacionalidades()
        {
            List<Nacionalidad> nacionalidades = this.repo.GetNacionalidades();
            return nacionalidades;
        }

        [HttpGet("{id}")]
        public ActionResult<Pelicula> GetPelicula(int id)
        {
            Pelicula pelicula = this.repo.FindPelicula(id);
            return pelicula;
        }

        [HttpGet]
        [Route("[action]/{idGenero}")]
        public ActionResult<List<Pelicula>> GetPeliculasGenero(int idGenero)
        {
            List<Pelicula> pelicula = this.repo.GetPeliculasGenero(idGenero);
            return pelicula;
        }

        [HttpGet]
        [Route("[action]/{idNacionalidad}")]
        public ActionResult<List<Pelicula>> GetPeliculasNacionalidad(int idNacionalidad)
        {
            List<Pelicula> pelicula = this.repo.GetPeliculasNacionalidad(idNacionalidad);
            return pelicula;
        }

        [HttpPost]
        public ActionResult InsertPelicula(Pelicula pelicula)
        {
            this.repo.InsertPelicula(pelicula.IdPelicula,pelicula.IdDistribuidor,pelicula.IdGenero,pelicula.Titulo,pelicula.IdNacionalidad,pelicula.Argumento
                ,pelicula.Foto,pelicula.FechaEstreno, pelicula.Actores, pelicula.Duracion);
            return Ok();
        }

        [HttpDelete("{id}")]
        public void DeletePelicula(int id)
        {
            this.repo.DeletePelicula(id);
        }

        [HttpPut]
        public ActionResult UpdatePelicula(Pelicula pelicula)
        {
            this.repo.UpdatePelicula(pelicula.IdPelicula, pelicula.IdDistribuidor, pelicula.IdGenero, pelicula.Titulo, pelicula.IdNacionalidad, pelicula.Argumento
                , pelicula.Foto, pelicula.FechaEstreno, pelicula.Actores, pelicula.Duracion);
            return Ok();
        }
    }
}
