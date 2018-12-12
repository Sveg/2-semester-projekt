namespace _2ndsemesterprojekt
{
    public class UpdateTicketCommand : UpdateCommand<Ticket, TicketDataViewModel>
    {
        public UpdateTicketCommand(iCatalog<Ticket> catalog, iPageViewModel<TicketDataViewModel> pageViewModel)
            : base(catalog, pageViewModel)
        {
            
        }

        protected override bool CanExecute()
        {
            return true;
        }
    }
}