using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Application.IRepository
{
    public interface IRepository <T>
    {
        void Create(T entity);
        T ReadByID(int id, bool loadNP);
        List<T> ReadAll(bool loadNP);
        void Update(T entity);
        void Delete(int id);
    }
}
