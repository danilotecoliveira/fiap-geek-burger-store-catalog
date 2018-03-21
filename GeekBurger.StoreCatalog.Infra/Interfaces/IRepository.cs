using System;
using System.Collections.Generic;
using System.Text;

namespace GeekBurger.StoreCatalog.Infra.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        List<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
