using System;
using System.Collections.Generic;

namespace EmployeeDBFirst.Models
{
    public partial class City
    {
        public City()
        {
            Employees = new HashSet<Employee>();
        }

        public int CityId { get; set; }
        public string? CityNameArabic { get; set; }
        public string CityNameEnglish { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
