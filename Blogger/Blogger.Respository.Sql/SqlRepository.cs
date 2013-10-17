using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using Blogger.Interface;
using Blogger.Entity;

namespace Blogger.Respository.Sql
{
    public class SqlRepository<T> : IRepository<T> where T : EntityBase
    {
        private readonly DbContext _context;
        private bool _disposed = false;

        protected DbContext Context { get { return _context; } }

        public SqlRepository()
        {
            _context = new SqlContext();
        }

        public SqlRepository(DbContext context)
        {
            _context = context;
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Query(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Detach(T entity)
        {
            throw new NotImplementedException();
        }

       /* public void Dispose()
        {
            _context.Dispose();
        }
        */
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposed = true;

            }
        }
    }
}
