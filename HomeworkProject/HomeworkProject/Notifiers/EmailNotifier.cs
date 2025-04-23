using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkProject.Interfaces;

namespace HomeworkProject.Notifiers
{
    public class EmailNotifier : INotifier
    {
        public void Send(string message, string recipient)
        {
            Console.WriteLine($"Email to {recipient} : {message}");
        }
    }
}
