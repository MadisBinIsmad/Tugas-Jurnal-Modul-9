using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using modul9_103082400038.Models;

namespace modul9_103082400038.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>
        {
            new Movie
            {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string> { "Tim Robbins", "Morgan Freeman" },
                Description = "Two imprisoned men bond over years..."
            },
            new Movie
            {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string> { "Al Pacino", "Marlon Brando" },
                Description = "The aging patriarch of an organized crime dynasty..."
            },
            new Movie
            {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new List<string> { "Christian Bale", "Heath Ledger" },
                Description = "Batman faces the Joker..."
            }
        };

        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            return movies;
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetById(int id)
        {
            if (id < 0 || id >= movies.Count)
                return NotFound();

            return movies[id];
        }

        [HttpPost]
        public ActionResult Post([FromBody] Movie movie)
        {
            movies.Add(movie);
            return Ok(movies);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 0 || id >= movies.Count)
                return NotFound();

            movies.RemoveAt(id);
            return Ok(movies);
        }
    }
}