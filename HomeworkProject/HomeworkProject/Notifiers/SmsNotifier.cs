using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkProject.Interfaces;

namespace HomeworkProject.Notifiers
{
    public class SmsNotifier : INotifier, IPhoneNuber
    {
        private string _phoneNumber;

        public SmsNotifier(string phoneNumber) 
        {
            _phoneNumber = phoneNumber;
        }
        public void Send(string message, string recipient) 
        {
            Console.WriteLine($"SMS to {_phoneNumber} : {message}");
        }
        public string GetPhoneNumber()
        {
            return _phoneNumber;
        }
    }
}
