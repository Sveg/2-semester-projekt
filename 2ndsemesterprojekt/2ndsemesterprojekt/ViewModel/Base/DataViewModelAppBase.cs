using Windows.Devices.AllJoyn;

namespace _2ndsemesterprojekt
{
    public abstract class DataViewModelAppBase<T> : DataViewModelBase<T>
    {
       protected DataViewModelAppBase() { }
        protected  DataViewModelAppBase(T obj) : base(obj) { }

        
        public int GetId()
        {
           return 0;
        }
    }
}