using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Interfaces
{
    public interface IUserService <User> : IService<User> where User : class
    {
        User ReadByEmail(string email);
    }
}
