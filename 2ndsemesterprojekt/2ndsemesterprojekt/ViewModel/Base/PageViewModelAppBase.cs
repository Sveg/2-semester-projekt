namespace _2ndsemesterprojekt
{
    public class PageViewModelAppBase<T,TDVM> : PageViewModelBaseV2<T,TDVM> where T : IDomainClass, new() where TDVM : class, IDataViewModel<T>, new()
    {
        protected override iCatalog<T> GetCatalog()
        {
            return DomainModel.GetCatalog<T>();
        }

        protected override void NotifyCommands()
        {
            _deleteCommandObj.RaiseCanExecuteChanged();
            _UpdateCommandObj.RaiseCanExecuteChanged();
        }
    }
}