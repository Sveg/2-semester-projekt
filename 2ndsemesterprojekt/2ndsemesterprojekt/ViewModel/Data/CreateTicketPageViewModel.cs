using System.Windows.Input;
using _2ndsemesterprojekt.ViewModel.Base;

namespace _2ndsemesterprojekt
{
    public class CreateTicketPageViewModel : CreatePageViewModelBase<Ticket, TicketDataViewModel>
    {
        private CreateTicketCommand _CreateCommand;

        public CreateTicketPageViewModel()
        {
            Ticket t = new Ticket();
           
            _itemBeingCreated = new TicketDataViewModel(t);
            
            _CreateCommand = new CreateTicketCommand(_catalog, this);
        }

        public ICommand CreateTicketCommandObj
        {
            get { return _CreateCommand; }
        }
    }
}