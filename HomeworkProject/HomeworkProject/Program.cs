using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Write your email address: "); 
            string email = Console.ReadLine();

            await EmailService.SendEmailAsync(email);

            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
