using AutoMapper;
using MovieSystem.Application.DTOs.MovieDTOs;
using MovieSystem.Application.Interfaces;
using MovieSystem.Domain.Entities;
using MovieSystem.Persistence.Repositories;

namespace MovieSystem.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMapper _mapper;
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _movieRepository = repository;
        }

        public List<MovieGetDTO> GetAll()
        {
            return _mapper.Map<List<MovieGetDTO>>(_movieRepository.ReadAll());
        }

        public MovieGetDTO GetById(int id)
        {
            return _mapper.Map<MovieGetDTO>(_movieRepository.Read(id));
        }

        public MovieGetDTO Create(MovieCreateDTO entity)
        {
            var movie = _mapper.Map<Movie>(entity);
            _movieRepository.Create(movie);
            return _mapper.Map<MovieGetDTO>(movie);
        }

        public MovieGetDTO Update(MovieUpdateDTO entity)
        {
            var movie = _mapper.Map<Movie>(entity);
            _movieRepository.Update(movie);
            return _mapper.Map<MovieGetDTO>(movie);
        }

        public void Delete(int key)
        {
            _movieRepository.Delete(key);
        }
    }
}
