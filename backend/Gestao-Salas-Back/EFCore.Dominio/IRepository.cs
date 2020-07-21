using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Dominio
{
    public interface IRepository<T>where T: class
    {
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        T Get(int id);
        IEnumerable<T> Get();
        bool Exist(Func<T, bool> p);
    }
}
