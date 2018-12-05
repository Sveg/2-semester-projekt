namespace _2ndsemesterprojekt
{
    public abstract class CRUDCommandBase<T, TDataViewModel> : CommandBase where TDataViewModel : IDataViewModel<T> where T : IDomainClass
    {
        protected iCatalog<T> _catalog;
        protected iPageViewModel<TDataViewModel> _pageViewModel;

        protected CRUDCommandBase(iCatalog<T> catalog, iPageViewModel<TDataViewModel> pageViewModel)
        {
            _catalog = catalog;
            _pageViewModel = pageViewModel;
        }

        protected override bool CanExecute()
        {
            return (_pageViewModel.ItemDetails != null) && (_pageViewModel.ItemDetails.DataObject() != null);
        }
    }
}