namespace Out_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dairenin radisunu daxil edin: ");
            int rad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dairenin sahesi");
            double circlearea;
            CalcArea(rad, out circlearea);
            Console.WriteLine(circlearea);
            Console.WriteLine();

            Console.WriteLine("Ucbucagin ilk katetini daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ucbucagin 2ci katetini daxil edin");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Duzbucaqli ucbucagin sahesi");
            double triarea;
            CalcArea(a, b, out triarea);
            Console.WriteLine(triarea);
        }

        /// <summary>
        /// Dairenin sahesini hesablayin
        /// </summary>
        /// <param name="r">Dairenin radusu</param>
        static void CalcArea(int r, out double area)
        {
            area = Math.PI * r * r;
        }

        /// <summary>
        /// Duzbucaqlu Ucbucaq
        /// </summary>
        /// <param name="a">Ilk katetin olcusu</param>
        /// <param name="b">Ikinci katetin olcusu</param>
        static void CalcArea(int a, int b, out double area)
        {
            area = a * b / 2;
        }
    }
}
