using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alquiler.Application.Interfaces.Persistence;
using Alquiler.Domain.CityCounties;
using Alquiler.Domain.Customers;

namespace Alquiler.Application.Customers.Commands.CreateCustomer.Repository
{
    public class CustomerRepositoryFacade : ICustomerRepositoryFacade
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICityCountyRepository _citycountyRepository;

        public CustomerRepositoryFacade(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void AddCustomer(Customer customer)
        {
            _customerRepository.Add(customer);
        }

        public Customer GetCustomer(int customerId)
        {
            return _customerRepository.Get(customerId);
        }

        public CityCounty GetCityCounty(int CityCountyId)
        {
            return _citycountyRepository.Get(CityCountyId);
        }
    }
}
