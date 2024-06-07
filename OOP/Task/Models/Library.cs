using Polymorphism_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task.Models;

public class Library
{
    public static List<Book> Books = new List<Book>();

    public static void AddBook(Book book)
    {
        Books.Add(book);
    }

    /// <summary>
    /// Butun Kitablari goster
    /// </summary>
    /// <returns></returns>
    public static string ReadBooks()
    {
        string result = string.Empty;
        Console.WriteLine("Kitabaxanada movcud olan kitablar:\n");
        foreach (Book book in Books)
        {
            Console.WriteLine(book);
        }
        return result;
    }

    /// <summary>
    /// Secilmis kitablari goster
    /// </summary>
    /// <param name="selectedbooks">Secilmis kitablar</param>
    /// <returns></returns>
    public static string ReadBooks(List<Book> selectedbooks)
    {
        string result = string.Empty;
        foreach (Book book in selectedbooks)
        {
            result += book.ToString() + '\n';
        }
        return result;
    }

    public static Book GetBook(string name)
    {
        return Books.Find(x => x.Name == name);
    }
    public static Book GetByCode(string code)
    {
        return Books.Find(x => x.Code == code);
    }


    public static List<Book> FindAllBooks(string Author)
    {
        return Books.FindAll(x => x.AuthorName == Author);
    }

    public static int RemoveAllBooks(string Code) 
    {
        int count = Books.Count(x => x.Code == Code);
        Books.RemoveAll(x => x.Code == Code);

        return count;
    }
}
