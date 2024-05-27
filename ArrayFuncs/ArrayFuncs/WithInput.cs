using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFuncs
{
    public class WithInput
    {
        public void MinIndexWithInput()
        {
            string inputstr = Console.ReadLine();
            string[] inpputNumsarr = inputstr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] inputNums = Array.ConvertAll(inpputNumsarr, Convert.ToInt32);

            int[] NumsSort = new int[inputNums.Length];
            Array.Copy(inputNums, NumsSort, inputNums.Length);
            Array.Sort(NumsSort);

            int min = NumsSort[0];
            int minInd = Array.IndexOf(inputNums, min);


            Console.WriteLine(minInd);
        }

        public void AverageWithInput()
        {
            string inputstr = Console.ReadLine();
            string[] inpputNumsarr = inputstr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] inputNums = Array.ConvertAll(inpputNumsarr, Convert.ToInt32);

            int sum = inputNums.Sum();
            int average = sum / inputNums.Length;
            Console.WriteLine(average);
        }

        public void SimpleorComplexWithInput()
        {
            Console.WriteLine("Bosluqlarla elementleri daxil edin: ");
            string inputstr = Console.ReadLine();
            string[] inpputNumsarr = inputstr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] inputNums = Array.ConvertAll(inpputNumsarr, Convert.ToInt32);


            int[] simple = new int[0];
            int[] complex = new int[0];
            Array.ForEach(inputNums, x =>
            {
                bool isComplex = false;
                for (int i = 2; i < Math.Sqrt(Math.Abs(x)); i++)
                {
                    if (x % i == 0)
                    {
                        Array.Resize(ref complex, complex.Length + 1);
                        complex[complex.Length - 1] = x;
                        isComplex = true;
                        break;
                    }
                }
                if (!isComplex && x != 1)
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
    }
}
