
using PruebaApi.DataAccess.Context;
using PruebaApi.Domain.Entities.Car;
using PruebaApi.Domain.Services.Contracts;

namespace PruebaApi.Domain.Services.Cars
{
    public class CarDomainService:ICarDomainService
    {
        private readonly CarContext _context;
        public CarDomainService(CarContext context)
        {
            _context = context;
        }


        public string GuardarMarca(Marca marca)
        {
            _context.Marca.Add(marca);
            _context.SaveChanges();

            return "OK";
        }


        public string GuardarCarro(Carro carro)
        {
            _context.Carro.Add(carro);
            _context.SaveChanges();

            return "OK";
        }

        public List<Carro> GetCars()
        {
            return _context.Carro.ToList();
        }

    }
}
