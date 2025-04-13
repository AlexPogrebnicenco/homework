using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject
{
    public static class UserFactory
    {
       public static User CreateUser(int id, string name, UserCategory category, string subscription) 
        {
            return new User
            {
                Id = id,
                Fullname = name,
                Category = category,
                SubscriptionType = subscription
            };
        }
    }
}
