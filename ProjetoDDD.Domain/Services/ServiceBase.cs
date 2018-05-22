using ProjetoDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositorioBase<TEntity> _repositorio;

        public ServiceBase(IRepositorioBase<TEntity> repositorio)
        {
            _repositorio = repositorio;
        }

        public void add(TEntity obj)
        {
            _repositorio.add(obj);
        }

        public void Dispose()
        {
            _repositorio.Dispose();
        }

        public IEnumerable<TEntity> get()
        {
            return _repositorio.get();
        }

        public TEntity getId(int id)
        {
            return _repositorio.getId(id);
        }

        public void Remove(TEntity obj)
        {
            _repositorio.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _repositorio.Update(obj);
        }
    }
}
