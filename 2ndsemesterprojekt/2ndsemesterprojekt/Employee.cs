using System;
using System.Collections.Generic;

namespace _2ndsemesterprojekt
{
    public partial class Employee
    {
        public Employee()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
