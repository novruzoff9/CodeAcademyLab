using Dynamic_vCard.Models;
using Newtonsoft.Json;
using System.Text;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Dynamic_vCard;

public class Program
{
    static async Task Main(string[] args)
    {
        var vCardResult = await GetandDeserializeAsync();

        List<VCard> vCards = new List<VCard>();

        foreach (var result in vCardResult.results)
        {
            VCard vCard = new VCard
            {
                Id = result.login.uuid,
                FirstName = result.name.first,
                LastName = result.name.last,
                Email = result.email,
                Phone = result.phone,
                Country = result.location.country,
                City = result.location.city
            };

            vCards.Add(vCard);
        }

        await SavevCardsAsync(vCards);
    }

    /// <summary>
    /// RandomUser.me-dən məlumatların gətirilib deserialize olunması
    /// </summary>
    /// <returns>Deserialize edilmiş məlumatlar</returns>
    public static async Task<dynamic> GetandDeserializeAsync()
    {
        using HttpClient client = new HttpClient();
        Console.WriteLine("Yaratmaq istədiyiniz istifadəçi sayını daxil edin: ");
        int count = Convert.ToInt32(Console.ReadLine());
        using HttpResponseMessage response = await client.GetAsync($"https://randomuser.me/api/?results={count}");

        var jsondata = await response.Content.ReadAsStringAsync();

        var vCardResult = JsonConvert.DeserializeObject<dynamic>(jsondata);

        return vCardResult;
    }

    /// <summary>
    /// Əldə olunmuş vCard məlumat(lar)ının .vcf faylına çevrilib saxlanılması 
    /// </summary>
    /// <param name="vCards">İstifadəçi məlumatları</param>
    /// <returns></returns>
    public static async Task SavevCardsAsync(List<VCard> vCards)
    {
        string userName = Environment.UserName;  // Olduğumuz isfadəçinin desktop-una yazdırmaq üçün onun username-ni alırıq
        string vCardsDirectory = $"C:\\Users\\{userName}\\Desktop\\";


        foreach (var vCard in vCards)
        {
            string vcfContent = $"BEGIN:VCARD\r\n" +
                                $"VERSION:3.0\r\n" +
                                $"FN:{vCard.FirstName} {vCard.LastName}\r\n" +
                                $"N:{vCard.LastName};{vCard.FirstName};;;\r\n" +
                                $"EMAIL;TYPE=INTERNET:{vCard.Email}\r\n" +
                                $"TEL;TYPE=WORK:{vCard.Phone}\r\n" +
                                $"ADR;TYPE=HOME;LABEL=\"{vCard.City}, {vCard.Country}\"\r\n" +
                                $"END:VCARD\r\n";



            string fileName = $"{vCard.FirstName}_{vCard.LastName}.vcf";
            string filePath = Path.Combine(vCardsDirectory, fileName);

            await File.WriteAllTextAsync(filePath, vcfContent, Encoding.UTF8);

            Console.WriteLine($"Yaradılan vCard faylının ünvanı: {filePath}");
        }
    }
}
