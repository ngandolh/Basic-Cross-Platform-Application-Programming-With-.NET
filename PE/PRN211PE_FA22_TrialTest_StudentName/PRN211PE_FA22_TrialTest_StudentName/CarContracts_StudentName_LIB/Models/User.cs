using System;
using System.Collections.Generic;

namespace CarContracts_StudentName_LIB.Models;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string? Password { get; set; }

    public string? UserName { get; set; }

    public int? UserRole { get; set; }
}
