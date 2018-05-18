using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADPAIntegratedSolution.Web.Models
{
    public class EmployeeViewModel
    {
        public Guid Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public decimal Phone { get; set; }
        public decimal Salary { get; set; }
    }
}
