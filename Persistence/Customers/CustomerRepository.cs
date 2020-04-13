using Alquiler.Application.Interfaces.Persistence;
using Alquiler.Domain.Customers;
using Alquiler.Persistence.Shared;

namespace CleanArchitecture.Persistence.Customers
{
    public class CustomerRepository 
        : Repository<Customer>, 
        ICustomerRepository
    {
        public CustomerRepository(IDatabaseContext database) 
            : base(database) { }
    }
}