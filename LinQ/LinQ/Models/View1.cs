using System;
using System.Collections.Generic;

namespace LinQ.Models;

public partial class View1
{
    public string CategoryName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? Title { get; set; }

    public short Quantity { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? ContactName { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal UnitPrice { get; set; }
}
