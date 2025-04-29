using System;
using HomeworkProject.Models;

namespace HomeworkProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (order1, order2, customer1, staff1) = CreateOrdersAndSubscribers();

            SubscribeToOrders(order1, order2, customer1, staff1);

            PlaceOrders(order1, order2);

            ShipOrders(order1, order2);

            UnsubscribeCustomer(order1, customer1);

            TestShippingAfterUnsubscribe(order1);

        }

        private static (Order, Order, Customer, Staff) CreateOrdersAndSubscribers()
        {
            var customer1 = new Customer("Alex");
            var customer2 = new Customer("Max");
            var staff1 = new Staff("John");

            var order1 = new Order("Harry Potter", "Alex");
            var order2 = new Order("Fight Club", "Max");

            return (order1, order2, customer1, staff1);
        }

        private static void SubscribeToOrders(Order order1, Order order2, Customer customer1, Staff staff1)
        {
            order1.Subscribe(customer1);
            order1.Subscribe(staff1);

            var customer2 = new Customer("Max");
            order2.Subscribe(customer2);
            order2.Subscribe(staff1);
        }

        private static void PlaceOrders(Order order1, Order order2)
        {
            order1.Place();
            order2.Place();
        }

        private static void ShipOrders(Order order1, Order order2)
        {
            order1.ReadyForShipping();
            order2.ReadyForShipping();
        }

        private static void UnsubscribeCustomer(Order order1, Customer customer1)
        {
            Console.WriteLine(">>> Alex unsubscribed <<<");
            order1.Unsubscribe(customer1);
        }

        private static void TestShippingAfterUnsubscribe(Order order1)
        {
            order1.ReadyForShipping();
        }
    }
}
