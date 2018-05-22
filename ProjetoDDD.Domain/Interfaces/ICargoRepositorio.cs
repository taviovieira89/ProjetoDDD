using ProjetoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDDD.Domain.Interfaces
{
    public interface ICargoRepositorio : IRepositorioBase<Cargo>
    {
        IEnumerable<Cargo> getDescricao(string descricao);

    }
}
