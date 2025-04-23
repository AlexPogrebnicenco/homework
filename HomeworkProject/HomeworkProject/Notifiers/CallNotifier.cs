using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkProject.Interfaces;

namespace HomeworkProject.Notifiers
{
    public class CallNotifier : INotifier, IPhoneNuber
    {
        private string _phoneNumber;
        public CallNotifier(string phoneNumber)
        {
            _phoneNumber = phoneNumber;
        }
        public void Send(string message, string recipient) 
        {
            Console.WriteLine($"Calling {_phoneNumber} : {message}");
        }
        public string GetPhoneNumber()
        {
            return _phoneNumber;
        }
    }
}
