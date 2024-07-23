# Extension Method
---
```System.Array.MyResize()``` kullana bilmek için öncelikle Projenin ```<RootNamespace>``` alanını ```System``` olarak değiştiriyoruz. Daha sonra ```Array``` adında bir class açıp içine fonksiyon için gerekli kod bloğunu ekliyoruz.

> [!NOTE]
> Array sınıfı üzerinden kullandığımız için generic bir metot olarak oluşturmalıyız ki her bir veri tipiyle kullanıla bilsin

> [!NOTE]
> Metotun bir diğer Overload-ı sayesinde ```Array```-a eklenecek olan elemenların hangi indeksten başlayacağını bilerte biliyoruz
