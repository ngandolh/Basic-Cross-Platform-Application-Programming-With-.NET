using System;
using System.Collections.Generic;

namespace CarContracts_StudentName_LIB.Models;

public partial class Car
{
    public int CarId { get; set; }

    public string? CarName { get; set; }

    public string? Color { get; set; }

    public virtual ICollection<Contract> Contracts { get; } = new List<Contract>();
}
