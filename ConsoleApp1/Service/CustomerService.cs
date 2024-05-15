

using ConsoleApp1.Entities;
using ConsoleApp1.Interface;
using ConsoleApp1.Repository;

namespace ConsoleApp1.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repo;
        
        public CustomerService(ICustomerRepository cust) => _repo = cust;

        public List<Customer> GetCustomer()
        {
            List<Customer> cus = _repo.Get();
            return cus;
 
        }
    }
}
