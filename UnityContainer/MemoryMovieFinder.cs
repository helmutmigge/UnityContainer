using System;
using System.Collections.Generic;
using System.Text;

namespace UnityContainer
{
    public class MemoryMovieFinder: IMovieFinder
    {
        public MemoryMovieFinder()
        {
            _movies = new List<Movie>();
            Load();
        }

        private readonly List<Movie> _movies;

        private  void Load()
        {
            _movies.Add( new Movie("A Forma da Água","Guillermo del Toro"));
            _movies.Add(new Movie("Círculo de Fogo", "Guillermo del Toro"));
        }

        public List<Movie> FindAll()
        {
            return _movies;
        }
    }
}
