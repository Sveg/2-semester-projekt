using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _2ndsemesterprojekt.ViewModel.Base
{
    public class CreatePageViewModelBase<T, TDataViewModel> : INotifyPropertyChanged, iPageViewModel<TDataViewModel>
        where TDataViewModel : class, IDataViewModel<T>
        where T : IDomainClass, new()
    {
        protected iCatalog<T> _catalog;
        protected TDataViewModel _itemBeingCreated;
        private CommandBase _createCommandObject;
        

        public CreatePageViewModelBase()
        {
            _catalog = DomainModel.GetCatalog<T>();
            _createCommandObject = new CreateCommand<T, TDataViewModel>(_catalog, this);
            
    
        }

        public TDataViewModel ItemSelected
        {
            get { return _itemBeingCreated; }
            set { _itemBeingCreated = value; }
        }

        public ICommand CreateCommandObject
        {
            get { return _createCommandObject; }
        }

        public ObservableCollection<TDataViewModel> ItemCollection
        {
            get { return null; }
        }

        public TDataViewModel ItemDetails
        {
            get { return ItemSelected; }
        }

        public ICommand DeleteCommandObj
        {
            get { throw new NotImplementedException();}
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
