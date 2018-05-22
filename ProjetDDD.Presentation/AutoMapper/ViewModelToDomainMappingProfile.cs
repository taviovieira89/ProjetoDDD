using AutoMapper;
using ProjetDDD.Presentation.Views.Models;
using ProjetoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetDDD.Presentation.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public void Configure()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Funcionario, ViewModelsFuncionario>());

            Mapper.Initialize(cfg => cfg.CreateMap<Cargo, ViewModelsCargo>());
        }

    }
}