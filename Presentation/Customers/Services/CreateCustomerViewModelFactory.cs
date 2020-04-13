using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Alquiler.Application.CityCounties.Queries.GetCityCountyList;
using Alquiler.Application.Customers.Commands.CreateCustomer;
using Alquiler.Presentation.Customers.Models;

namespace Alquiler.Presentation.Customers.Services
{
    public class CreateCustomerViewModelFactory : ICreateCustomerViewModelFactory
    {
        private readonly IGetCityCountiesListQuery _citycountiesQuery;

        public CreateCustomerViewModelFactory(
           IGetCityCountiesListQuery citycountiesQuery)
        {
            _citycountiesQuery = citycountiesQuery;
        }

        public CreateCustomerViewModel Create()
        {
            var citiescounties = _citycountiesQuery.Execute();
            var viewModel = new CreateCustomerViewModel
            {
                CityCounties = citiescounties
                .Select(p => new SelectListItem()
                {
                    Value = p.Id.ToString(),
                    Text = p.Name
                })
                .ToList(),

                Customer = new CreateCustomerModel()
            };
            return viewModel;
        }
    }
}