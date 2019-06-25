using System;
using System.Collections.Generic;
using System.Text;

namespace UnityContainer
{
    public class Movie
    {
        public Movie(string title, string director)
        {
            this.Title = title;
            this.Director = director;
        }
        public string Title { get; }
        public string Director { get; }
    }
}
