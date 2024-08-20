using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MovieSystem.Application.Interfaces;
using MovieSystem.Application.DTOs.DirectorDTOs;

namespace MovieSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly IDirectorService _directorService;

        public DirectorController(IDirectorService directorService)
        {
            _directorService = directorService;
        }

        [HttpGet]
        public List<DirectorReadDTO> GetAll()
        {
            return _directorService.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public DirectorReadDTO GetById(int id)
        {
            return _directorService.Get(id);
        }

        [HttpPost]
        public void Post([FromBody] DirectorCreateDTO directorFromRequest)
        {
            _directorService.Add(directorFromRequest);
        }

        [HttpPut]
        public void Put([FromBody] DirectorUpdateDTO directorFromRequest)
        {
            _directorService.Update(directorFromRequest);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            _directorService.Delete(id);
        }
    }
}
