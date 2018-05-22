using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDDD.Domain.Interfaces
{
   public  interface IServiceBase<TEntity> where TEntity : class
    {
        void add(TEntity obj);

        TEntity getId(int id);

        IEnumerable<TEntity> get();

        void Update(TEntity obj);

        void Remove(TEntity obj);

    }
}
