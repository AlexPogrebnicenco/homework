using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkProject.Models;
using HomeworkProject.Delegates;

namespace HomeworkProject.Extensions
{
    public static class UserExtensions
    {
        public static List<User> CustomFilter(this List<User> users, FilterDelegate filter)
        {
            var result = new List<User>();
            foreach (var user in users) 
            {
                if (filter(user))
                { 
                    result.Add(user);
                }    
            }
            return result;
        }
    }
}
