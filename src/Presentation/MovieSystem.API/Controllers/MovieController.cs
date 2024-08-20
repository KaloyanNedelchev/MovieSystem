using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MovieSystem.Application.Interfaces;
using MovieSystem.Application.DTOs.MovieDTOs;

namespace MovieSystem.API.Controllers
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

        [HttpGet]
        public List<MovieReadDTO> GetAll()
        {
            return _movieService.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public MovieReadDTO GetById(int id)
        {
            return _movieService.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] MovieCreateDTO movieFromRequest)
        {
            _movieService.Add(movieFromRequest);
        }

        [HttpPut]
        public void Put([FromBody] MovieUpdateDTO movieFromRequest)
        {
            _movieService.Update(movieFromRequest);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            _movieService.Delete(id);
        }
    }
}
