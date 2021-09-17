using MovieAppWorkshop.Domain_Models;
using MovieAppWorkshop.Domain_Models.DtoModels;
using MovieAppWorkshop.Helpers;
using MovieAppWorkshop.Helpers.Mappers;
using MovieAppWorkshop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppWorkshop.Services
{
    public class MovieServices : IMovieService
    {
        private readonly IRepository<Movie> _movieRepo;
        public MovieServices(IRepository<Movie> movieRepo)
        {
            _movieRepo = movieRepo;
        }


        public void Add(MovieDto entity)
        {
            Movie movie = MovieMapper.MovieDtoToMovie(entity);
            if (MovieValidator.ValidateTitle(entity.Title))
            {
                throw new Exception("The title cannot be empty");
            }

            _movieRepo.Add(movie);
        }

        public void Delete(int id)
        {
            Movie movie = _movieRepo.GetById(id);
            if (movie == null)
            {
                throw new Exception("NO such movie");
            }
            _movieRepo.Delete(id);
            
        }

        public List<MovieDto> GetAllMovies()
        {
            List<Movie> movies = _movieRepo.GetAll();
            List<MovieDto> moviesDto = movies.Select(movie => MovieMapper.MovieToMovieDto(movie))
                .ToList();
            return moviesDto;
        }

        public List<MovieDto> GetByGenre(Genre genre)
        {
            List<Movie> movies = _movieRepo.GetAll();
            List<MovieDto> moviesDto = movies.Where(movie => movie.Genre == genre)
                .Select(x => MovieMapper.MovieToMovieDto(x))
                .ToList();
            return moviesDto;
        }

        public MovieDto GetById(int id)
        {
            Movie movie = _movieRepo.GetById(id);
            if (movie == null)
            {
                throw new Exception("No movie with that ID");
            }
          return MovieMapper.MovieToMovieDto(movie);
        }

        public void Update(MovieDto entity)
        {
            Movie movie = _movieRepo.GetById(entity.Id);
            //if (movie == null)
          //  {
             //   throw new Exception("No such movie with that ID");
           // }
            if (MovieValidator.ValidateTitle(movie.Title))
            {
                throw new Exception("Title cannot be empty");
            }
            Movie smt = MovieMapper.MovieDtoToMovie(entity);
            _movieRepo.Update(smt);
        }
    }
}
