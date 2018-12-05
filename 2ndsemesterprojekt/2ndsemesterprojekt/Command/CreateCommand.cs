namespace _2ndsemesterprojekt
{
    public class CreateCommand<T, TDataViewModel> : CRUDCommandBase<T, TDataViewModel>
        where TDataViewModel : IDataViewModel<T>
        where T : IDomainClass
    {
        public CreateCommand(iCatalog<T> catalog, iPageViewModel<TDataViewModel> pageViewModel) : base(catalog,
            pageViewModel)
        {

        }

        protected override void Execute()
        {
            _catalog.Create(_pageViewModel.ItemDetails.DataObject());
        }
    }
}