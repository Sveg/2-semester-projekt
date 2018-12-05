using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Appointments;

namespace _2ndsemesterprojekt
{
    public class TicketDataViewModel : DataViewModelAppBase<Ticket>, INotifyPropertyChanged
    {
        public string Status
        {
            get { return DataObject().Status; }
            set
            {
                DataObject().Status = value;
                OnPropertyChanged();
            }
        }

        public int TicketId
        {
            get { return DataObject().TicketId; }
            set
            {
                DataObject().TicketId = TicketId;

            }
        }
        public string Email
        {
            get { return DataObject().Email; }
        }

        public string Date
        {
            get { return DataObject().Dato.ToString(); }
        }

        public override string ToString()
        {
            return $"{Status} {TicketId} {Email} {Date}";
        }

        public TicketDataViewModel(Ticket obj) : base(obj)
        {

        }

        public TicketDataViewModel()
        {

        }

        #region OnPropertyChanged


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}