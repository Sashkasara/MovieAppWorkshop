using MovieAppWorkshop.Controllers;
using MovieAppWorkshop.Domain_Models;
using MovieAppWorkshop.Domain_Models.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppWorkshop.Services
{
    interface IMovieService
    {
        List<MovieDto> GetAllMovies();

        MovieDto GetById(int id);
        List<MovieDto> GetByGenre(Genre genre);



        void Add(MovieDto entity);
        void Delete(int id);
        void Update(MovieDto entity);
    }
}
