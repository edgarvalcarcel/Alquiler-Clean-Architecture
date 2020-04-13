using Alquiler.Domain.Projects;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Persistence.Projects
{
    public class ProjectConfiguration : EntityTypeConfiguration<Project>
    {
        public ProjectConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(60);
            Property(p => p.Address).IsRequired().HasMaxLength(100);
            Property(p => p.CityCountyId).IsRequired();
            HasRequired(p => p.CityCounty);
            Property(p => p.CustomerId).IsRequired();
            HasRequired(p => p.Customer); 
            Property(p => p.ProjectPhoneAlt).IsRequired().HasMaxLength(30);
            Property(p => p.MobilePhoneMain).IsRequired().HasMaxLength(30);
            Property(p => p.MobilePhoneAlt).IsRequired().HasMaxLength(30);
            Property(p => p.Contact).IsRequired().HasMaxLength(100);
            Property(p => p.Email).IsRequired().HasMaxLength(120);
            Property(p => p.Comments).IsRequired().HasMaxLength(200);
        }
    }
}
