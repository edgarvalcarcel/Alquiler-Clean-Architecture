using Alquiler.Domain.CityCounties;
using Alquiler.Domain.Common;
using Alquiler.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Domain.Projects
{
    public class Project : IEntity
    {
        public int Id { get; set; } 
        public string Name{get; set;}
        public string Address { get; set; }
        public int CityCountyId { get; set; }
        public CityCounty CityCounty { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string ProjectPhoneAlt { get; set; }
        public string MobilePhoneMain { get; set; }
        public string MobilePhoneAlt { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }
    }
}
