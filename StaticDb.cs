using MovieAppWorkshop.Domain_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppWorkshop
{
    public static class StaticDb
    {
        public static int id = 4;
        public static List<Movie> Movies = new List<Movie>()
        {
            new Movie()
            {
                Id= 1,
                Title = "Titanic",
                Description = "Shipwreck",
                Genre = Genre.Other,
                Year = 1996
            },
            new Movie()
            {
                Id= 2,
                Title = "Rambo",
                Description = "Ramboo",
                Genre = Genre.Action,
                Year = 1995
            },
            new Movie()
            {
                Id= 3,
                Title = "The Others",
                Description = "Not sure",
                Genre = Genre.Drama,
                Year = 1992
            },
            new Movie()
            {
                Id= 3,
                Title = "Interstellar",
                Description = "Good movie",
                Genre = Genre.Drama,
                Year = 1998
            }
        };
    } 
}
