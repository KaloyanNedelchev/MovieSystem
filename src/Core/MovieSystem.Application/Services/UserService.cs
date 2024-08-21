using AutoMapper;
using MovieSystem.Application.DTOs.UserDTOs;
using MovieSystem.Application.Interfaces;
using MovieSystem.Application.Validators.UserValidation;
using MovieSystem.Domain.Entities;

namespace MovieSystem.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        private readonly CreateUserDTOValidator _validator;
        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _validator = new CreateUserDTOValidator();
        }

        public void Add(UserCreateDTO entity)
        {
            _validator.Validate(entity);
            User userFromClient = _mapper.Map<User>(entity);
            _repository.Create(userFromClient);
        }

        public UserReadDTO Get(int id)
        {
            User userFromDb = _repository.ReadByID(id, false);
            return _mapper.Map<UserReadDTO>(userFromDb);
        }

        public List<UserReadDTO> GetAll()
        {
            List<User> usersFromDb = _repository.ReadAll(false);
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
