using PruebaApi.Domain.Entities.Car;
using PruebaApi.DTO.Car;

namespace PruebaApi.Aplicattion.Contracts.Cars
{
    public interface ICarsAppService
    {
        string GuardarMarca(MarcaDto marca);

        string GuardarCarro(CarDto carroDTO);
        string GetCars();

    }
}
