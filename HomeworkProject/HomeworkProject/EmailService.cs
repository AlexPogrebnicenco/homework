using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace HomeworkProject
{
    public static class EmailService
    {
        public static async Task SendEmailAsync(string recipientEmail)
        {
            try
            {
                using (MailMessage message = new MailMessage())
                {
                    message.From = new MailAddress("pogrebnicencoalex@gmail.com");
                    message.To.Add(recipientEmail);
                    message.Subject = "Thank you for subscribing!";
                    message.Body = "You have successfully subscribed to our Online-Course-App";

                    using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                    {
                        client.Credentials = new NetworkCredential("pogrebnicencoalex@gmail.com", "**********");
                        client.EnableSsl = true;
                        client.Send(message);
                    }

                    Console.WriteLine("Message was sent");
                    await Logger.LoggerAsync("SendEmailAsync", true);
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Houston we have a problem: " + ex.Message);
                await Logger.LoggerAsync("SendEmailAsync", false);
            }
        }
    }
}
