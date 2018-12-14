namespace _2ndsemesterprojekt
{
    public interface IDomainClass
    {
        int GetId();
        void SetId(int id);
        IDomainClass Copy();
    }
}