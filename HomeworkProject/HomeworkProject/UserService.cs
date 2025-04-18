using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkProject.Exceptions;

namespace HomeworkProject
{
    public static class UserService
    {
        public static void RegisterUser(string name, int age)
        {

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name can not be empty or a space.", nameof(name));
            }

            if (age < 0 || age > 120)
            {
                throw new ArgumentOutOfRangeException(nameof(age), "Age must be between 0 and 120.");
            }

            
            Console.WriteLine($"User Registration: {name}, age: {age}");
        }

        public static int ParseAge(string input) 
        {
            try
            {
                return int.Parse(input);
            }
            catch (FormatException ex)
            {
                throw new InvalidAgeException("Error in changing age. The format is invalid", ex);
            }
        }

        public static void HandleRegistration(string name, string inputAge)
        {
            try
            {
                int age = ParseAge(inputAge);
                RegisterUser(name, age);
            }
            catch (InvalidAgeException iae)
            {
                Console.WriteLine($"Age error from HandleRegistration: {iae.Message}");
                throw;
            }
        }
    }
}
