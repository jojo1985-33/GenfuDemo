using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenfuDemo.Models
{
    interface ICustomerService
    {
        List<Customer> GetCustomers();
    }
}
