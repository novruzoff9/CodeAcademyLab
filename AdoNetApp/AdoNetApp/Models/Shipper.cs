using AdoGenericService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetApp.Models;

public class Shipper : BaseEntity
{ 
    public int ShipperID { get; set; } 
    public string CompanyName { get; set; } = null!; 
    public string? Phone { get; set; } 
}
