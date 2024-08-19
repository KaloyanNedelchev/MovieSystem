using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Interfaces
{
    public interface IUserRepository <User> : IRepository<User> where User : class
    {
        User ReadByEmail(string email);
    }
}
