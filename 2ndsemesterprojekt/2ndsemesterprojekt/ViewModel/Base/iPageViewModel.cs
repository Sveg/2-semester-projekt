using System.Collections.ObjectModel;
using System.Windows.Input;

namespace _2ndsemesterprojekt
{
    public interface iPageViewModel<TDataViewModel> 
    {
        ObservableCollection<TDataViewModel> ItemCollection { get; }
        TDataViewModel ItemSelected { get; set; }
        ICommand DeleteCommandObj { get; }
    }
}