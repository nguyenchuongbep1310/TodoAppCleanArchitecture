using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections;

namespace Domain.Repositories
{
    public interface IRepository<T>         
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void FindById(Expression<Func<T, bool>> expression);

        List<T> GetAll(Expression<Func<T, bool>> expression);
    }
}
