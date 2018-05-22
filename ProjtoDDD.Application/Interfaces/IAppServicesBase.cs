using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjtoDDD.Application.Interfaces
{
    public interface IAppServicesBase<TEntity> where TEntity : class
    {
        void add(TEntity obj);

        TEntity getId(int id);

        IEnumerable<TEntity> get();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}
