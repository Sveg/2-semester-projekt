namespace _2ndsemesterprojekt
{
    public abstract class DataViewModelAppBase<T> : DataViewModelBase<T>
    {
       protected DataViewModelAppBase() { }
        protected  DataViewModelAppBase(T obj) : base(obj) { }

        public override string ToString()
        {
            return ItemDescription;
        }
        protected abstract string ItemDescription { get; }
    }
}