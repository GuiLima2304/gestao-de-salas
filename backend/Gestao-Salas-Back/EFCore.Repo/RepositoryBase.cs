using EFCore.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCore.Repo
{
    public abstract class RepositoryBase<T> : IDisposable, IRepository<T> where T : class
    {
        protected readonly AgendamentoContext _context;

        public RepositoryBase(AgendamentoContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool Exist(Func<T, bool> p)
        {
            return _context.Set<T>().Any(p);
        }

        public virtual IEnumerable<T> Get()
        {
            return _context.Set<T>().ToList();
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
