namespace SwitchCaseExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string season = Console.ReadLine();
            Console.WriteLine("Switch Case Ile");
            WhichSeason(season);

            Console.WriteLine("Sade Switch Case Ile");
            WhichSeasonExp(season);

            Console.WriteLine("TermaryIf ile");
            Termary(season);
        }

        static void WhichSeason(string season)
        {
            string result = string.Empty;
            switch (season)
            {
                case "Spring":
                    result = "Yaz";
                    break;
                case "Summer":
                    result = "Yay";
                    break;
                case "Autmn":
                    result = "Payiz";
                    break;
                case "Winter":
                    result = "Qis";
                    break;
            }
            Console.WriteLine(result);
        }

        static void WhichSeasonExp(string season)
        {
            string result = string.Empty;
            string res = season switch
            {
                "Spring" => "Yaz",
                "Summer" => "Yay",
                "Autmn" => "Payiz",
                "Winter" => "Qis",
                _ => "Daxiletme duzgun deyil"
            };


            switch (season)
            {
                case "Spring":
                    result = "Yaz";
                    break;
                case "Summer":
                    result = "Yay";
                    break;
                case "Autmn":
                    result = "Payiz";
                    break;
                case "Winter":
                    result = "Qis";
                    break;
                default:
                    result = "Daxiletme duzgun deyil";
                    break;
            }
            Console.WriteLine(result);
            Console.WriteLine(res);
        }

        static void Termary(string season)
        {
            string result = season == "Spring" ? "Yaz" : season == "Summer" ? "Yay" : season == "Autmn" ?
                "Payiz" : season == "Winter" ? "Qis" : "Daxiletme yanlisdir";
            Console.WriteLine(result);
        }
    }
}
