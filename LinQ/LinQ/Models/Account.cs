using System;
using System.Collections.Generic;

namespace LinQ.Models;

public partial class Account
{
    public int AccountId { get; set; }

    public string? AccountNo { get; set; }

    public string? AccountHolderName { get; set; }

    public decimal? Balance { get; set; }
}
