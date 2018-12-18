namespace _2ndsemesterprojekt
{
    public interface IDataViewModel<T>
    {
        T DataObject();
        void SetDataObject(T obj);
    }
}