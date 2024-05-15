using ConsoleApp1.Entities;
using ConsoleApp1.Interface;
using ConsoleApp1.Repository;
using ConsoleApp1.Service;

class Program
{
    static void Main(string[] args)
    {
        ICustomerRepository repo = new CustomerRepository();

        ICustomerService service = new CustomerService(repo);

        List<Customer> customers = service.GetCustomer();
       
        Console.WriteLine("Los customer son : \n");
        foreach(var cust in customers)
        {
            Console.WriteLine($"Nombre : {cust.Name} y su id es : {cust.Id}");
        }


        

    }
}