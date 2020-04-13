using Alquiler.Application.Customers.Commands.CreateCustomer;
using Alquiler.Domain.CityCounties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alquiler.Presentation.Customers.Models
{
    public class CreateCustomerViewModel
    {
        public CreateCustomerModel Customer { get; set; }
        public List<SelectListItem> CityCounties { get; set; }
    }
}