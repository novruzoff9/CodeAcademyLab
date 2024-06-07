using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_.Models;

public class Book
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public int PageCount { get; set; }
    public double Price { get; set; }

    public override string ToString()
    {
        return $"{this.Code} :\n{this.AuthorName} - {this.Name} - {this.PageCount} sehife " +
            $"Qiymet: {this.Price}";
    }
}
