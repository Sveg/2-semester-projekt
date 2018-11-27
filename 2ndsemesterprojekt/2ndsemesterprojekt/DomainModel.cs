using System;

namespace _2ndsemesterprojekt
{
    public class DomainModel
    {
        private static DomainModel _instance;

        public static DomainModel Instance
        {
            get { return _instance ?? (_instance = new DomainModel()); }
        }

        private iCatalog<Employee> Employee
            {
                get { return new EmployeeConnection();}
            }
        private iCatalog<Ticket> Ticket { get; }

        public static iCatalog<T> GetCatalog<T>()
        {
            if (typeof(T) == typeof(Employee))
            {
                return (iCatalog<T>) Instance.Employee;
            }

            if (typeof(T) == typeof(Ticket))
            {
                return (iCatalog<T>) Instance.Ticket;
            }
            throw new ArgumentException($"No Catalog found for type {typeof(T)}");
        }
    }
}