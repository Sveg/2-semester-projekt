using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Appointments;

namespace _2ndsemesterprojekt
{
    public partial class Employee : IDomainClass
    {
        public Employee()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<Ticket> Tickets { get; set; }

        public int GetId()
        {
            return 0;
        }

        public IDomainClass Copy()
        {
            return null;
        }

        public void SetId(int id)
        {
            EmployeeId = id;
        }
    }
}
