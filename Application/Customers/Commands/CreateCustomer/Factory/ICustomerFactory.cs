using Alquiler.Domain.CityCounties;
using Alquiler.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Application.Customers.Commands.CreateCustomer.Factory
{
    public interface ICustomerFactory
    {
        Customer Create(Customer customer, CityCounty CityCounty);
    }
}
