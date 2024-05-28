using AutoMapper;
using PruebaApi.Domain.Entities.Car;
using PruebaApi.DTO.Car;

namespace PruebaApi.Automapper.Car
{
    public class CarMapper:Profile
    {
        public CarMapper() {
            CreateMap<Marca, MarcaDto>()
                  .ForMember(dest => dest.IdDTO, opt => opt.MapFrom(orig => orig.Id))
                  .ForMember(dest => dest.NombreMarcaDTO, opt => opt.MapFrom(orig => orig.Nombre))
                  .ReverseMap();

            CreateMap < Carro, CarDto>()
                .ForMember(dest => dest.IdDTO, opt => opt.MapFrom(orig => orig.Id))
                .ForMember(dest => dest.ModeloDTO, opt => opt.MapFrom(orig => orig.Modelo))
                .ForMember(dest => dest.DescripcionDTO, opt => opt.MapFrom(orig => orig.Descripcion))
                .ForMember(dest => dest.PrecioDTO, opt => opt.MapFrom(orig => orig.Precio))
                .ForMember(dest => dest.KilometrajeDTO, opt => opt.MapFrom(orig => orig.Kilometraje))
                .ForMember(dest => dest.MarcaDTO, opt => opt.MapFrom(orig => orig.Marca))
                .ReverseMap();

        }

    }
}
