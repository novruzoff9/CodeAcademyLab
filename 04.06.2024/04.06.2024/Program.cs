namespace _04._06._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dairenin radisunu daxil edin: ");
            int rad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dairenin sahesi: ");
            Console.WriteLine(CalcArea(rad));

            Console.WriteLine("Ucbucagin ilk katetini daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ucbucagin 2ci katetini daxil edin");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Duzbucaqli ucbucagin sahesi: ");
            Console.WriteLine(CalcArea(a,b));
        }


        /// <summary>
        /// Dairenin sahesini hesablayin
        /// </summary>
        /// <param name="r">Dairenin radusu</param>
        static double CalcArea(int r)
        {
            return Math.PI * r * r;
        }

        /// <summary>
        /// Duzbucaqlu Ucbucaq
        /// </summary>
        /// <param name="a">Ilk katetin olcusu</param>
        /// <param name="b">Ikinci katetin olcusu</param>
        static double CalcArea(int a, int b)
        {
            return a * b / 2;
        }
    }
}