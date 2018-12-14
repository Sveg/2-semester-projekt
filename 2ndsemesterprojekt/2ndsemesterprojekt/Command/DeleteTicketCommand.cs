namespace _2ndsemesterprojekt
{
    public class DeleteTicketCommand : DeleteCommand<Ticket, TicketDataViewModel>
    {
        public DeleteTicketCommand(iCatalog<Ticket> catalog, iPageViewModel<TicketDataViewModel> pageViewModel)
            : base(catalog, pageViewModel)
        {
            
        }
        protected override bool CanExecute()
        {
            return true;
        }
    }
}