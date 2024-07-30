using AdoGenericService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetApp.Models;

public class Category : BaseEntity {
    [PrimaryKey]
    public int CategoryID { get; set; } 
    public string CategoryName { get; set; } = null!; 
    public string? Description { get; set; } 
}
