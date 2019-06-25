using System;
using Unity;
using Unity.Injection;

namespace UnityContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate UnityContainer
            IUnityContainer container = new Unity.UnityContainer();
            //Register Type with Unity
            container.RegisterType<Language>(new InjectionConstructor("pt-br"));
            container.RegisterType<MovieLister>(new InjectionMethod("ConfigLanguage",
                container.Resolve<Language>()));
            
            //Resolve
            Language language = container.Resolve<Language>();

            //Register Type with Unity
            container.RegisterType<IMovieFinder, ColonDelimitedMovieFinder>(
                new InjectionProperty("Path", "movies1.txt"));

            container.RegisterType<IMovieFinder, MemoryMovieFinder>("memory");

            container.RegisterType<MovieLister>("default",new InjectionConstructor(container.Resolve<IMovieFinder>("memory")));
            //Resolve
            MovieLister movieLister = container.Resolve<MovieLister>("default");
            

            Console.WriteLine($"Language {language.Type}");
            string director = "Guillermo del Toro";
            foreach (Movie movie in movieLister.MoviesDirectedBy(director))
            {
                Console.WriteLine($"Movie {movie.Title}");
            }
        }
    }
}
