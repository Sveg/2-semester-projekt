namespace _2ndsemesterprojekt
{
    public abstract class CRUDCommandBase<T, TDataViewModel> : CommandBase
    {
        protected iCatalog<T> _catalog;
        protected iPageViewModel<TDataViewModel> _pageViewModel;

        protected CRUDCommandBase(iCatalog<T> catalog, iPageViewModel<TDataViewModel> pageViewModel)
        {
            _catalog = catalog;
            _pageViewModel = pageViewModel;
        }
    }
}