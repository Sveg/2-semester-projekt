using System;
using System.Windows.Input;

namespace _2ndsemesterprojekt
{
    public interface INotofiableCommand : ICommand
    {
        void RaiseCanExecuteChanged();
    }
}