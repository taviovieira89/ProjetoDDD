using System.Collections.Generic;

namespace ProjetoDDD.Domain.Interfaces
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        void add(TEntity obj);

        TEntity getId(int id);

        IEnumerable<TEntity> get();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}
