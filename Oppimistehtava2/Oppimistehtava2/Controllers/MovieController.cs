using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Oppimistehtava2.Models;

namespace Oppimistehtava2.Controllers
{
    public class MovieController : Controller
    {

        private static List<Movie> Movies = new List<Movie>();

        public MovieController()
        {
            if (null == Movies)
            {
                Movies = new List<Movie>();
                Movie movie1 = new Movie();
                movie1.Id = 1;
                movie1.Name = "Titanic";
                movie1.PublishedYear = 2000;
                movie1.Actors = new List<Actor>();

                Actor actor1Movie1 = new Actor();
                actor1Movie1.Id = 11;
                actor1Movie1.Name = "Kate Winslet";
                movie1.Actors.Add(actor1Movie1);//Lisätään näyttelijä2 listaan

                Actor actor2Movie1 = new Actor();
                actor2Movie1.Id = 12;
                actor2Movie1.Name = "Leonardo DiCaprio";
                movie1.Actors.Add(actor2Movie1);//Lisätään näyttelijä2 listaan

                Movies.Add(movie1);//Lisätään elokuva listaan

                Movie movie2 = new Movie();
                movie2.Id = 2;
                movie2.Name = "Harry Potter ja Viisasten kivi";
                movie2.PublishedYear = 2001;
                movie2.Actors = new List<Actor>();//Lisätään näyttelijä2 listaan

                Actor actor1Movie2 = new Actor();
                actor1Movie2.Id = 13;
                actor1Movie2.Name = "Daniel Radcliff";
                movie2.Actors.Add(actor1Movie2); //Lisätään näyttelijä1 listaan

                Actor actor2Movie2 = new Actor();
                actor2Movie2.Id = 14;
                actor2Movie2.Name = "Emma Watson";
                movie2.Actors.Add(actor2Movie2);//Lisätään näyttelijä2 listaan

                Movies.Add(movie2);//Lisätään elokuva listaan

                Movie movie3 = new Movie();
                movie3.Id = 3;
                movie3.Name = "Taru sormusten herrasta";
                movie3.PublishedYear = 2003;

                Actor actor1Movie3 = new Actor();
                actor1Movie3.Id = 15;
                actor1Movie3.Name = "Elijah Wood";
                movie3.Actors.Add(actor1Movie3);//Lisätään näyttelijä1 listaan

                Actor actor2Movie3 = new Actor();
                actor2Movie3.Id = 16;
                actor2Movie3.Name = "Orlando Bloom";
                movie3.Actors.Add(actor2Movie3);//Lisätään näyttelijä2 listaan

                Movies.Add(movie3);//Lisätään elokuva listaan }
            }
        }
            public IActionResult Index()
        {
            return View(Movies);
        }
    }
}