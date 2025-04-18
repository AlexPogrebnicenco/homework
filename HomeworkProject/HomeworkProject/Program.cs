using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HomeworkProject.Exceptions;

namespace HomeworkProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Registration Start===");
#if DEBUG
            Console.WriteLine("DEBUG Program is working in debug mode");
#endif
            UserService.RegisterUser("Alexandru", 27);
            Console.WriteLine("===Registration End===");

            //Console.WriteLine("===Registration Start===");
            //UserService.RegisterUser("", -5);
            //Console.WriteLine("===Registration End===");

            Console.WriteLine("===Testing ParseAge===");

            try
            {
                //string name = "";                                               // --- Uncomment for Testing ParseAge
                //string input = "abcd";                                          // --- Uncomment for Testing ParseAge
                //int age = UserService.ParseAge(input);                          // --- Uncomment for Testing ParseAge
                //UserService.RegisterUser(name, age);                            // --- Uncomment for Testing ParseAge
                //Console.WriteLine($"Age was successfully transformed: {age}");  // --- Uncomment for Testing ParseAge

                // Testing HandleRegistration 
                UserService.HandleRegistration("", "efgh");
            }
            catch (InvalidAgeException iae)
            {
                Console.WriteLine($"Age exception: {iae.Message}");
                Console.WriteLine($"Original exception: {iae.InnerException?.Message}");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine($"Argument exception: {ae.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally worked");
            }

        }
    }
}
