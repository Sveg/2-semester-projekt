using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace _2ndsemesterprojekt
{
    public abstract class DataViewModelBase<T> : IDataViewModel<T>
    {
        private T _obj { get; set; }

        protected DataViewModelBase(T obj)
        {
            _obj = obj;
        }

        protected DataViewModelBase()
        {
            _obj = default(T);
        }

        public T DataObject()
        {
            return _obj;
        }

        public void SetDataObject(T obj)
        {
            _obj = obj;
        }

    }
}