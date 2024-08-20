using MovieSystem.Application.DTOs.UserDTOs;
using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Interfaces
{
    public interface IUserService
    {
        void Add(UserCreateDTO entity);
        UserReadDTO Get(int id);
        List<UserReadDTO> GetAll();
        void Update(UserUpdateDTO entity);
        void Delete(int id);
    }
}
