using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieAppWorkshop.Domain_Models;
using MovieAppWorkshop.Domain_Models.DtoModels;
using MovieAppWorkshop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieAppWorkshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;   
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        // GET: api/<MovieController>
        [HttpGet]
        public ActionResult<List<MovieDto>> GetAll([FromQuery] Genre genre)
        {
            try
            {
                if(genre == 0)
                {
                    return Ok(_movieService.GetAllMovies());
                }
                return Ok(_movieService.GetByGenre(genre));
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new { Message = ex.Message });
            }
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")] // api/movies
        public ActionResult<MovieDto> GetById(int id)
        {
            try
            {
                return Ok(_movieService.GetById(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet] // api/movie/ 
        public ActionResult<List<MovieDto>> GetByGenre([FromQuery] Genre genre)
        {
            try
            {
                return Ok(_movieService.GetByGenre(genre));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // POST api/<MovieController>
        [HttpPost]
        public ActionResult Post([FromBody] MovieDto movieDto)
        {
            try
            {
                _movieService.Add(movieDto);
                return StatusCode(StatusCodes.Status201Created, new { Message = "Movie created successfully" });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")] //api/movies/update
        public ActionResult Put([FromBody] MovieDto movieDto)
        {
            try
            {
                _movieService.Update(movieDto);
                return StatusCode(StatusCodes.Status200OK, new { Message = "Movie updated successfully" });
            }
            catch (Exception)
            {

                BadRequest();
            }
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")] //api/movies
        public ActionResult Delete(int id)
        {
            try
            {
                _movieService.Delete(id);
                return Ok();
            }
            catch (Exception)
            {

                BadRequest();
            }
        }
    }
}
