using ProjetoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDDD.Domain.Interfaces
{
    public interface IFuncionarioService : IServiceBase<Funcionario>
    {
        //IEnumerable<Funcionario> MaiorIdade(IEnumerable<Funcionario> funcionarios);
    }
}
