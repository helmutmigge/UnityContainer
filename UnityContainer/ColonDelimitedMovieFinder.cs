using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Text;

namespace UnityContainer
{
    public class ColonDelimitedMovieFinder: IMovieFinder
    {
        public string Path { get; set; }

        public List<Movie> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
