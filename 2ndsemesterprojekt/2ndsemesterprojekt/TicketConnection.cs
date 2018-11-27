using System.Collections.Generic;

namespace _2ndsemesterprojekt
{
    public class TicketConnection : DataViewModelBase<Ticket>
    {
        public TicketConnection(Ticket obj) : base(obj)
        {

        }

        public string ShowTickets
        {
            get { return DataObject().ToString(); }
        }

        public string GetName
        {
            get { return DataObject().FullName; }
        }
        public string GetMail
        {
            get { return DataObject().Email; }
        }
        public string GetHelpTopic
        {
            get { return DataObject().HelpTopic; }
        }
        public string GetMesssage
        {
            get { return DataObject().Message; }
        }
        public string GetSubject
        {
            get { return DataObject().Subject; }
        }

        public int? GetTelephone
        {
            get { return DataObject().Telephone; }
        }

        public int? GetEmployeeId
        {
            get { return DataObject().EmployeeId; }
        }

        public int Get
        {
            get { return DataObject().TicketId; }
        }



    }
}