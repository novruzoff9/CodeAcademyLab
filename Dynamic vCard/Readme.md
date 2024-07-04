# Dynamic vCard

```Randomuser.me``` API-dan random istifadəçi məlumatları çəkərək onlar üçün dinamik vCard-lar hazırlayır.

### Deserialize
Məlumatları gətirmək  üçün```HttpClient``` istifadə edilərək məlumatlar Json formatına gətirilir. Gətirilən məlumatın property-lərinə uyğun yaradılan ```vCard``` sinifinə deserialize edilməsi üçün isə [Newtonsoft](https://www.newtonsoft.com/json) package-dən istifadə edirik.

### Save
Daha sonra məlumat ```.vcf``` formatına uyğun hazırlanır və ```Environment.UserName``` funksiyası isifadə olunaraq hazırki istifadəçi adını alır və onun işmasasına vCard-ı save edir.

### Error Handling
 - Sistemin çox yüklənməməsi üçün istifadəçiyə çağırış üçün 1000 limit qoyulur.
 - 20000 request limitinə çatdıqda müvəqqəti gözləmə verir