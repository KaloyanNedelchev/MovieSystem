using MovieSystem.Application.IRepository;
using MovieSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        int ReadIdByEmail(string email);
    }
}
