using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.Interfaces
{
    public interface IRepository <T>
    {
        void Create(T entity);
        T Read(int id);
        List<T> ReadAll();
        void Update(T entity);
        void Delete(int id);
    }
}
