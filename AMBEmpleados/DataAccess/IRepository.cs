namespace AMBEmpleados.DataAccess
{
    using System.Collections.Generic;
    using Models;

    public interface IRepository
    {
        void Add(Employee newEmployee);

        Employee Get(int code);

        void Remove(int code);

        void Update(int code, Employee updated);

        IEnumerable<Employee> GetAll();
    }
}
