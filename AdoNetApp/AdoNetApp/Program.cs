using AdoGenericService.Services;
using AdoNetApp.Models;

namespace AdoNetApp;

internal class Program
{
    static void Main(string[] args)
    {

        Service<Category> catservice = new Service<Category>();
        Service<Shipper> shipservice = new Service<Shipper>();

        catservice.Add(new Category { CategoryName = "Trends"});
        shipservice.Add(new Shipper { CompanyName = "Novruzoff Com."});

        catservice.Update(new Category { CategoryName = "Top" });
    }
}
