using System;
using System.Collections.Generic;

namespace PruebaApi.Domain.Entities.Car;

public partial class Carro
{
    public int Id { get; set; }

    public string? Modelo { get; set; }

    public string? Descripcion { get; set; }

    public int? Precio { get; set; }

    public int? Kilometraje { get; set; }

    public int? Marca { get; set; }

    public virtual Marca? MarcaNavigation { get; set; }
}
