using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDDD.Infra.Data.Repositories
{
    public class FuncionarioRepositorio : RepositorioBase<Funcionario>, IFuncionarioRepositorio
    {
    }
}
