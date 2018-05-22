using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDDD.Domain.Services
{
    public class FuncionarioService : ServiceBase<Funcionario>, IFuncionarioService
    {
        private readonly IFuncionarioRepositorio _funcService;

        public FuncionarioService(IFuncionarioRepositorio func) : base(func)
        {
            _funcService = func;
        }

        //public IEnumerable<Funcionario> MaiorIdade(IEnumerable<Funcionario> funcionarios)
        //{
        //    Funcionario funcs =null;
        //    foreach (Funcionario item in funcionarios)
        //    {

        //    }

        //    return funcionarios.GetEnumerator().Current.MaiorIdade(x=>x.)
        //}


    }
}
