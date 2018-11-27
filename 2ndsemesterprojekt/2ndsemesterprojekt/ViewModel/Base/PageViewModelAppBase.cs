namespace _2ndsemesterprojekt
{
    public class PageViewModelAppBase<T,TDVM> : PageViewModelBase<T,TDVM> where T : IDomainClass where TDVM : class, IDataViewModel<T>, new()
    {
        protected override iCatalog<T> GetCatalog()
        {
            return DomainModel.GetCatalog<T>();
        }
        
    }
}