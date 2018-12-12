using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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

        public string FullName
        {
            get { return DataObject().FullName; }
            set
            {
                DataObject().FullName = value;
                OnPropertyChanged();
            }
        }

        public string CompanyName
        {
            get { return DataObject().CompanyName; }
            set
            {
                DataObject().CompanyName = value;
                OnPropertyChanged();
            }
        }

        public int? Telephone
        {
            get { return DataObject().Telephone; }
            set
            {
                DataObject().Telephone = value;
                OnPropertyChanged();
            }
        }

        public object HelpTopic
        {
            get { return DataObject().HelpTopic; }
            set
            {
                DataObject().HelpTopic = value.ToString();
                OnPropertyChanged();
            }
        }

        public string Subject
        {
            get { return DataObject().Subject; }
            set
            {
                DataObject().Subject = value;
                OnPropertyChanged();
            }
        }

        public string Message
        {
            get { return DataObject().Message; }
            set
            {
                DataObject().Message = value;
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
            set
            {
                DataObject().Email = value;
                OnPropertyChanged();
            }
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