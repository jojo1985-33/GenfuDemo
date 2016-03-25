using System.Collections.Generic;
using GenFu;

namespace GenfuDemo.Models
{
    class CustomerService : ICustomerService
    {
        private List<Customer> _customers;

        public CustomerService()
        {
            _customers = A.ListOf<Customer>();
        }

        public List<Customer> GetCustomers()
        {
            return _customers;
        }
    }
}
