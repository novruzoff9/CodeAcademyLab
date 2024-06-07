namespace Extentions_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Int veri tipinde örnek
            int[] array = new int[] { 1, 2, 3 };
            System.Array.MyResize(ref array, 4, 2, 5, 7, 6);

            Console.WriteLine();
            //String veri tipinde örnek
            string[] arraystr = new string[] { "oncedeger1", "oncedeger2", "oncedeger3" };
            System.Array.MyResize(ref arraystr, "artirilandeger1", "artirilandeger2");
        }
    }
}
