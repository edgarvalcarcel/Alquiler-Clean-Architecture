using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.Application.Customers.Commands.CreateCustomer
{
    public class CreateCustomerModel
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Employee Name is required")]
        [StringLength(12)]
        [Display(Name = "Nit")]
        public string GovermentBusinessId { get; set; }

        [Required(ErrorMessage = "Employee Name is required")]
        [StringLength(60, MinimumLength = 4)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Employee Name is required")]
        [StringLength(120, MinimumLength = 10)]
        [Display(Name = "Direccion")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Employee Name is required")]
        [Display(Name = "Ciudad")]
        public int CityCountyId { get; set; }

        [Required(ErrorMessage = "Employee Name is required")]
        [Display(Name = "Pais")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Employee Name is required")]
        [StringLength(20, MinimumLength = 7)]
        [Display(Name = "PBX")]
        public string PBX { get; set; }

        [StringLength(20, MinimumLength = 7)]
        [Display(Name = "Telefono Oficina")]
        public string OfficePhoneAlt { get; set; }

        [Required(ErrorMessage = "Employee Name is required")]
        [StringLength(20, MinimumLength = 10)]
        [Display(Name = "Celular Oficina")]
        public string MobilePhoneMain { get; set; }

        [StringLength(20, MinimumLength = 10)]
        [Display(Name = "Celular Alterno")]
        public string MobilePhoneAlt { get; set; }

        [StringLength(200, MinimumLength = 11)]
        [Display(Name = "Sitio web")]
        public string Website { get; set; }

        [Required(ErrorMessage = "Employee Name is required")]
        [StringLength(200, MinimumLength = 7)]
        [Display(Name = "Correo Electrónico")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z")]
        public string Email { get; set; }

        [StringLength(250)]
        [Display(Name = "Comentarios")]
        public string Comments { get; set; }
    }
}
