using AutoMapper;
using MovieSystem.Application.DTOs.MovieDTOs;
using MovieSystem.Application.Interfaces;
using MovieSystem.Application.IRepository;
using MovieSystem.Application.Validators.MovieValidation;
using MovieSystem.Domain.Entities;

namespace MovieSystem.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> _repository;
        private readonly IMapper _mapper;
        private readonly CreateMovieDTOValidator _validator;
        public MovieService(IRepository<Movie> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _validator = new CreateMovieDTOValidator();
        }

        public void Add(MovieCreateDTO entity)
        {
            _validator.Validate(entity);
            Movie movieFromClient = _mapper.Map<Movie>(entity);
            _repository.Create(movieFromClient);
        }

        public MovieReadDTO Get(int id)
        {
            Movie movieFromDb = _repository.ReadByID(id, false);
            return _mapper.Map<MovieReadDTO>(movieFromDb);
        }

        public List<MovieReadDTO> GetAll()
        {
            List<Movie> moviesFromDb = _repository.ReadAll(false);
            return _mapper.Map<List<MovieReadDTO>>(moviesFromDb);
        }

        public void Update(MovieUpdateDTO entity)
        {
            Movie movieFromClient = _mapper.Map<Movie>(entity);
            _repository.Update(movieFromClient);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
