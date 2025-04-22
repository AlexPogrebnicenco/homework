using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace HomeworkProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your email:");
            string email = Console.ReadLine();
            Console.WriteLine($"You wrote: {email}");

            try
            {
                using (MailMessage message = new MailMessage())
                {
                    message.From = new MailAddress("pogrebnicencoalex@gmail.com");
                    message.To.Add(email);
                    message.Subject = "Thank you for subscribing!";
                    message.Body = "You have successfully subscribed to our Onlince-Course-App";

                    using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                    {
                        client.Credentials = new NetworkCredential("pogrebnicencoalex@gmail.com", "************");
                        client.EnableSsl = true;
                        client.Send(message);
                    }

                    Console.WriteLine("Message was sent");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Houston, we have a problem: " + ex.Message);
            }
        }
    }
}
