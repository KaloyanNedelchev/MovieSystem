using Microsoft.AspNetCore.Mvc;
using MovieSystem.Application.DTOs.MovieDTOs;
using MovieSystem.Application.Interfaces;
using MovieSystem.Domain.Entities;

namespace src.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IEnumerable<MovieGetDTO> Get()
        {
            return _movieService.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public MovieGetDTO GetById(int id)
        {
            return _movieService.GetById(id);
        }

        [HttpPost]
        public MovieGetDTO Post([FromBody] MovieCreateDTO user)
        {
           return _movieService.Create(user);
        }

        [HttpPut]
        public MovieGetDTO Put([FromBody] MovieUpdateDTO user)
        {
            return _movieService.Update(user);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            _movieService.Delete(id);
        }
    }
}
