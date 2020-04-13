using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alquiler.Domain.CityCounties;
using Alquiler.Domain.Customers;

namespace Alquiler.Application.Customers.Commands.CreateCustomer.Factory
{
    public class CustomerFactory : ICustomerFactory
    {
        public Customer Create(Customer customer, CityCounty CityCounty)
        {
            var _customer = new Customer
            {
                CityCounty = CityCounty,
                CityCountyId = CityCounty.Id
            };
            return _customer;
        }
    }
}
