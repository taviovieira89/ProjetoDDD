using ProjetoDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using ProjetDDD.Infra.Data.Contexto;

namespace ProjetDDD.Infra.Data.Repositories
{
    public class RepositorioBase<TEntity> : IDisposable, IRepositorioBase<TEntity> where TEntity : class
    {
        DbContexto Db = new DbContexto();
        Type providerService = typeof(System.Data.Entity.SqlServer.SqlProviderServices);

        public void add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> get()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity getId(int id)
        {
            return Db.Set<TEntity>().Find(id);

        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
