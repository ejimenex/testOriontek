using MDEntities;
using MDEntities.Model;
using MDRepository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace MDRepository.Repository.Base
{
   public class BaseRepository<T> : IBaseRepository<T> where T : BaseClass, new()
    {
        protected MDOriontekContext RepositoryContext { get; set; }
        protected readonly DbSet<T> entities;
        public BaseRepository(MDOriontekContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
            entities = RepositoryContext.Set<T>();
        }
        public virtual int Create(T entity)
        {
            entity.CreatedDate = DateTime.Now;
            var result = entities.Add(entity);
            this.RepositoryContext.SaveChanges();
            return Convert.ToInt32(result.Property("Id").CurrentValue.ToString());
        }
        public virtual void Delete(int Id)
        {
            var entity = this.GetOne(Id);
            this.Update(entity);
        }

        public virtual IQueryable<T> FindAll()
        {
            var result = this.entities.OrderByDescending(c => c.Id).AsNoTracking();
            return result;
        }

        public virtual IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        }

        public virtual T GetOne(int Id)
        {
            return this.RepositoryContext.Set<T>().Find(Id);
        }

        public virtual T Update(T entity)
        {
            entity.ModifiedDate = DateTime.Now;
            this.RepositoryContext.Set<T>().Update(entity);
            this.RepositoryContext.SaveChanges();
            return entity;
        }

        public bool Exist(Expression<Func<T, bool>> expression) => (this.RepositoryContext.Set<T>().Any(expression));

    }
}