using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HomeworkProject
{
    public class Program
    {
        enum Status
        {
            New,
            InProgress,
            Done,
            Cancelled
        }

        static void Main(string[] args)
        {
            ListInitDemo();
            ListResizeDemo();
            tryEnum();

            int newValue  = (int)Status.InProgress;
            Console.WriteLine($"newValue: {newValue}");
            Status sss = (Status)2;
            int length = Enum.GetNames(typeof(Status)).Length;
            Console.WriteLine( newValue > length  ? "There is no such STATUS" : $"Statuscode is  : {newValue}");

            Console.ReadLine();

        }

        private static void ListInitDemo()
        {
            List<string> names = new List<string>();
            names.Add("John");
            names.Add("Peter");
            names.Add("Jack");
            names.Add("George");
            names.Add("Tom");

            List<string> items = new List<string> {"Valera", "Sanea", "Vasea", "Petea", "Andrey"};
            foreach (string item in names) 
            {
                Console.WriteLine(item);
            }
        }

        private static void ListResizeDemo()
        {
            //List<int> listOfIntegers = new List<int>();
            //int currentCapacity = listOfIntegers.Capacity;

            //for (int i = 0; i < 1_000; i++)
            //{
            //    listOfIntegers.Add(i);
            //    if (currentCapacity != listOfIntegers.Capacity)
            //    {
            //        currentCapacity = listOfIntegers.Capacity;
            //        Console.WriteLine($"List1 capacity was increased to {currentCapacity}");
            //    }    
            //}

            //List<int> listOfIntegers2 = new List<int>(1_000_000);
            //int currentCapacity = listOfIntegers2.Capacity;
            //for (int i = 0; i < 1_000_000; i++)
            //{
            //    listOfIntegers2.Add(i);
            //    if (currentCapacity != listOfIntegers2.Capacity)
            //    {
            //        currentCapacity = listOfIntegers2.Capacity;
            //        Console.WriteLine($"List2 capacity was increased to {currentCapacity}");
            //    }
            //}


            //List<int> listOfIntegers3 = new List<int>();
            //Console.WriteLine($"List3 capacity before AddRange = {listOfIntegers3.Capacity}");
            //listOfIntegers3.AddRange(listOfIntegers2);
            //Console.WriteLine($"List3 capacity after AddRange = {listOfIntegers3.Capacity}");
            //listOfIntegers3.RemoveRange(0, listOfIntegers2.Count);
            //Console.WriteLine($"List3 capacity after RemoveRange {listOfIntegers3.Capacity}");
            //listOfIntegers3.TrimExcess();
            //Console.WriteLine($"List3 capacity after TrimExcess = {listOfIntegers3.Capacity}" );

            //var capitals = new Dictionary<string, string>()
            //{
            //    {"Romania", "Bucurest"},
            //    {"Ukrain", "Kiev"},
            //    {"Russia", "Moscow"}
            //};
            //capitals.Add("France", "Paris");
            //capitals.Add("Germany", "Berlin");
            //capitals.Add("Moldova", "Chisinau");

            //foreach (var pair in capitals)
            //{
            //    Console.WriteLine($"Country: {pair.Key}   Capital: {pair.Value}");
            //}
        }

        public static void tryEnum() 
        {
            Status taskStatus = Status.InProgress;

            switch (taskStatus)
            {
                case Status.New:
                    Console.WriteLine("Task not started.");
                    break;
                case Status.InProgress:
                    Console.WriteLine("Task is underway.");
                    break;
                case Status.Done:
                    Console.WriteLine("Task completed!");
                    break;
                case Status.Cancelled:
                    Console.WriteLine("Task was cancelled.");
                    break;
            }
         }
    }
}
