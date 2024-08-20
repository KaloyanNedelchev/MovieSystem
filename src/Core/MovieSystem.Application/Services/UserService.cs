using AutoMapper;
using MovieSystem.Application.Interfaces;
using MovieSystem.Domain.Entities;
using MovieSystem.Application.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Services
{
    public class UserService : IUserService 
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Add(UserCreateDTO entity)
        {
            User userFromClient = _mapper.Map<User>(entity);
            _repository.Create(userFromClient);
        }

        public UserReadDTO Get(int id)
        {
            User userFromDb = _repository.ReadByID(id);
            return _mapper.Map<UserReadDTO>(userFromDb);
        }

        public List<UserReadDTO> GetAll()
        {
            List<User> usersFromDb = _repository.ReadAll();
            return _mapper.Map<List<UserReadDTO>>(usersFromDb);
        }

        public void Update(UserUpdateDTO entity)
        {
            User userFromClient = _mapper.Map<User>(entity);
            _repository.Update(userFromClient);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
