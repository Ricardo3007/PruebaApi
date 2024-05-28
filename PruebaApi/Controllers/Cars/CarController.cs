using Microsoft.AspNetCore.Mvc;
using PruebaApi.Aplicattion.Contracts.Cars;
using PruebaApi.Domain.Entities.Car;
using PruebaApi.DTO.Car;

namespace PruebaApi.Controllers.Cars
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : Controller
    {
        private readonly ICarsAppService _carsAppService;
        public CarController(ICarsAppService carsAppService) { 
            _carsAppService = carsAppService;
        }


        [HttpPost]
        [Route(nameof(CarController.GuardarMarca))]
        public string GuardarMarca(MarcaDto marca)
        {

            return _carsAppService.GuardarMarca(marca);

        }

        [HttpPost]
        [Route(nameof(CarController.GuardarCarro))]
        public string GuardarCarro(CarDto carroDTO)
        {

            return _carsAppService.GuardarCarro(carroDTO);

        }

        [HttpGet]
        [Route(nameof(CarController.getCars))]
        public string getCars()
        {

            return _carsAppService.GetCars();

        }




    }
}
