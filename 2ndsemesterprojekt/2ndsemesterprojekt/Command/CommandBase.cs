using System;

namespace _2ndsemesterprojekt
{
    public abstract class CommandBase : INotofiableCommand
    {
        public bool CanExecute(object parameter)
        {
            return CanExecute();
        }

        public void Execute(object parameter)
        {
            Execute();
        }
        protected abstract void Execute();
        protected virtual bool CanExecute()
        {
            return true;
        }


        public event EventHandler CanExecuteChanged;
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}