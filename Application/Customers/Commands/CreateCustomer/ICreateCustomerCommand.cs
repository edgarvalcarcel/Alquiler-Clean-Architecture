﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Application.Customers.Commands.CreateCustomer
{
    public interface ICreateCustomerCommand
    {
        void Execute(CreateCustomerModel model);
    }
}