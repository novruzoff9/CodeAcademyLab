using System;
using System.Collections.Generic;

namespace LinQ.Models;

public partial class ProdcutSeafoodCategory
{
    public string ProductName { get; set; } = null!;

    public short? UnitsInStock { get; set; }

    public string CategoryName { get; set; } = null!;
}
