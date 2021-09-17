using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppWorkshop.Repositories
{
    public interface IRepository<T> //KRUD OPERATIONS
    {
        List<T> GetAll();
        T GetById(int id);
        //T GetByGenre(T entity);
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);


    }
}
