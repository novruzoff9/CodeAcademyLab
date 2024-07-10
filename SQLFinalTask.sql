-- Çalışanların yapmış olduğu sipariş adedi (orders)  

select EmployeeID, COUNT(*) as [Siparis adedi] from Orders group by EmployeeID

-- Employees tablosundan; FirstName alanına göre, isimleri ASC olarak sıraladıktan sonra, sonuç kümesinin ilk beş kaydını ülkelerine göre gruplayınız.

select Country, COUNT(*) as [Calisan sayi] from 
	(Select top 5 * from Employees order by FirstName) as tbl 
	group by Country

-- Ürün bedeli 35$'dan az olan ürünlerin kategorilerine göre gruplanması

select CategoryID, Count(*) as [Urun sayı] from Products where UnitPrice < 35 group by CategoryID

-- Baş harfi A-K aralığında olan ve stok miktarı 5 ile 50 arasında olan ürünleri kategorilerine göre gruplayınız.

select CategoryID, COUNT(*) as [Secili urun sayı] from 
	Products where UnitsInStock between 5 and 50 and ProductName like '[A-K]%'
	group by CategoryID

-- Her bir siparişteki toplam ürün sayısını bulunuz.

select OrderID, Sum(Quantity) as [Urun sayi] from [Order Details] group by OrderID

-- Her bir siparişin tutarına göre listelenmesi

select OrderID, Sum(UnitPrice * Quantity) as [Siparis tutari] from [Order Details] group by OrderID

-- Toplam tutarı 2500 ile 3500 arasında olan siparişlerin gruplanması

select * from
	(select OrderID, Sum(UnitPrice * Quantity) as [Siparis tutari] 
	from [Order Details] 
	group by OrderID) as TotalPrice
	where [Siparis tutari] between 2500 and 3500

-- Her bir siparişteki toplam ürün sayısı 200'den az olanlar

select * from
(select OrderID, Sum(Quantity) as [Urun sayi] from [Order Details] group by OrderID) as tbl
where [Urun sayi] < 200