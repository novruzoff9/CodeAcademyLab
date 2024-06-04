
oddandEvenarrs();

#region ForTasks
void minandMax()
{
    Console.WriteLine("Dizi olcusunu girin: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];
    int min = int.MaxValue;
    int max = int.MinValue;
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Dizinin elemanini girin ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }

    Console.WriteLine(min + " " + max);
}

void OddandEvens()
{
    Console.WriteLine("Dizi olcusunu girin: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];
    int odds = 0;
    int evens = 0;
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Dizinin elemanini girin ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        if (arr[i] % 2 == 0) evens += 1;
        if (arr[i] % 2 == 1) odds += 1;
    }

    Console.WriteLine("Tekler" + odds + " Cutler" + evens);
}

void sumOfElements()
{
    Console.WriteLine("ededi daxil edin daxil edin: ");
    string n = Console.ReadLine();
    int sum = 0;
    for (int i = 0; i < n.Length; i++)
    {
        int a = Convert.ToInt32(n[i]);
        sum += a;
    }
    Console.WriteLine(sum);
}

void DrawSquare()
{
    Console.WriteLine("Kvadratin olcusunu daxil edin: ");
    int x = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < x; j++)
        {
            Console.Write("X");
        }
        Console.WriteLine();
    }
}

void DrawTriangle()
{
    Console.WriteLine("Ucbucagin katet olcusunu daxil edin: ");
    int x = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < x; j++)
        {
            if (i >= j) Console.Write("X");
        }
        Console.WriteLine();
    }
}

void SquarePerimeter()
{
    Console.WriteLine("Kvadratin olcusunu daxil edin: ");
    int x = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < x; j++)
        {
            if (i == 0 || i == x - 1 || j == 0 || j == x - 1) Console.Write("X");
            else Console.Write(" ");
        }
        Console.WriteLine();
    }
}

void MultiplySquare()
{

    int x = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < x; j++)
        {
            Console.WriteLine(i + " * " + j + " = " + i * j);
        }
    }
}

void FindRandom()
{
    int rand = Random.Shared.Next(8);
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Ededi texmin edin: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n == rand)
        {
            Console.WriteLine("Dogru tapdiniz!");
            break;
        }
        else if (i == 2)
        {
            Console.WriteLine("Haqqiniz bitdi!");
        }
        else
        {
            Console.WriteLine("Cavab yanlisdir. Sizin {0} haqqiniz qaldi", 2 - i);
        }
    }
}
#endregion

#region ForeachTasks
void hem2hem3()
{
    Console.WriteLine("Dizi olcusunu girin: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Dizinin elemanini girin ");
        arr[i] = Convert.ToInt32(Console.ReadLine());

    }
    foreach (var item in arr)
    {
        if (item % 6 == 0) count++;
    }
    Console.WriteLine("hem 2 hem de 3e bolunenler {0} saydadir", count);
}

void oddandEvenarrs()
{
    Console.WriteLine("Dizi olcusunu girin: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];
    int count = 0;
    int[] odds = new int[0];
    int[] evens = new int[0];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Dizinin elemanini girin ");
        arr[i] = Convert.ToInt32(Console.ReadLine());

    }
    foreach (var item in arr)
    {
        if (item % 2 == 0)
        {
            Array.Resize(ref evens, evens.Length + 1);
            evens[evens.Length - 1] = item;
        }
        else
        {
            Array.Resize(ref odds, odds.Length + 1);
            odds[odds.Length - 1] = item;
        }
    }

    Console.WriteLine("Tek ededler");
    foreach (var item in odds)
    {
        Console.Write(item + " ");
        Console.WriteLine();
        Console.WriteLine("Elementlerin cemi {}-dir", odds.Sum());
    }
    Console.WriteLine("Cut ededler");
    foreach (var item in evens)
    {
        Console.Write(item + " ");
        Console.WriteLine();
        Console.WriteLine("Elementlerin cemi {}-dir", odds.Sum());
    }

}
#endregion

#region WhileTask
void randomizer()
{
    int n = 0;
    Console.WriteLine("1 ile 6 arasi bir eded girin");
    n = Convert.ToInt32(Console.ReadLine());
    while (n > 6 || n < 1)
    {
        Console.WriteLine("1 ile 6 arasi bir eded girin");
        n = Convert.ToInt32(Console.ReadLine());
    }
    int[] arr = new int[n];
    int i = 0;
    while (n > 0)
    {
        
        int rand = Random.Shared.Next(1, 49);
        while (arr.Contains(rand))
        {
            rand = Random.Shared.Next(1, 49);
        }
        arr[i] = rand;
        i++;
        n--;
    }
    Console.WriteLine("Alinan coxlug");
    foreach (var item in arr)
    {
        Console.Write(item + " ");
    }
}
#endregion

#region DoWhile
void CoorectLogin()
{
    string username = "admin";
    string password = "1234";

    string loginuser = "";
    string loginpass = "";
    do
    {
        Console.WriteLine("Username daxkil edin: ");
        loginuser = Console.ReadLine();
        Console.WriteLine("Password daxkil edin: ");
        loginpass = Console.ReadLine();
    } while (loginpass != password && loginuser != username);

    Console.WriteLine("Tebrikler ugurla daxil oldunuz!");
}
#endregion