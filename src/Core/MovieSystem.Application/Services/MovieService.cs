using AutoMapper;
using MovieSystem.Application.DTOs.MovieDTOs;
using MovieSystem.Application.Interfaces;
using MovieSystem.Application.IRepository;
using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> _repository;
        private readonly IMapper _mapper;
        public MovieService(IRepository<Movie> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Add(MovieCreateDTO entity)
        {
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
