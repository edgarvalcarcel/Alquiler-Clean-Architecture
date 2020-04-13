using System.Collections.Generic;

namespace Alquiler.Application.Customers.Queries.GetCustomerList
{
    public interface IGetCustomersListQuery
    {
        List<CustomerModel> Execute();
    }
}