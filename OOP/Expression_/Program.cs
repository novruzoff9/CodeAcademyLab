using Expression_.Models;
using System.Linq.Expressions;

Expression<Func<string, string>> clearText = x => x.ToLower().Replace("?", "").Replace("!", "").Replace("$", "")
.Replace("[", "").Replace("]", "").Replace("*", "").Replace("#", "").Replace("/", "");

Expression<Func<Employee, string>> capitalize = x => x.FirstName.ToUpper().Substring(0, 1) + x.FirstName.ToLower().Substring(1);

Expression<Func<Employee, string>> lastName = x => x.LastName.ToUpper();

Expression<Func<Employee, string>> createMail = x => $"{clearText.Compile()(x.FirstName.Trim().ToLower())}.{clearText.Compile()(x.LastName.Trim().ToLower())}@hotmail.com";

var users = new List<Employee> {
    new Employee { FirstName = "AdiL", LastName = "qulIYev", Age = 17},
    new Employee { FirstName = "AyXAn", LastName = "Kerimov", Age = 19},
    new Employee { FirstName = "muRad", LastName = "dadAsoV", Age = 18},
    new Employee { FirstName = "TurAL", LastName = "MemMeDov", Age = 19},
    new Employee { FirstName = "oMer", LastName = "qul??$#iev", Age = 20},
};

var vaResult = users.AsQueryable().Select(x => new {
    FirstName = capitalize.Compile()(x),
    LastName = lastName.Compile()(x),
    Email = createMail.Compile()(x),
}).ToList();

foreach (var item in vaResult)
{
    Console.WriteLine(item);
}