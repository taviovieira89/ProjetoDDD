using AutoMapper;
using ProjetDDD.Presentation.Views.Models;
using ProjetoDDD.Domain.Entities;

namespace ProjetDDD.Presentation.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        //public override string ProfileName()
        //{
        //  get { return "ViewModelToDomainMappingProfile"};
        //}

        public void Configure()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<ViewModelsFuncionario, Funcionario>());

            Mapper.Initialize(cfg => cfg.CreateMap<ViewModelsCargo, Cargo>());
        }
    }
}