using System;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace _2ndsemesterprojekt.Navigation
{
    public class BaseClassNavigate : ICommand
    {
        private Frame _frame;
        private Type _pageType;

        public BaseClassNavigate(Frame frame, Type pageType)
        {
            _frame = frame;
            _pageType = pageType;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _frame.Navigate(_pageType);
        }
    }
}