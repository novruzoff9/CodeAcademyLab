using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ.Helpers;

public static class ListToTabel
{
    public static void Generateatable<T>(List<T> table)
    {
        var generictable = new Table();
        generictable.BorderColor(Color.Red);
        generictable.Border(TableBorder.Ascii);

        foreach (var property in typeof(T).GetProperties())
        {
            if (property.PropertyType.ToString() != "System.Collections.Generic.ICollection`1[DbFirstApp.Models.Product]" && property.PropertyType.ToString() != "System.Byte[]")
                generictable.AddColumn(property.Name);
        }


        foreach (var item in table)
        {
            string addrow = "";
            foreach (var property in typeof(T).GetProperties())
            {
                if (!property.PropertyType.ToString().StartsWith("System.Collections.Generic.ICollection") && property.PropertyType.ToString() != "System.Byte[]")
                    addrow += $"{property.GetValue(item)}->";


            }
            addrow = addrow.Remove(addrow.Length - 2);
            generictable.AddRow(addrow.Split("->"));
        }

        AnsiConsole.Write(generictable);
    }
}
