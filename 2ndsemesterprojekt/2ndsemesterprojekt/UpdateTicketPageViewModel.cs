using System.Collections.ObjectModel;
using System.Windows.Input;
using Windows.Graphics.Printing.PrintTicket;
using _2ndsemesterprojekt.ViewModel.Base;

namespace _2ndsemesterprojekt
{
    public class UpdateTicketPageViewModel : CreateTicketPageViewModel
    {
        private UpdateTicketCommand _updateTicketCommand;
        private CommandBase _UpdateCommandObject;

        public UpdateTicketPageViewModel()  
        {
            _UpdateCommandObject = new UpdateCommand<Ticket, TicketDataViewModel>(_catalog, this);

            _updateTicketCommand = new UpdateTicketCommand(_catalog, this);
        }

        public ICommand UpdateTicket
        {
            get { return _updateTicketCommand; }
        }

        public ObservableCollection<TicketDataViewModel> ItemCollect
        {
            get
            {
               ObservableCollection<TicketDataViewModel> collection = new ObservableCollection<TicketDataViewModel>();
                foreach (var item in _catalog.All)
                {
                    TicketDataViewModel dvm = new TicketDataViewModel();
                    dvm.SetDataObject(item);
                    collection.Add(dvm);
                }

                return collection;
            }
        }
    }
}