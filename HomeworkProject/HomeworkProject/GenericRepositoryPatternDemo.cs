using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProject
{
    public abstract class Entity
    {
        public int Id { get; set; }
    }

    public class Book : Entity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public int ItemsInStock { get; set; }
    }

    public class Customer : Entity
    {
        public string Email { get; set; }
        public decimal Balance { get; set; }
    }

    public interface IRepository<T> where T : Entity
    {
        T GetById(int id);
        IList<T> FindAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    public class Shop
    {
        private readonly IRepository<Book> _bookRepository;
        private readonly IRepository<Customer> _customerRepository;

        public Shop(IRepository<Book> bookRepository, IRepository<Customer> customerRepository)
        {
            _bookRepository = bookRepository;
            _customerRepository = customerRepository;
        }

        public bool PurchaseBook(int customerId, int bookId)
        {
            Customer customer = _customerRepository.GetById(customerId);

            if (customer == null)
            {
                Console.WriteLine($"Customer with id {customerId} was not found!");
                return false;
            }

            Book book = _bookRepository.GetById(bookId);

            if (book == null)
            {
                Console.WriteLine($"Book with id {bookId} was not found!");
                return false;
            }    

            if (book.ItemsInStock == 0)
            {
                Console.WriteLine($"There is no books {book.Title} in stock!");
                return false;
            }    

            if (customer.Balance < book.Price)
            {
                Console.WriteLine($"Customer does not have enough money to buy the book {book.Title}");
                return false;
            }

            customer.Balance -= book.Price;
            book.ItemsInStock--;

            _customerRepository.Update(customer);
            _bookRepository.Update(book);

            Console.WriteLine($"Book {book.Title} successfully purchased by {customer.Email}");

            return true;
        }
    }

    //public class GenericRepositoryPatternDemo
    //{
    //    public static void Main(string[] args)
    //    {
    //        IRepository<Book> bookRepository = new ListRepository<Book>();

    //    }
    //}





}
