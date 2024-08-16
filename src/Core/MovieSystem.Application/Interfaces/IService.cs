using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Interfaces
{
    public interface IService <T>
    {
        void Create(T entity);
        T Read(int id);
        List<T> GetAll();
        void Update(T entity);
        void Delete(int id);
    }
}
