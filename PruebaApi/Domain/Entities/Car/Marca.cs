using System;
using System.Collections.Generic;

namespace PruebaApi.Domain.Entities.Car;

public partial class Marca
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Carro> Carro { get; set; } = new List<Carro>();
}
