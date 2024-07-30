using AdoGenericService.Services;
using AdoNetApp.Models;
using AdoNetApp.Services;

ConfigurationService.Configure();

Service<Category> catservice = new();
Service<Shipper> shipservice = new Service<Shipper>();

await catservice.Add(new Category { CategoryName = "Trends", Description = "en trendler" });
//shipservice.Add(new Shipper { CompanyName = "Novruzoff Com."});

//catservice.Update(new Category { CategoryName = "Top" });
