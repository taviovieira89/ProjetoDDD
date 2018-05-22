using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDDD.Domain.Services
{
    public class CargoService : ServiceBase<Cargo>, ICargoService
    {
        private readonly ICargoRepositorio _cargoservice;

        public CargoService(ICargoRepositorio cargoservice) : base(cargoservice)
        {
            _cargoservice = cargoservice;
        }
    }
}
