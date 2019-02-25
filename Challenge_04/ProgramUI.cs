using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_04
{
    public class ProgramUI
    {
        CustomerRepository _customerRepo = new CustomerRepository();
        Queue<Customer> _customers = new Queue<Customer>();
        bool running = true;

        public void Run()
        {
            GetCustomerQueue();

            while (running)
            {
                Console.Clear();

            }

        }

        private void GetCustomerQueue()
        {
            //Customer customer = new Customer(Jake, Smith, Potential, "We currently have the loest rates on helicopter insurance!");
            //Customer customerTwo = new Customer(James, Smith, Current, "Thank you for your work with us. We appreciate your loyalty. Here's a coupon.");
            //Customer customerThree = new Customer(Jane, Smith, Past, "It's been a while! We are offering discounts to our customers who come back.");

            //_customerRepo.AddNewCustomer(customer);
            //_customerRepo.AddNewCustomer(customerTwo);
            //_customerRepo.AddNewCustomer(customerThree);

        }
        private void Customer()
        {
            Console.WriteLine("Choose option from menu\n" +
                "Create Customer");
        }

    }
}
