using System;
using System.Collections.Generic;
using System.Text;

namespace UnityContainer
{
    public class MovieLister
    {
        public void ConfigLanguage(Language language)
        {
            //@Todo
        }

        private readonly IMovieFinder _finder;
        public MovieLister(IMovieFinder finder)
        {
            _finder = finder;
        }
        public MovieLister():this(new ColonDelimitedMovieFinder()
        {
            Path = "movies1.txt"
        })
        {
        }

        public Movie[] MoviesDirectedBy(string director)
        {
            List<Movie> result = new List<Movie>();
            List<Movie> allMovies = _finder.FindAll();
            foreach (Movie movie in allMovies)
            {
                if (movie.Director.Equals(director))
                {
                    result.Add(movie);
                }
            }
            return result.ToArray();
        }
    }
}
