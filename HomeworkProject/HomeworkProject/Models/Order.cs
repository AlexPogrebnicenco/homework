using System;

namespace HomeworkProject.Models
{
    public class Order : BaseNotifier
    {
        public string BookTitle { get; }
        public string CustomerName { get; }
        public Order(string bookTitle, string customerName)
        {
            BookTitle = bookTitle;
            CustomerName = customerName;
        }
        public void Place()
        {
            Console.WriteLine($"System ---> Order placed: {BookTitle} by {CustomerName}");
            Notify($"Order placed: {BookTitle} by {CustomerName}");
        }
        public void ReadyForShipping()
        {
            Console.WriteLine($"System ---> Order ready for shipping: {BookTitle}");
            Notify($"Order - {BookTitle} for {CustomerName} is ready for shipping");
        }

    }
}
