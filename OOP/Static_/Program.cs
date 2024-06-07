using Static_.Models;

namespace Static_;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        FizikKutuphanesi fk = new FizikKutuphanesi();
        double res = FizikKutuphanesi.Pi * 3;
        Console.WriteLine(res);
    }
}
