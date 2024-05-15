

using ConsoleApp1.Entities;
using ConsoleApp1.Interface;

namespace ConsoleApp1.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly  List<Customer>_customer;

        public CustomerRepository()
        {
            _customer = new List<Customer>();

            _customer.Add(new Customer { Id = 1, Name = "Pepe" });
            _customer.Add(new Customer { Id = 2, Name = "Juan" });
            _customer.Add(new Customer { Id = 3, Name = "Jose" });
        }

        public List<Customer> Get()
        {
            return _customer;
        }
    }
}
