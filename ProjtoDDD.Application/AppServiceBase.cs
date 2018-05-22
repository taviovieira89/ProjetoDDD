using ProjetoDDD.Domain.Interfaces;
using ProjtoDDD.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjtoDDD.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServicesBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _servicesbase;
        public AppServiceBase(IServiceBase<TEntity> servicesbase)
        {
            _servicesbase = servicesbase;
        }


        public void add(TEntity obj)
        {
            _servicesbase.add(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> get()
        {
            return _servicesbase.get();
        }

        public TEntity getId(int id)
        {
            return _servicesbase.getId(id);
        }

        public void Remove(TEntity obj)
        {
            _servicesbase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _servicesbase.Update(obj);
        }
    }
}
