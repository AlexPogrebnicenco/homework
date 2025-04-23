using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkProject.Interfaces;
using HomeworkProject.Notifiers;
using HomeworkProject.Services;

namespace HomeworkProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<INotifier> notifiers = new List<INotifier>()
            {
                new EmailNotifier(),
                new SmsNotifier("069123456"),
                new PushNotifier(),
                new CallNotifier("069123456")
            };

            NotificationService notificationService = new NotificationService(notifiers);

            Console.Write("Write your message: ");
            string message = Console.ReadLine();

            Console.Write("Write recipient: ");
            string recipient = Console.ReadLine();

            notificationService.NotifyAll(message, recipient);
            Console.WriteLine($"Notifications were sent.");
            Console.ReadKey();
        }
    }
}
