using Alquiler.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.Customers
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.GovermentBusinessId).IsRequired();
            Property(p => p.Name).IsRequired();
            Property(p => p.Address).IsRequired();
            Property(p => p.CityCountyId).IsRequired();
            HasRequired(p => p.CityCounty);
            Property(p => p.Country).IsRequired();
            Property(p => p.PBX).IsRequired();
            Property(p => p.MobilePhoneMain).IsRequired();
            Property(p => p.Email).IsRequired();
        }
    }
}
