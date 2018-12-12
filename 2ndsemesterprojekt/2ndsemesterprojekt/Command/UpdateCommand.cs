using System;

namespace _2ndsemesterprojekt
{
    public class UpdateCommand<T,TDataViewModel> : CRUDCommandBase<T, TDataViewModel> 
        where TDataViewModel : IDataViewModel<T> where T : IDomainClass
    {
        public UpdateCommand(iCatalog<T> catalog, iPageViewModel<TDataViewModel> pageViewModel) 
            : base(catalog, pageViewModel)
        {
                
        }

        

        protected override void Execute()
        {
            T obj = _pageViewModel.ItemDetails.DataObject();
            _catalog.Update(obj.GetId(), obj);
        }
    }
}