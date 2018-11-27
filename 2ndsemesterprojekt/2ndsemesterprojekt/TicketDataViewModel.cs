namespace _2ndsemesterprojekt
{
    public class TicketDataViewModel : DataViewModelAppBase<Ticket>
    {
        protected override string ItemDescription
        {
            get { return DataObject().Email; }
        }


        public TicketDataViewModel(Ticket obj) : base(obj)
        {

        }

        public TicketDataViewModel()
        {

        }
    }
}