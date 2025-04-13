using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject
{
    public enum UserCategory
    {
        Regular,
        Admin,
    }
    public class User
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public UserCategory Category { get; set; }
        public string SubscriptionType { get; set; }

        public void PrintInfo(bool showCategory = true, bool showSub = true) 
        {
            Console.WriteLine($"Name: {Fullname}");
            if (showCategory) Console.WriteLine($"Category: {Category}");
            if (showSub) Console.WriteLine($"Subscription: {SubscriptionType}");
        }

        public void AccessAdminPanel() 
        {
            if (Category == UserCategory.Admin)
                Console.WriteLine("Access granted to admin panel.");
            else
                Console.WriteLine("Access denied.");
        }
    }
}
