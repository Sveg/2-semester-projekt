namespace _2ndsemesterprojekt
{
    public class EmployeeDataViewModel : DataViewModelAppBase<Employee>
    {
        protected override string ItemDescription
        {
            get { return DataObject().Name; }
        }

   
        public EmployeeDataViewModel(Employee obj) : base(obj)
        {
            
        }

        public EmployeeDataViewModel()
        {
           
        }
    }
}