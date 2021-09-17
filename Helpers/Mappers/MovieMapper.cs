using MovieAppWorkshop.Domain_Models;
using MovieAppWorkshop.Domain_Models.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppWorkshop.Helpers.Mappers
{
    public static class MovieMapper
    {
        public static Movie MovieDtoToMovie(MovieDto entity)
        {
            return new Movie
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                Year = entity.Year,
                Genre = entity.Genre
            };
        }
        public static MovieDto MovieToMovieDto (Movie entity)
        {
            return new MovieDto()
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                Year = entity.Year,
                Genre = entity.Genre
            };
        }
    }
}
