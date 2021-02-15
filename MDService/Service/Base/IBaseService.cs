using System;
using System.Linq;
using System.Linq.Expressions;

namespace MDService.Service.Base
{
    public interface IBaseService<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        bool Exist(Expression<Func<T, bool>> expression);
        T GetOne(int Id);
        int Create(T entity);
        T Update(T entity);
        void Delete(int Id);
    }
}