namespace _2ndsemesterprojekt
{
    public class CreateTicketCommand : CreateCommand<Ticket, TicketDataViewModel>
    {
        public CreateTicketCommand(iCatalog<Ticket> catalog, iPageViewModel<TicketDataViewModel> pageViewModel) 
            : base(catalog, pageViewModel)
        {
        }

        protected override bool CanExecute()
        {
            return true;
        }
    }
}