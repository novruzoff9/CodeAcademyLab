using Polymorphism_.Models;
using Task.Models;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Books
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();
            Book book5 = new Book();

            book1.Name = "Qumarbaz";
            book1.Price = 12.59;
            book1.AuthorName = "Dastoyovski";
            book1.Code = "Q1485";
            book1.PageCount = 574;

            book2.Name = "Cinayet ve Ceza";
            book2.Price = 8.19;
            book2.AuthorName = "Dastoyovski";
            book2.Code = "C485";
            book2.PageCount = 345;

            book3.Name = "Mavi Qatar";
            book3.Price = 5.23;
            book3.AuthorName = "Aqata Kristi";
            book3.Code = "M312";
            book3.PageCount = 128;

            book4.Name = "1984";
            book4.Price = 5.23;
            book4.AuthorName = "George Orwell";
            book4.Code = "G34";
            book4.PageCount = 128;

            book5.Name = "Ayı ve Şir";
            book5.Price = 1.29;
            book5.AuthorName = "Semed Vurğun";
            book5.Code = "A879";
            book5.PageCount = 16;
            #endregion


            Library library = new Library();

            Library.AddBook(book1);
            Library.AddBook(book2);
            Library.AddBook(book3);
            Library.AddBook(book4);
            Library.AddBook(book5);

            //Console.WriteLine(Library.FindAllBooks("Dastoyovski"));

            Console.WriteLine(Library.ReadBooks());

            List<Book> order = new();

            Console.WriteLine();
            Console.WriteLine("Sifaris vermek istediyiniz kitablarin kodunu daxil edin:\n" +
                "Sifarisi bitimerk ucun '0' deyerini daxil edin\n");

            while (true)
            {
                string bookcode = Console.ReadLine();
                if(bookcode.Length <= 1)
                {
                    break;
                }
                Book orderbook = Library.GetByCode(bookcode);
                if(orderbook == null)
                {
                    Console.WriteLine("Daxil etdiyiniz kod yanlisdir");
                    continue;
                }
                order.Add(orderbook);
                Console.WriteLine($"Hazirki umumi mebleg: {Order.OrderAmount(order)}");
            }
            Console.WriteLine($"Sifarisiniz ugurla tamamlandi.\nHesab : {Order.OrderAmount(order)}");

            Order.CompleteOrder(order);
            Console.WriteLine();

            Order.ShowOrders();

            //Console.WriteLine(book1);
        }
    }
}
