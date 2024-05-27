
using ArrayFuncs;

int[] arr = { 0, 50, -11, 23, 18 };
WithInput action = new WithInput();
action.SimpleorComplexWithInput();


void minIndex(int[] arr)
{
    int[] arrsort = new int[5];
    Array.Copy(arr, arrsort, 5);
    Array.Sort(arrsort);

    int min = arrsort[0];
    int minInd = Array.IndexOf(arr, min);

    Console.WriteLine(minInd);
}

void Average(int[] arr)
{
    int sum = arr.Sum();
    int average = sum / arr.Length;
    Console.WriteLine(average);
}

void SimpleorComplex(int[] arr)
{
    int[] simple = new int[0];
    int[] complex = new int[0];
    Array.ForEach(arr, x =>
    {
        bool isComplex = false;
        for (int i = 2; i < Math.Sqrt(x); i++)
        {
            if(x%i == 0)
            {
                Array.Resize(ref complex, complex.Length + 1);
                complex[complex.Length - 1] = x;
                isComplex = true;
                break;
            }
        }
        if (!isComplex)
        {
            Array.Resize(ref simple, simple.Length + 1);
            simple[simple.Length - 1] = x;
        }
    });
    Console.WriteLine("Sade ededler");
    foreach (var item in simple)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
    Console.WriteLine("Murekkeb ededler");
    foreach (var item in complex)
    {
        Console.Write(item + " ");
    }
}