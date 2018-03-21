using GeekBurger.StoreCatalog.Infra.Interfaces;
using System.Collections.Generic;

namespace GeekBurger.StoreCatalog.Infra.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IDbContext _context;

        public Repository(IDbContext context)
        {
            this._context = context;
        }

        public T GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

    }
}
