

using PruebaApi.Domain.Entities.Car;
using PruebaApi.DTO.Car;

namespace PruebaApi.Domain.Services.Contracts
{
    public interface ICarDomainService
    {
        //List<PruebaApi.Domain.Entities.Car.Cars> GetCars();

        string GuardarMarca(Marca marca);
        string GuardarCarro(Carro carro);

        List<Carro> GetCars();

    }
}
