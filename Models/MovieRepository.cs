using System;
using System.Collections.Generic;
using System.Linq;

namespace dotnet_mvc.Models
{
    public class MovieRepository
    {
        private static List<Movie> _allMovies = new List<Movie>() {

            new Movie
            {
                Id = 1,
                Title = "When Harry Met Sally",
                ReleaseDate = DateTime.Parse("1989-2-12"),
                Genre = "Romantic Comedy",
                Price = 7.99M
            },

            new Movie
            {
                Id = 2,
                Title = "Ghostbusters ",
                ReleaseDate = DateTime.Parse("1984-3-13"),
                Genre = "Comedy",
                Price = 8.99M
            },

            new Movie
            {
                Id = 3,
                Title = "Ghostbusters 2",
                ReleaseDate = DateTime.Parse("1986-2-23"),
                Genre = "Comedy",
                Price = 9.99M
            },

            new Movie
            {
                Id = 4,
                Title = "Rio Bravo",
                ReleaseDate = DateTime.Parse("1959-4-15"),
                Genre = "Western",
                Price = 3.99M
            }
        };

        public List<Movie> GetMovie() => _allMovies;

        public void DeleteMovie(int id)
        {
            var toDelete = _allMovies.FirstOrDefault(m => m.Id == id);
            if (toDelete != null)
            {
                _allMovies.Remove(toDelete);
            }
        }
    }
}