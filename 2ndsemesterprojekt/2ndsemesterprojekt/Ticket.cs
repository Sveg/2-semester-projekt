using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _2ndsemesterprojekt
{
    public partial class Ticket : IDomainClass
    {
        public Ticket()
        {
            Status = "Open";
        }
        public string Subject { get; set; }
        

        public string Email { get; set; }

        public string Status { get; set; }

        public int TicketId { get; set; }
        public string FullName { get; set; }
        public int? Telephone { get; set; }
        public string HelpTopic { get; set; }
        public string Message { get; set; }
        public string Attachment { get; set; }
        public int? EmployeeId { get; set; }
        public string CompanyName { get; set; }
        public DateTime Dato { get; set; }

        public Employee Employee { get; set; }
        
        public int GetId()
        {
            return TicketId;
        }

        public void SetId( int id )
        {
            TicketId = id;
        }

        
    }
}
