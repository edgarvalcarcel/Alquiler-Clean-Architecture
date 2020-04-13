using Alquiler.Application.Customers.Commands.CreateCustomer.Factory;
using Alquiler.Application.Customers.Commands.CreateCustomer.Repository;
using Alquiler.Application.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Application.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommand : ICreateCustomerCommand
    {
        private readonly ICustomerRepositoryFacade _repositories; 
        private readonly ICustomerFactory _factory;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCustomerCommand(
          ICustomerRepositoryFacade repositories,
          ICustomerFactory factory,
          IUnitOfWork unitOfWork)
        { 
            _repositories = repositories;
            _factory = factory;
            _unitOfWork = unitOfWork;
           
        }

        public void Execute(CreateCustomerModel model)
        {
            var _customer = _repositories.GetCustomer(model.CustomerId);
            var _cityCounty = _repositories.GetCityCounty(model.CityCountyId);
            var customer = _factory.Create(_customer, _cityCounty);
            _repositories.AddCustomer(customer);
            _unitOfWork.Save();

        }
    }
}
