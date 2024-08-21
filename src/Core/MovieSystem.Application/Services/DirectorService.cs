using MovieSystem.Application.Interfaces;
using MovieSystem.Domain.Entities;
using MovieSystem.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieSystem.Application.DTOs.DirectorDTOs;
using AutoMapper;
using MovieSystem.Application.IRepository;

namespace MovieSystem.Application.Services
{
    public class DirectorService : IDirectorService
    {
        private readonly IRepository<Director> _repository;
        private readonly IMapper _mapper;
        public DirectorService(IRepository<Director> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Add(DirectorCreateDTO entity)
        {
            Director directorFromClient = _mapper.Map<Director>(entity);
            _repository.Create(directorFromClient);
        }

        public DirectorReadDTO Get(int id)
        {
            Director directorFromDb = _repository.ReadByID(id, false);
            return _mapper.Map<DirectorReadDTO>(directorFromDb);
        }

        public List<DirectorReadDTO> GetAll()
        {
            List<Director> directorsFromDb = _repository.ReadAll(false);
            return _mapper.Map<List<DirectorReadDTO>>(directorsFromDb);
        }

        public void Update(DirectorUpdateDTO entity)
        {
            Director directorFromClient = _mapper.Map<Director>(entity);
            _repository.Update(directorFromClient);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
