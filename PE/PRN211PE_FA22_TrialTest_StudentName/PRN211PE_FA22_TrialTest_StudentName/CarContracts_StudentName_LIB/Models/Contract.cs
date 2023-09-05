using System;
using System.Collections.Generic;

namespace CarContracts_StudentName_LIB.Models;

public partial class Contract
{
    public int ContractId { get; set; }

    public string? ContractCode { get; set; }

    public string? ContractName { get; set; }

    public DateTime? CreateDate { get; set; }

    public double Price { get; set; }

    public int CarId { get; set; }

    public virtual Car Car { get; set; } = null!;
}
