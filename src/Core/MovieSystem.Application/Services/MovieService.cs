using MovieSystem.Application.Interfaces;
using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Services
{
    public class MovieService : IService<Movie>
    {
        private readonly IRepository<Movie> _repository;
        public MovieService(IRepository<Movie> repository)
        {
            _repository = repository;
        }
        public void Add(Movie entity)
        {
            _repository.Create(entity);
        }
        public Movie ReadByID(int id)
        {
            return _repository.ReadByID(id);
        }
        public List<Movie> GetAll()
        {
            return _repository.ReadAll();
        }
        public void Update(Movie entity)
        {
            _repository.Update(entity);
        }
        public void Delete(int key)
        {
            _repository.Delete(key);
        }
    }
}
