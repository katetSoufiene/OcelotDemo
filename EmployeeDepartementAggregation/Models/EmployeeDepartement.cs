using System.Collections.Generic;

namespace EmployeeDepartementAggregation.Models
{
    public class EmployeeDepartement
    {
        public Employee Employee { get; set; }

        public Departement Departement { get; set; }
    }
}
