create proc sp_addcat
@name nvarchar(15),
@desc ntext
as
if exists (select * from Categories where CategoryName = @name)
  begin
    update Categories set Description = @desc where CategoryID = (select CategoryID from Categories where CategoryName = @name)
  end
else
  begin
    insert into Categories (CategoryName, Description) values(@name, @desc)
  end

execute sp_addcat 'dsad', 'Bos category'

select * from Categories


-- sp_add_product 'Coca cola', 12, 30 ,'Kola'
select * from Products

alter proc sp_add_product
@prname nvarchar(40),
@price money,
@stock smallint,
@category nvarchar(15)
as
if EXISTS (select * from Categories where CategoryName = @category)
begin
	insert into Products (ProductName, UnitPrice, UnitsInStock, CategoryID) values
	(@prname, @price, @stock, (select CategoryID from Categories where CategoryName = @category))
end
else
begin
	insert into Categories (CategoryName) values (@category) 

	insert into Products (ProductName, UnitPrice, UnitsInStock, CategoryID) values
	(@prname, @price, @stock, SCOPE_IDENTITY())
end

select * from Categories
select * from Products
execute sp_add_product 'Coca Cola', 12, 30 ,'Serin Icki'