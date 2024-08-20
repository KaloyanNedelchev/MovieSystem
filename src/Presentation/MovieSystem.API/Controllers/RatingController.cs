using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MovieSystem.Application.Interfaces;
using MovieSystem.Application.DTOs.RatingDTOs;

namespace MovieSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _ratingService;

        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpGet]
        public List<RatingReadDTO> GetAll()
        {
            return _ratingService.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public RatingReadDTO GetById(int id)
        {
            return _ratingService.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] RatingCreateDTO ratingFromRequest)
        {
            _ratingService.Add(ratingFromRequest);
        }

        [HttpPut]
        public void Put([FromBody] RatingUpdateDTO ratingFromRequest)
        {
            _ratingService.Update(ratingFromRequest);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            _ratingService.Delete(id);
        }
    }
}
