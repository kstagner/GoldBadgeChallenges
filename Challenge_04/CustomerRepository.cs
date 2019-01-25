using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_04
{
    public class CustomerRepository
    {
        Queue<Customer> _customers = new Queue<Customer>();

        private Customer newCustomer;

        public Queue<Customer> GetCustomerList()
        {
            return _customers;
        }

        public void AddNewCustomer(Customer newcustomer)
        {
            _customers.Enqueue(newCustomer);
        }       
        public void RemoveCustomer()
        { 
            _customers.Dequeue();
        }
        public Customer UpdateCustomerInfo()
        {
            Customer customer = _customers.Peek();
            return customer;
        }
    }
}
