using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.Oops
{
    internal class Records
    {
        static void Main()
        {
            Console.WriteLine("=== Basic Record ===");

            CustomerProfile customer = new CustomerProfile
            {
                Id = 101,
                FullName = "Kaviprakash"
            };

            Console.WriteLine(
                $"Id: {customer.Id}, Name: {customer.FullName}");



            Console.WriteLine("\n=== Positional Record ===");

            BookInfo book =
                new BookInfo("Clean Code", "Robert Martin");

            Console.WriteLine(book.Title);
            Console.WriteLine(book.Author);



            Console.WriteLine("\n=== Value-Based Equality ===");

            BookInfo book1 =
                new BookInfo("The Pragmatic Programmer", "Andrew Hunt");

            BookInfo book2 =
                new BookInfo("The Pragmatic Programmer", "Andrew Hunt");

            Console.WriteLine(book1 == book2); // True



            Console.WriteLine("\n=== Non-Destructive Mutation ===");

            BookInfo updatedBook =
                book with { Title = "Clean Architecture" };

            Console.WriteLine(book);
            Console.WriteLine(updatedBook);



            Console.WriteLine("\n=== Immutable Properties ===");

            CustomerProfile profile = new CustomerProfile
            {
                Id = 102,
                FullName = "Sophia"
            };

            Console.WriteLine(profile);



            Console.WriteLine("\n=== Record Inheritance ===");

            PaymentRequest request =
                new CardPaymentRequest(
                    5000,
                    "1234-5678-9012-3456");

            Console.WriteLine(request);

        }
    }

    // 1. Basic Record
    public record CustomerProfile
    {
        public int Id { get; init; }
        public string FullName { get; init; }
    }

    // 2. Positional Record
    public record BookInfo(string Title, string Author);

    // 6. Record Inheritance
    public record PaymentRequest(decimal Amount);

    public record CardPaymentRequest(
        decimal Amount,
        string CardNumber)
        : PaymentRequest(Amount);
}
