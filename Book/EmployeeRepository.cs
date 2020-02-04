using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class EmployeeRepository
    {
       private List<Employee> employees = new List<Employee>();

        internal Employee GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(x=>x.Id.Equals(id));                
        }
      internal void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }
        internal void LoadEmployees()
        {
            Employee emp = new Employee(1, "Edgar Park", "password", "Expedit");
            Employee emp1 = new Employee(2, "Margaret Newman", "12345", "Chef");
            Employee emp2 = new Employee(3, "Edith Morrison", "zinch", "Expedit");
            Employee emp3 = new Employee(4, "Hugh Saunders", "test", "Chef");
            AddEmployee(emp);
            AddEmployee(emp1);
            AddEmployee(emp2);
            AddEmployee(emp3);
        }
    }
}
