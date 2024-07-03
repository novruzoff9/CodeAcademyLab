using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMrPos.Models;

public interface IFood
{
    string GetName();

    void Preapearing();
}
