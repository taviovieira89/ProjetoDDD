using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces;


namespace ProjtoDDD.Application
{
    public class CargoAppService : AppServiceBase<Cargo>, ICargoService
    {
        private readonly ICargoService _cargoservice;

        public CargoAppService(ICargoService cargoservice) : base(cargoservice)
        {
            _cargoservice = cargoservice;
        }
    }

}
