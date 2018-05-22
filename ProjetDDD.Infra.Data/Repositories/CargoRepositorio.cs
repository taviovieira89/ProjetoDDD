using ProjetDDD.Infra.Data.Contexto;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDDD.Infra.Data.Repositories
{
    public class CargoRepositorio : RepositorioBase<Cargo>, ICargoRepositorio
    {
        public IEnumerable<Cargo> getDescricao(string descricao)
        {
            DbContexto Db = new DbContexto();
            return Db.Cargos.Where(p => p.Descricao == descricao);
        }
    }
}
