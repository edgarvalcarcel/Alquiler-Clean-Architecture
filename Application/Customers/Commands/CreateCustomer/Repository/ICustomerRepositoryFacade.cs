using Alquiler.Domain.CityCounties;
using Alquiler.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Application.Customers.Commands.CreateCustomer.Repository
{
    public interface ICustomerRepositoryFacade
    {
        Customer GetCustomer(int customerId);
        CityCounty GetCityCounty(int citycountyId);
        void AddCustomer(Customer sale);
    }
}
