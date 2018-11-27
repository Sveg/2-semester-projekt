using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace _2ndsemesterprojekt
{
    public abstract class PageViewModelBase<T,TDataViewModel> : iPageViewModel<TDataViewModel>, INotifyPropertyChanged 
        where TDataViewModel : class, IDataViewModel<T>, new()
    where T : IDomainClass
    {
        private iCatalog<T> _catalog;
        private TDataViewModel _itemSelected;
        private CommandBase _deleteCommandObj;

        protected PageViewModelBase()
        {
            _itemSelected = null;
            _catalog = GetCatalog();
            _deleteCommandObj = new DeleteCommand<T,TDataViewModel>(_catalog, this);
        }

        public ObservableCollection<TDataViewModel> ItemCollection
        {
            get { return new ObservableCollection<TDataViewModel>(_catalog.All.Select(CreateDataViewModel).ToList());}
        }

        public TDataViewModel ItemSelected
        {
            get { return _itemSelected; }
            set
            {
                _itemSelected = value;
                OnPropertyChanged();
                _deleteCommandObj.RaiseCanExecuteChanged();
            }
        }

        public ICommand DeleteCommandObj
        {
            get { return _deleteCommandObj; }
        }

        private TDataViewModel CreateDataViewModel(T obj)
        {
            TDataViewModel dvmObj = new TDataViewModel();
            dvmObj.SetDataObject(obj);
            return dvmObj;
        }

        protected abstract iCatalog<T> GetCatalog();

        private void OnCatalogChanged(int obj)
        {
            OnPropertyChanged(nameof(ItemCollection));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}