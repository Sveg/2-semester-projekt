namespace _2ndsemesterprojekt
{
    public class DeleteCommand<T, TDataViewModel> : CRUDCommandBase<T, TDataViewModel>
        where TDataViewModel : IDataViewModel<T>
        where T : IDomainClass
    {
        public DeleteCommand(iCatalog<T> catalog, iPageViewModel<TDataViewModel> pageViewModel) : base(catalog, pageViewModel)
        {

        }

        protected override bool CanExecute()
        {
            return (_pageViewModel.ItemSelected != null) && (_pageViewModel.ItemSelected.DataObject() != null);
        }

        protected override void Execute()
        {
            // T obj = _pageViewModel.ItemDetails.DataObject();
            _catalog.Delete(_pageViewModel.ItemSelected.DataObject().GetId());
            _pageViewModel.RefreshView();

        }
    }
}