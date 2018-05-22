using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces;
using ProjtoDDD.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjtoDDD.Application
{
    public class FuncionarioAppService : AppServiceBase<Funcionario>, IFuncionarioAppServices
    {
        private readonly IFuncionarioService _func_services;

        public FuncionarioAppService(IFuncionarioService funcionario) : base(funcionario)
        {
            _func_services = funcionario;
        }

    }
}
