using AutoMapper;
using PruebaApi.Aplicattion.Contracts.Cars;
using PruebaApi.Domain.Entities.Car;
using PruebaApi.Domain.Services.Contracts;
using PruebaApi.DTO.Car;

namespace PruebaApi.Aplicattion.Cars
{
    public class CarAppService : ICarsAppService
    {
        private readonly ICarDomainService _carDomainService;
        private readonly IMapper _Mapper;
        public CarAppService(ICarDomainService carDomainService, IMapper Mapper) {
            _carDomainService = carDomainService;
            _Mapper = Mapper;
        }

        public string GuardarMarca(MarcaDto marcaDTO)
        {
            
            Marca marca = _Mapper.Map<MarcaDto, Marca>(marcaDTO);
            return _carDomainService.GuardarMarca(marca);
        }

        public string GuardarCarro(CarDto carroDTO)
        {

            Carro carro = _Mapper.Map<CarDto, Carro>(carroDTO);
            return _carDomainService.GuardarCarro(carro);
        }

        public string GetCars()
        {
            return "hola"; // _carDomainService.GetCars();
        }
    }
}
